using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Xml;
using PointOfSale_Client.Classes.Messages;

namespace PointOfSale_Client.Classes.Managers
{
    public delegate void OnServerStatusChanged(bool IsConnected);
    public delegate void UpdateTableStatusMessageRecieved(MessageBase Message);
    public delegate void OrderUpdatedMessageRecieved(MessageBase Message);
    public delegate void OrderPaymentRecieved(MessageBase Message);

    public class ServerSocketObject
    {
        // Size of receive buffer.  
        public const int BufferSize = 8192;

        // Receive buffer.  
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        public StringBuilder sb = new StringBuilder();

        // Client socket.
        public Socket ServerSocket = null;
    }

    public sealed class MessageManager
    {
        MessageManager() 
        {
            SetupMessageLookups();
        }
        private static readonly object lockobject = new object();
        private static MessageManager instance = null;

        public static OnServerStatusChanged ServerStatusChangedDelegate;
        public static UpdateTableStatusMessageRecieved OnUpdateTableStatusMessageRecieved;
        public static OrderUpdatedMessageRecieved OnOrderUpdatedMessageRecieved;
        public static OrderPaymentRecieved OnOrderPaymentRecieved;

        private static Dictionary<string, MessageBase> MessageLookup = new Dictionary<string, MessageBase>();

        private static Thread ListenForMessages;

        public static bool IsConnectedToSever = false;

        private const int PORT_NUMBER = 9000;
        private static Socket ServerSocket = null;

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
            MessageLookup.Add("UPDATEFOODORDER", new OrderUpdateMessage());
            MessageLookup.Add("PAYMENTACCEPTED", new PaymentAcceptedMessage());
        }

        public static bool ConnectToServer(string IPAddressString)
        {
            try
            {
                IPAddress ServerAddress = IPAddress.Parse(IPAddressString);
                IPEndPoint ServerEndPoint = new IPEndPoint(ServerAddress, PORT_NUMBER);

                // Creation TCP/IP Socket using
                // Socket Class Constructor
                ServerSocket = new Socket(ServerAddress.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    ServerSocket.BeginConnect(ServerEndPoint,
                        new AsyncCallback(ConnectCallback), ServerSocket);
                    
                }

                // Manage of Socket's Exceptions
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                    ServerStatusChangedDelegate.Invoke(false);
                    return false;
                }

                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                    ServerStatusChangedDelegate.Invoke(false);
                    return false;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                    ServerStatusChangedDelegate.Invoke(false);
                    return false;
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                ServerStatusChangedDelegate.Invoke(false);
                return false;
            }
            return true;
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.  
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());


                ServerStatusChangedDelegate.Invoke(true);

                IsConnectedToSever = true;

                try
                {
                    // Create the state object.  
                    ServerSocketObject ServerObject = new ServerSocketObject();
                    ServerObject.ServerSocket = client;

                    // Begin receiving the data from the remote device.  
                    client.BeginReceive(ServerObject.buffer, 0, ServerSocketObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), ServerObject);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static bool CloseConnection()
        {
            IsConnectedToSever = false;
            ServerStatusChangedDelegate.Invoke(false);
            try
            {
                ServerSocket.Shutdown(SocketShutdown.Both);
                ServerSocket.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to shutdown socket: {0}", e.ToString());
                return false;
            }
            return true;
        }

        public static bool SendMessageToServer(string Message)
        {
            if (!CheckIfConnected())
            {
                return false;
            }
            try
            {
                ServerSocket.Send(Encoding.UTF8.GetBytes(Message));
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to send message: {0}", e.ToString());
                ServerStatusChangedDelegate.Invoke(false);
                return false;
            }
            return true;
        }

        private static bool CheckIfConnected()
        {
            if (IsConnectedToSever && ServerSocket.Connected)
            {
                return true;
            }
            else
            {
                ServerStatusChangedDelegate.Invoke(false);
                IsConnectedToSever = false;
                return false;
            }
        }


        private static void ReceiveCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            try
            {
                // Retrieve the state object and the client socket
                // from the asynchronous state object.  
                ServerSocketObject ServerObject = (ServerSocketObject)ar.AsyncState;
                Socket client = ServerObject.ServerSocket;

                // Read data from the remote device.  
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.  
                    ServerObject.sb.Append(Encoding.ASCII.GetString(ServerObject.buffer, 0, bytesRead));

                    content = ServerObject.sb.ToString();
                    if (content.IndexOf("<EOF>") > -1)
                    {
                        Console.WriteLine("Read {0} bytes from socket. \n Data : {1}", content.Length, content);


                        XmlDocument xml = new XmlDocument();
                        string RawMessageContent = content.Replace("<EOF>", "");
                        try
                        {
                            xml.LoadXml(RawMessageContent);
                            MessageLookup[xml.DocumentElement.Name].PopulateMessage(xml);
                            HandleMessage(MessageLookup[xml.DocumentElement.Name]);
                        }
                        catch(Exception ex) { Console.WriteLine(ex.ToString()); }
                            //HandleMessage(updateTableStatusMessage);
                        ServerObject.sb.Clear();

                        client.BeginReceive(ServerObject.buffer, 0, ServerSocketObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), ServerObject);

                    }
                    else
                    {
                        // Get the rest of the data.  
                        client.BeginReceive(ServerObject.buffer, 0, ServerSocketObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), ServerObject);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public static void HandleMessage(MessageBase Message)
        {
            switch (Message.GetMessageType())
            {
                case "UPDATETABLESTATUS":
                    if(OnUpdateTableStatusMessageRecieved != null)
                        OnUpdateTableStatusMessageRecieved.Invoke(Message);
                    break;
                case "UPDATEFOODORDER":
                    OnOrderUpdatedMessageRecieved.Invoke(Message);
                    break;
                
            }

        }
    }
}
