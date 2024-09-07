using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PointOfSale_Client.Classes.Messages
{
    public class OrderUpdateMessage : MessageBase
    {
        public FoodOrder FullOrder { get; private set; }

        public OrderUpdateMessage(FoodOrder InFoodOrder) : base()
        {
            FullOrder = InFoodOrder;
        }

        public OrderUpdateMessage(XmlDocument Message) : base(Message)
        {
            
        }

        public OrderUpdateMessage() : base() { }

        public override void PopulateMessage(XmlDocument Message)
        {
            base.PopulateMessage(Message);

            int TableNumber = 0;
            XmlNodeList NodeList = Message.GetElementsByTagName(GetMessageType());

            foreach (XmlNode Node in NodeList)
            {
                foreach (XmlNode ChildNode in Node.ChildNodes)
                {
                    if (ChildNode.Name == "ORDER_INFO")
                    {
                        foreach (XmlAttribute Attribute in ChildNode.Attributes)
                        {
                            if (Attribute.Name == "TableNumber")
                            {
                                TableNumber = Int32.Parse(Attribute.Value);
                            }
                        }
                        List<OrderItem> AllItemsOrdered = new List<OrderItem>();
                        foreach (XmlNode OrderItems in ChildNode.ChildNodes)
                        {
                            if (OrderItems.Name == "ITEM_ORDERED")
                            {
                                string ItemName = "";
                                double ItemPrice = 0.0;
                                bool IsItemTaxable = true;
                                //OrderItem item = new OrderItem()
                                foreach (XmlAttribute ItemAttributes in OrderItems.Attributes)
                                {
                                    if (ItemAttributes.Name == "ItemName")
                                    {
                                        ItemName = ItemAttributes.Value;
                                    }
                                    else if (ItemAttributes.Name == "ItemPrice")
                                    {
                                        ItemPrice = double.Parse(ItemAttributes.Value);
                                    }
                                    else if (ItemAttributes.Name == "IsTaxable")
                                    {
                                        IsItemTaxable = bool.Parse(ItemAttributes.Value);
                                    }
                                }
                                OrderItem item = new OrderItem(ItemName, ItemPrice, IsItemTaxable);
                                AllItemsOrdered.Add(item);
                            }
                        }
                        FullOrder = new FoodOrder(AllItemsOrdered, TableNumber);
                    }
                }
            }
        }

        public override string GetMessageType() { return "UPDATEFOODORDER"; }

        protected override XmlElement GetMessageBody(XmlDocument Message)
        {
            XmlElement OrderInfoNode = Message.CreateElement(string.Empty, "ORDER_INFO", string.Empty);
            OrderInfoNode.SetAttribute("TableNumber", FullOrder.TableNumber.ToString());
            OrderInfoNode.SetAttribute("SubTotal", FullOrder.Subtotal.ToString());
            OrderInfoNode.SetAttribute("Total", FullOrder.Total.ToString());
            foreach (OrderItem Item in FullOrder.Order)
            {
                XmlElement FoodItemNode = Message.CreateElement("ITEM_ORDERED");
                FoodItemNode.SetAttribute("ItemName", Item.ItemName);
                FoodItemNode.SetAttribute("IsTaxable", Item.IsTaxable.ToString());
                FoodItemNode.SetAttribute("ItemPrice", Item.Price.ToString());
                OrderInfoNode.AppendChild(FoodItemNode);
            }
            return OrderInfoNode;
        }
    }
}
