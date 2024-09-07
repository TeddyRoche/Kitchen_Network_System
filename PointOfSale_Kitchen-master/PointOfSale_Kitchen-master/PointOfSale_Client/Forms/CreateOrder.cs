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

namespace PointOfSale_Client.Forms
{
    public partial class CreateOrder : Form
    {
        protected List<OrderItem> Order = new List<OrderItem>();
        protected Dictionary<Button, OrderItem> ItemsAvailableToOrder = new Dictionary<Button, OrderItem>();

        protected const double TAX_RATE = 6.25;
        protected int TableNumber;

        public FoodOrder TotalOrder { get; private set; }

        public CreateOrder(int TableNum)
        {
            InitializeComponent();
            SetupItems();
            this.OrderListBox.DataSource = Order;
            TableNumber = TableNum;
        }

        private void SetupItems()
        {
            ItemsAvailableToOrder.Add(FountainDrinkBtn, new OrderItem("Fountain Drink", 1.85));
            ItemsAvailableToOrder.Add(IcedTeaButton, new OrderItem("Iced Tea", 2.95));
            ItemsAvailableToOrder.Add(LemonadeButton, new OrderItem("Lemonade", 3.50));
            ItemsAvailableToOrder.Add(BottledWaterButton, new OrderItem("Bottled Water", 3.00));
            ItemsAvailableToOrder.Add(RootBeerButton, new OrderItem("Root Beer", 4.25));

            ItemsAvailableToOrder.Add(FriedPicklesButton, new OrderItem("Chips & Salsa", 4.75));
            ItemsAvailableToOrder.Add(ChipsSalsaButton, new OrderItem("Fried Pickles", 6.25));
            ItemsAvailableToOrder.Add(HotWingsButton, new OrderItem("Hot Wings", 9.95));

            ItemsAvailableToOrder.Add(BurgerButton, new OrderItem("Burger", 8.75));
            ItemsAvailableToOrder.Add(PizzaButton, new OrderItem("Pizza", 10.25));
            ItemsAvailableToOrder.Add(ClubButton, new OrderItem("Club Sandwich", 8.25));

            ItemsAvailableToOrder.Add(StrawberrySaladButton, new OrderItem("Strawberry Chicken Salad", 12.25));
            ItemsAvailableToOrder.Add(CobSaladButton, new OrderItem("Cob Salad", 11.95));
            ItemsAvailableToOrder.Add(SteakTipSaladButton, new OrderItem("Steak Tip Salad", 15.95));

            ItemsAvailableToOrder.Add(IceCreamButton, new OrderItem("Ice Cream", 6.75));
            ItemsAvailableToOrder.Add(CakeButton, new OrderItem("Cake", 4.75));

            ItemsAvailableToOrder.Add(GiftCard5Button, new OrderItem("Gift Card ($5)", 5.00, false));
            ItemsAvailableToOrder.Add(GiftCard10Button, new OrderItem("Gift Card ($10)", 10, false));
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            Order.Add(ItemsAvailableToOrder[(Button)sender]);
            RefreshOrder();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(this.OrderListBox.SelectedIndex != -1)
            {
                this.Order.Remove((OrderItem)this.OrderListBox.SelectedItem);
            }
            RefreshOrder();
        }

        private void RefreshOrder()
        {
            this.OrderListBox.DataSource = null;
            this.OrderListBox.DataSource = Order;

            double SubTotal = 0;
            double Tax = 0;
            foreach(OrderItem Item in Order)
            {
                SubTotal += Item.Price;
                if(Item.IsTaxable)
                {
                    Tax += Item.Price * (TAX_RATE / 100);
                }
            }

            double Total = SubTotal + Tax;

            this.SubTotalAmount.Text = "$" + String.Format("{0:0.00}", SubTotal);
            this.TaxAmount.Text = "$" + String.Format("{0:0.00}", Tax);
            this.TotalAmount.Text = "$" + String.Format("{0:0.00}", Total);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            TotalOrder = new FoodOrder(Order, TableNumber);
            this.DialogResult = DialogResult.OK;
        }
    }
}
