using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale_Server.Classes.Managers;
using PointOfSale_Server.Classes;
using PointOfSale_Server.Classes.Messages;
using PointOfSale_Server.Forms;
using System.Xml;
using System.Net.Sockets;
using System.Threading;

namespace PointOfSale_Server
{
    public partial class SeatingChart : Form
    {
        Dictionary<Button, TableBase> TableLookup = new Dictionary<Button, TableBase>();
        Dictionary<int, Button> TableLookupByNum = new Dictionary<int, Button>();

        public static Button CurrentTableSelected = null;

        public static bool OrderComplete = false;

        public SeatingChart()
        {
            InitializeComponent();

            SetupTables();

            UpdateCurrentActions(null);

            MessageManager.StartServerSocket();
            MessageManager.OnTableStatusMessageRecievedDelegate += OnTableStatusMessageReceive;
            MessageManager.OnNewClientConnected += OnNewClientConnected;
            MessageManager.OnOrderUpdateMessageRecieved += OnOrderUpdateMessageReceive;
            MessageManager.OnOrderPaymentCompleteMessageRecieved += OnPaymentMessageRecieved;
        }

        private void OnNewClientConnected(Socket ClientSocket)
        {
            foreach(KeyValuePair<Button, TableBase> Table in TableLookup)
            {
                Table.Value.SendStatusUpdateToClient(ClientSocket);
                Thread.Sleep(25);
            }
            foreach(FoodOrder CompletedOrder in SaleManager.GetAllOrders())
            {
                PaymentAcceptedMessage paymentAcceptedMessage = new PaymentAcceptedMessage(CompletedOrder);
                MessageManager.SendMessageToClient(paymentAcceptedMessage.BuildMessage(), ClientSocket);
                Thread.Sleep(20);
            }
        }

        private void OnPaymentMessageRecieved(MessageBase Message)
        {
            PaymentAcceptedMessage paymentAcceptedMessage = (PaymentAcceptedMessage)Message;
            SaleManager.AddOrder(paymentAcceptedMessage.FullOrder);
            MessageManager.SendMessageToAllClients(paymentAcceptedMessage.BuildMessage());
        }

        private void OnOrderUpdateMessageReceive(MessageBase Message)
        {
            OrderUpdateMessage UpdateOrderMessage = (OrderUpdateMessage)Message;
            TableLookup[TableLookupByNum[UpdateOrderMessage.FullOrder.TableNumber]].PlaceOrder(UpdateOrderMessage.FullOrder);
        }

        private void OnTableStatusMessageReceive(MessageBase Message)
        {
            UpdateTableStatusMessage updateTableStatus = (UpdateTableStatusMessage)Message;
            TableLookup[TableLookupByNum[updateTableStatus.TableNum]].ForceSetTableStatus(updateTableStatus.UpdatedTableStatus);
        }

        private void BtnSeatCustomer_Click(object sender, EventArgs e)
        {
            if(CurrentTableSelected == null)
            {
                Console.WriteLine("No Table Selected.");
            }
            TableLookup[CurrentTableSelected].SeatCustomer();
            CurrentTableSelected = null;
            UpdateCurrentActions((Button)sender);
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            if (CurrentTableSelected != null)
            {
                TableLookup[CurrentTableSelected].UnselectTable();
            }
            TableLookup[(Button)sender].SelectTable();
            CurrentTableSelected = (Button)sender;
            UpdateCurrentActions((Button)sender);
            UpdateCurrentOrder((Button)sender);
        }

        private void DeselectTable_Click(object sender, EventArgs e)
        {
            if (CurrentTableSelected != null)
            {
                TableLookup[CurrentTableSelected].UnselectTable();
            }
            CurrentTableSelected = null;
            UpdateCurrentActions((Button)sender);
        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            CreateOrder OrderForm = new CreateOrder(TableLookup[CurrentTableSelected].TableNumber);
            if(OrderForm.ShowDialog() == DialogResult.OK)
            {
                TableLookup[CurrentTableSelected].PlaceOrder(OrderForm.TotalOrder);
                CurrentTableSelected = null;
                UpdateCurrentActions((Button)sender);
            }
        }

        private void UpdateCurrentActions(Button TableClicked)
        {
            this.BtnSeatCustomer.Enabled = false;
            this.PlaceOrderButton.Enabled = false;
            this.FoodDeliveredButton.Enabled = false;
            this.AcceptPaymentButton.Enabled = false;
            if (CurrentTableSelected == null) return;
            switch(TableLookup[CurrentTableSelected].CurrentStatus)
            {
                case TableStatus.TABLE_OPEN:
                    this.BtnSeatCustomer.Enabled = true;
                    break;
                case TableStatus.TABLE_OCCUPIED:
                    this.PlaceOrderButton.Enabled = true;
                    break;
                case TableStatus.ORDER_PLACED:
                    this.FoodDeliveredButton.Enabled = true;
                    break;
                case TableStatus.ORDER_PLACED_KITCHEN:
                    this.FoodDeliveredButton.Enabled = false;
                    break;
                case TableStatus.READY:
                    this.FoodDeliveredButton.Enabled = true;
                    break;
                case TableStatus.READY_FOR_PAYMENT:
                    this.AcceptPaymentButton.Enabled = true;
                    break;
            }
        }

