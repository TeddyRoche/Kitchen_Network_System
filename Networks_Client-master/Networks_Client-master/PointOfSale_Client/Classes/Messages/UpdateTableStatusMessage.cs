using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PointOfSale_Client.Classes.Messages
{
    public class UpdateTableStatusMessage : MessageBase
    {
        public int TableNum { get; private set; }
        public TableStatus UpdatedTableStatus { get; private set; }

        public UpdateTableStatusMessage (int TableNumber, TableStatus NewStatus) : base()
        {
            TableNum = TableNumber;
            UpdatedTableStatus = NewStatus;
        }

        public UpdateTableStatusMessage(XmlDocument Message) : base(Message)
        {
           
        }

        public UpdateTableStatusMessage() : base() { }

        public override void PopulateMessage(XmlDocument Message)
        {
            base.PopulateMessage(Message);

            XmlNodeList NodeList = Message.GetElementsByTagName(GetMessageType());
            foreach (XmlNode Node in NodeList)
            {
                foreach (XmlNode ChildNode in Node.ChildNodes)
                {
                    if (ChildNode.Name == "TABLE_STATUS")
                    {
                        foreach (XmlAttribute Attribute in ChildNode.Attributes)
                        {
                            if (Attribute.Name == "TableNumber")
                            {
                                TableNum = Int32.Parse(Attribute.Value);
                            }
                            else if (Attribute.Name == "Status")
                            {
                                TableStatus NewStatus;
                                Enum.TryParse(Attribute.Value, out NewStatus);
                                UpdatedTableStatus = NewStatus;
                            }
                        }
                    }
                }
            }
        }

        public override string GetMessageType() { return "UPDATETABLESTATUS"; }

        protected override XmlElement GetMessageBody(XmlDocument Message)
        {
            XmlElement TableElement = Message.CreateElement(string.Empty, "TABLE_STATUS", string.Empty);
            TableElement.SetAttribute("TableNumber", TableNum.ToString());
            TableElement.SetAttribute("Status", UpdatedTableStatus.ToString());

            return TableElement;
        }
    }
}
