using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_Client.Classes.Managers
{
    public sealed class SaleManager
    {
        SaleManager() { }
        private static readonly object lockobject = new object ();  
        private static SaleManager instance = null;

        public static List<FoodOrder> AllOrders = new List<FoodOrder>();
        public static SaleManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockobject)
                        {
                            if (instance == null)
                            {
                                instance = new SaleManager();
                            }
                        }
                }
                return instance;
            }
        }

        public static void AddOrder(FoodOrder NewOrder)
        {
            AllOrders.Add(NewOrder);
        }

       

        public static double GetTotalRevenue()
        {
            double TotalRevenue = 0;
            foreach(FoodOrder order in AllOrders)
            {
                TotalRevenue += order.Total;
            }
            return TotalRevenue;
        }

        public static double GetTotalTaxes()
        {
            double TotalTax = 0;
            foreach (FoodOrder order in AllOrders)
            {
                TotalTax += order.Tax;
            }
            return TotalTax;
        }
        public static void ClearAllOrders()
        {
            AllOrders.Clear();
        }
    }
}