        private void UpdateCurrentOrder(Button TableClicked)
        {
            this.TableOrderListBox.DataSource = null;
            if(TableLookup[CurrentTableSelected].Order != null)
            {
                this.TableOrderListBox.DataSource = TableLookup[CurrentTableSelected].Order.Order;
            }
        }

        private void FoodDeliveredButton_Click(object sender, EventArgs e)
        {
            if (CurrentTableSelected != null)
            {
                
                TableLookup[CurrentTableSelected].DeliverFood();
            }
            UpdateCurrentActions((Button)sender);
        }

        private void AcceptPaymentButton_Click(object sender, EventArgs e)
        {
            if (CurrentTableSelected != null)
            {
                AcceptPayment PaymentForm = new AcceptPayment(TableLookup[CurrentTableSelected].Order);
                if(PaymentForm.ShowDialog() == DialogResult.OK)
                {
                    TableLookup[CurrentTableSelected].PaymentAccepted();
                    CurrentTableSelected = null;
                }
            }
            UpdateCurrentActions((Button)sender);
        }

        private void SetupTables()
        {
            TableLookup.Add(Table1, new HorizontalTable(1, Table1));
            TableLookup.Add(Table2, new HorizontalTable(2, Table2));
            TableLookup.Add(Table3, new HorizontalTable(3, Table3));
            TableLookup.Add(Table4, new HorizontalTable(4, Table4));
            TableLookup.Add(Table5, new HorizontalTable(5, Table5));
            TableLookup.Add(Table6, new HorizontalTable(6, Table6));
            TableLookup.Add(Table7, new HorizontalTable(7, Table7));
            TableLookup.Add(Table8, new HorizontalTable(8, Table8));
            TableLookup.Add(Table9, new HorizontalTable(9, Table9));
            TableLookup.Add(Table10, new HorizontalTable(10, Table10));
            TableLookup.Add(Table11, new HorizontalTable(11, Table11));
            TableLookup.Add(Table12, new HorizontalTable(12, Table12));
            TableLookup.Add(Table14, new HorizontalTable(14, Table14));
            TableLookup.Add(Table15, new HorizontalTable(15, Table15));
            TableLookup.Add(Table16, new HorizontalTable(16, Table16));
            TableLookup.Add(Table17, new HorizontalTable(17, Table17));
            TableLookup.Add(Table18, new HorizontalTable(18, Table18));
            TableLookup.Add(Table19, new HorizontalTable(19, Table19));
            TableLookup.Add(Table20, new HorizontalTable(20, Table20));
            TableLookup.Add(Table21, new HorizontalTable(21, Table21));
            TableLookup.Add(Table22, new HorizontalTable(22, Table22));
            TableLookup.Add(Table23, new RoundTable(23, Table23));
            TableLookup.Add(Table24, new RoundTable(24, Table24));
            TableLookup.Add(Table25, new RoundTable(25, Table25));
            TableLookup.Add(Table26, new RoundTable(26, Table26));
            TableLookup.Add(Table27, new RoundTable(27, Table27));
            TableLookup.Add(Table28, new RoundTable(28, Table28));
            TableLookup.Add(Table29, new RoundTable(29, Table29));
            TableLookup.Add(Table30, new RoundTable(30, Table30));
            TableLookup.Add(Table31, new VerticalTable(31, Table31));
            TableLookup.Add(Table32, new VerticalTable(32, Table32));
            TableLookup.Add(Table33, new VerticalTable(33, Table33));
            TableLookup.Add(Table34, new VerticalTable(34, Table34));
            TableLookup.Add(Table35, new VerticalTable(35, Table35));
            TableLookup.Add(Table36, new VerticalTable(36, Table36));
            TableLookup.Add(Table37, new VerticalTable(37, Table37));
            TableLookup.Add(Table38, new VerticalTable(38, Table38));
            TableLookup.Add(Table39, new VerticalTable(39, Table39));
            TableLookup.Add(Table40, new RoundTable(40, Table40));
            TableLookup.Add(Table41, new RoundTable(41, Table41));
            TableLookup.Add(Table42, new RoundTable(42, Table42));
            TableLookup.Add(Table43, new RoundTable(43, Table43));
            TableLookup.Add(Table44, new RoundTable(44, Table44));
            TableLookup.Add(Table45, new RoundTable(45, Table45));
            TableLookup.Add(Table46, new RoundTable(46, Table46));
            TableLookup.Add(Table47, new RoundTable(47, Table47));
            TableLookup.Add(Table48, new RoundTable(48, Table48));
            TableLookup.Add(Table49, new RoundTable(49, Table49));
            TableLookup.Add(Table50, new RoundTable(50, Table50));
            TableLookup.Add(Table51, new RoundTable(51, Table51));
            TableLookup.Add(Table52, new RoundTable(52, Table52));
            TableLookup.Add(Table53, new RoundTable(53, Table53));
            TableLookup.Add(Table54, new RoundTable(54, Table54));
            TableLookup.Add(Table55, new RoundTable(55, Table55));

            foreach(KeyValuePair<Button, TableBase> tuple in TableLookup)
            {
                TableLookupByNum.Add(tuple.Value.TableNumber, tuple.Key);
            }
        }

        private void EndOfDayReportButton_Click(object sender, EventArgs e)
        {
            EndOfDayReport endOfDayReportForm = new EndOfDayReport();
            endOfDayReportForm.ShowDialog();
        }

        private void SeatingChart_Load(object sender, EventArgs e)
        {

        }
    }
}
