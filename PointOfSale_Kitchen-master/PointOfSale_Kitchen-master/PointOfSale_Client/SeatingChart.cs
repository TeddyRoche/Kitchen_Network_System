using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale_Client.Classes;
using PointOfSale_Client.Forms;
using PointOfSale_Client.Classes.Managers;
using PointOfSale_Client.Classes.Messages;

namespace PointOfSale_Client
{
    public partial class SeatingChart : Form
    {


        public static bool OrderComplete = false;

        public SeatingChart()
        {
            InitializeComponent();

            MessageManager.ServerStatusChangedDelegate += OnServerStatusChanged;
            MessageManager.OnOrderUpdatedMessageRecieved += OnOrderUpdateMessageRecieved;
        }

        List<OrderUpdateMessage> KitchenQueue = new List<OrderUpdateMessage>();

        protected void OnOrderUpdateMessageRecieved(MessageBase Message)
        {
            //OrderUpdateMessage orderUpdatedMessage = new OrderUpdateMessage();
            OrderUpdateMessage orderUpdatedMessage = (OrderUpdateMessage)Message;
            OrderUpdateMessage newMessage = new OrderUpdateMessage(orderUpdatedMessage.FullOrder);
            KitchenQueue.Add(newMessage);
            UpdateOrder();
            UpdateTableNumber();
            UpdateTableStatusMessage updateMessage = new UpdateTableStatusMessage(orderUpdatedMessage.FullOrder.TableNumber, TableStatus.ORDER_PLACED_KITCHEN);
            MessageManager.SendMessageToServer(updateMessage.BuildMessage());
            
        }
      
        private void ClearOrders()
        {
            Order1.DataSource = null;
            Order2.DataSource = null;
            Order3.DataSource = null;
            Order4.DataSource = null;
            Order5.DataSource = null;

            Order1.Items.Clear();
            Order2.Items.Clear();
            Order3.Items.Clear();
            Order4.Items.Clear();
            Order5.Items.Clear();

            label1.Text = "Text: XX";
            label8.Text = "Text: XX";
            label9.Text = "Text: XX";
            label10.Text = "Text: XX";
            label11.Text = "Text: XX";
        }
        private void UpdateTableNumber()
        {
            if (KitchenQueue.Count() >= 1)
                label1.Invoke(new MethodInvoker(delegate { label1.Text = "Table: " + KitchenQueue.ElementAt(0).FullOrder.TableNumber.ToString(); }));
            if (KitchenQueue.Count() >= 2)
                label8.Invoke(new MethodInvoker(delegate { label8.Text = "Table: " + KitchenQueue.ElementAt(1).FullOrder.TableNumber.ToString(); }));
            if (KitchenQueue.Count() >= 3)
                label9.Invoke(new MethodInvoker(delegate { label9.Text = "Table: " + KitchenQueue.ElementAt(2).FullOrder.TableNumber.ToString(); }));
            if (KitchenQueue.Count() >= 4)
                label10.Invoke(new MethodInvoker(delegate { label10.Text = "Table: " + KitchenQueue.ElementAt(3).FullOrder.TableNumber.ToString(); }));
            if (KitchenQueue.Count() >= 5)
                label11.Invoke(new MethodInvoker(delegate { label11.Text = "Table: " + KitchenQueue.ElementAt(4).FullOrder.TableNumber.ToString(); }));


        }
        private void UpdateOrder()
        {
            if (KitchenQueue.Count() >= 1)
                Order1.Invoke(new MethodInvoker(delegate { Order1.DataSource = KitchenQueue.ElementAt(0).FullOrder.Order; }));
            if (KitchenQueue.Count() >= 2)
                Order2.Invoke(new MethodInvoker(delegate { Order2.DataSource = KitchenQueue.ElementAt(1).FullOrder.Order; }));
            if (KitchenQueue.Count() >= 3)
                Order3.Invoke(new MethodInvoker(delegate { Order3.DataSource = KitchenQueue.ElementAt(2).FullOrder.Order; }));
            if (KitchenQueue.Count() >= 4)
                Order4.Invoke(new MethodInvoker(delegate { Order4.DataSource = KitchenQueue.ElementAt(3).FullOrder.Order; }));
            if (KitchenQueue.Count() >= 5)
                Order5.Invoke(new MethodInvoker(delegate { Order5.DataSource = KitchenQueue.ElementAt(4).FullOrder.Order; }));
        }

        private void OnServerStatusChanged(bool ServerStatus)
        {
            if (ServerStatusBtn.IsDisposed) return;
            if(ServerStatus)
            {
                ServerStatusBtn.Invoke(new MethodInvoker(delegate { ServerStatusBtn.Text = "Server: Connected"; }));
                ServerStatusBtn.Invoke(new MethodInvoker(delegate { ServerStatusBtn.BackColor = Color.Green; }));
            }
            else
            {
                //ServerStatusBtn.Invoke(new MethodInvoker(delegate { ServerStatusBtn.Text = "Server: Disconnected"; }));
                //ServerStatusBtn.Invoke(new MethodInvoker(delegate { ServerStatusBtn.BackColor = Color.Red; }));
            }
        }
        private void AcceptPaymentButton_Click(object sender, EventArgs e)
        {

        }
        private void ConnectToServerBtn_Click(object sender, EventArgs e)
        {
            ConnectToServer connectToServerForm = new ConnectToServer();
            connectToServerForm.ShowDialog();
        }


        private void DisplayOrders()
        {

        }
        private void SeatingChart_Load(object sender, EventArgs e)
        {

        }
        private void CompleteOrder(int num)
        {
            UpdateTableStatusMessage updateMessage = new UpdateTableStatusMessage(KitchenQueue.ElementAt(num - 1).FullOrder.TableNumber, TableStatus.READY);
            MessageManager.SendMessageToServer(updateMessage.BuildMessage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KitchenQueue.Count() != 0)
            {
                CompleteOrder(1);
                KitchenQueue.RemoveAt(0);
                ClearOrders();
                UpdateOrder();
                UpdateTableNumber();
                OrderComplete = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (KitchenQueue.Count() != 0)
            {
                CompleteOrder(2);
                KitchenQueue.RemoveAt(1);
                ClearOrders();
                UpdateOrder();
                UpdateTableNumber();
                OrderComplete = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KitchenQueue.Count() != 0)
            {
                CompleteOrder(3);
                KitchenQueue.RemoveAt(2);
                ClearOrders();
                UpdateOrder();
                UpdateTableNumber();
                OrderComplete = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (KitchenQueue.Count() != 0 && KitchenQueue.Count() >= 4)
            {
                CompleteOrder(4);
                KitchenQueue.RemoveAt(3);
                ClearOrders();
                UpdateOrder();
                UpdateTableNumber();
                OrderComplete = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (KitchenQueue.Count() != 0 && KitchenQueue.Count() >= 5)
            {
                CompleteOrder(5);
                KitchenQueue.RemoveAt(4);
                ClearOrders();
                UpdateOrder();
                UpdateTableNumber();
                OrderComplete = true;
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
