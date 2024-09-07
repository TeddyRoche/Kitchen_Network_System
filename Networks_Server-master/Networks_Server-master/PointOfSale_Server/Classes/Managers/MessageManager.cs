using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Xml;
using PointOfSale_Server.Classes.Messages;

namespace PointOfSale_Server.Classes.Managers
{
    public delegate void TableStatusMessageRecieved(MessageBase RawMessage);
    public delegate void OrderUpdateMessageRecieved(MessageBase RawMessage);
    public delegate void OrderPaymentCompleteMessageRecieved(MessageBase RawMessage);
    public delegate void NewClientConnected(Socket ClientSocket);

    public static class MessageTypes
    {
        public const string OrderUpdateMessages = "UPDATEFOODORDER";
    }

    public class ClientSocketObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 4096;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        public Socket ClientSocket = null;
    }

    public sealed class MessageManager
    {
        public static TableStatusMessageRecieved OnTableStatusMessageRecievedDelegate;
        public static OrderUpdateMessageRecieved OnOrderUpdateMessageRecieved;
        public static OrderPaymentCompleteMessageRecieved OnOrderPaymentCompleteMessageRecieved;
        public static NewClientConnected OnNewClientConnected;
        private static Dictionary<string, MessageBase> MessageLookup = new Dictionary<string, MessageBase>();


        MessageManager() 
        {
            SetupMessageLookups();
        }
        private static readonly object lockobject = new object();
        private static MessageManager instance = null;

        private static Thread ListenForMessagesClient;
        private static Thread ListenForMessagesKitchen;


        public static ManualResetEvent allDone = new ManualResetEvent(false);

        private const int PORT_NUMBER_CLIENT = 9000;
        private const int PORT_NUMBER_KITCHEN = 9001;

        private static Socket ServerListenSocket = null;
        private static Socket KitchenListenSocket = null;


        private static List<ClientSocketObject> ListConnectedClients = new List<ClientSocketObject>();

        public static MessageManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockobject)
                    {
                        if (instance == null)
                        {
                            instance = new MessageManager();
                        }
                    }
                }
                return instance;
            }
        }

        private static void SetupMessageLookups()
        {
            MessageLookup.Add("UPDATETABLESTATUS", new UpdateTableStatusMessage());
            MessageLookup.Add(MessageTypes.OrderUpdateMessages, new OrderUpdateMessage());
            MessageLookup.Add("PAYMENTACCEPTED", new PaymentAcceptedMessage());
        }

        private static void  ListenForConnections()
        {
            while (true)
            {
                allDone.Reset();

                Console.WriteLine("Waiting for a connection...");
                ServerListenSocket.BeginAccept(
                    new AsyncCallback(AcceptCallback),
                    ServerListenSocket);

                // Wait until a connection is made before continuing.  
                allDone.WaitOne();
            }
        }
        private static void ListenForKitchen()
        {
            while (true)
            {
                allDone.Reset();

                Console.WriteLine("Waiting for a connection...");
                KitchenListenSocket.BeginAccept(
                    new AsyncCallback(AcceptCallback),
                    KitchenListenSocket);

                // Wait until a connection is made before continuing.  
                allDone.WaitOne();
            }
        }

        /*private static void ListenForConnectionsKitchen()
        {
            while (true)
            {
                allDone.Reset();

                Console.WriteLine("Waiting for a connection...");
                ServerListenSocket.BeginAccept(
                    new AsyncCallback(AcceptCallback),
                    ServerListenSocket);

                // Wait until a connection is made before continuing.  
                allDone.WaitOne();
            }
        }*/

        public static void StartServerSocket()
        {
            IPHostEntry LocalHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress LocalIPv4Address = LocalHostEntry.AddressList[0];
            foreach (IPAddress Address in LocalHostEntry.AddressList)
            {
                if (Address.AddressFamily == AddressFamily.InterNetwork)
                {
                    LocalIPv4Address = Address;
                    break;
                }
            }

            IPEndPoint localEndPointClient = new IPEndPoint(LocalIPv4Address, PORT_NUMBER_CLIENT);
            IPEndPoint localEndPointKitchen = new IPEndPoint(LocalIPv4Address, PORT_NUMBER_KITCHEN);


            ServerListenSocket = new Socket(LocalIPv4Address.AddressFamily,
                         SocketType.Stream, ProtocolType.Tcp);

            KitchenListenSocket = new Socket(LocalIPv4Address.AddressFamily,
             SocketType.Stream, ProtocolType.Tcp);


            try
            {

                ServerListenSocket.Bind(localEndPointClient);
                KitchenListenSocket.Bind(localEndPointKitchen);


                ServerListenSocket.Listen(10);
                KitchenListenSocket.Listen(10);


                ListenForMessagesClient = new Thread(ListenForConnections);
                ListenForMessagesKitchen = new Thread(ListenForKitchen);

                ListenForMessagesClient.Start();
                ListenForMessagesKitchen.Start();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.  
            allDone.Set();

            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler;
            try
            {
                handler = listener.EndAccept(ar);
            }
            catch(Exception e)
            {
                Console.WriteLine("Socket Terminated.");
                return;
            }

            // Create the state object.  
            ClientSocketObject Client = new ClientSocketObject();
            Client.ClientSocket = handler;
            ListConnectedClients.Add(Client);
            OnNewClientConnected.Invoke(Client.ClientSocket);
            handler.BeginReceive(Client.buffer, 0, ClientSocketObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), Client);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            ClientSocketObject Client = (ClientSocketObject)ar.AsyncState;
            Socket handler = Client.ClientSocket;

            // Read data from the client socket.
            int bytesRead = 0;
            try
            { 
                bytesRead = handler.EndReceive(ar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Client Terminated");
                return;
            }


            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.  
                Client.sb.Append(Encoding.ASCII.GetString(
                    Client.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read
                // more data.  
                content = Client.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the
                    // client. Display it on the console.  
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);

                    XmlDocument xml = new XmlDocument();
                    string RawMessageContent = content.Replace("<EOF>", "");
                    try
                    {
                        xml.LoadXml(RawMessageContent);
                        MessageLookup[xml.DocumentElement.Name].PopulateMessage(xml);
                        HandleMessage(MessageLookup[xml.DocumentElement.Name]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("XML ERROR: {0}", e.ToString());
                    }
                    Client.sb.Clear();

                    handler.BeginReceive(Client.buffer, 0, ClientSocketObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), Client);
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(Client.buffer, 0, ClientSocketObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), Client);
                }
            }
        }

        public static void HandleMessage(MessageBase Message)
        {
            switch (Message.GetMessageType())
            {
                case "UPDATETABLESTATUS":
                    OnTableStatusMessageRecievedDelegate.Invoke(Message);
                    break;
                case "UPDATEFOODORDER":
                    OnOrderUpdateMessageRecieved.Invoke(Message);
                    break;
                case "PAYMENTACCEPTED":
                    OnOrderPaymentCompleteMessageRecieved.Invoke(Message);
                    break;
            }
            
        }

        public static bool SendMessageToAllClients(string Message)
        {
            try
            {
                List<ClientSocketObject> SocketsToDelete = new List<ClientSocketObject>();
                foreach(ClientSocketObject Client in ListConnectedClients)
                {
                    if(Client.ClientSocket.Connected)
                    {
                        Client.ClientSocket.Send(Encoding.UTF8.GetBytes(Message));
                    }
                    else
                    {
                        SocketsToDelete.Add(Client);
                    }
                }
                foreach(ClientSocketObject DeleteObject in SocketsToDelete)
                {
                    ListConnectedClients.Remove(DeleteObject);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Unable to send message: {0}", e.ToString());
                return false;
            }
            return true;
        }

        public static bool SendMessageToClient(string Message, Socket Client)
        {
            try
            {
                if (Client.Connected)
                {
                    Client.Send(Encoding.UTF8.GetBytes(Message));
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to send message: {0}", e.ToString());
                return false;
            }
            return true;
        }

        public static void CloseAllConnections()
        {
            foreach (ClientSocketObject Client in ListConnectedClients)
            {
                if (Client.ClientSocket.Connected)
                {
                    Client.ClientSocket.Shutdown(SocketShutdown.Both);
                    Client.ClientSocket.Close();
                }
            }
            ListenForMessagesClient.Abort();
            ListenForMessagesKitchen.Abort();
            try
            {
                ServerListenSocket.Shutdown(SocketShutdown.Both);
                ServerListenSocket.Close();
                KitchenListenSocket.Shutdown(SocketShutdown.Both);
                KitchenListenSocket.Close();

            }
            catch (Exception e)
            {
                ServerListenSocket.Dispose();
                KitchenListenSocket.Dispose();

            }
        }
    }
}
