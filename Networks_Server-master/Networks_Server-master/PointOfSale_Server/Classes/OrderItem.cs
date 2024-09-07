using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_Server.Classes
{
    public class OrderItem
    {
        public string ItemName { get; private set; }

        public double Price { get; private set; }

        public bool IsTaxable { get; private set; }

        protected bool IsVoid = false;


        public OrderItem(string Name, double Cost, bool Taxable = true)
        {
            ItemName = Name;
            Price = Cost;
            IsTaxable = Taxable;
        }


        public void VoidItem()
        {
            IsVoid = true;
        }

        public bool IsItemVoid()
        {
            return IsVoid;
        }

        public override string ToString()
        {
            return ItemName + "\t\t($" + String.Format("{0:0.00}", Price) + ")";
        }
    }
}
