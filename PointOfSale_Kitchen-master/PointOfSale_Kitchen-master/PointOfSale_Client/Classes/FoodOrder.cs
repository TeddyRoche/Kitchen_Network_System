using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_Client.Classes
{
    public class FoodOrder
    {
        public List<OrderItem> Order = new List<OrderItem>();


        protected const double TAX_RATE = 6.25;

        public double Subtotal { get; private set; }
        public double Tax { get; private set; }
        public double Total { get; private set; }

        public int TableNumber = -1;

        public DateTime OrderDate;

        public FoodOrder(List<OrderItem> InOrder, int TableNum)
        {
            TableNumber = TableNum;
            Order = InOrder;
            CalculateCosts();
            OrderDate = DateTime.Now;
        }

        protected void CalculateCosts()
        {
            Subtotal = 0;
            Tax = 0;
            foreach (OrderItem Item in Order)
            {
                if (!Item.IsItemVoid())
                {
                    Subtotal += Item.Price;
                    if (Item.IsTaxable)
                    {
                        Tax += Item.Price * (TAX_RATE / 100);
                    }
                }
            }

            Total = Subtotal;
        }

        public override string ToString()
        {
            return $"Table: {TableNumber}; Time: {OrderDate}; Total: {Total}";
        }

    }
}
