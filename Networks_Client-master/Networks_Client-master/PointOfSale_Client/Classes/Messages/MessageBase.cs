using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PointOfSale_Client.Classes.Messages
{
    public class MessageBase
    {

        public MessageBase()
        {

        }

        public MessageBase(XmlDocument Message)
        {
            PopulateMessage(Message);
        }

        public virtual void PopulateMessage(XmlDocument Message)
        {

        }

        public virtual string GetMessageType() { return "UNDEFINED"; }

        protected virtual string BuildBody() { return ""; }

        protected virtual XmlElement GetMessageBody(XmlDocument Message)
        {
            XmlElement TableElement = Message.CreateElement(string.Empty, "UNDEFINED", string.Empty);
            return TableElement;
        }

        public virtual string BuildMessage()
        {
            XmlDocument Message = new XmlDocument();
            XmlElement MessageType = Message.CreateElement(string.Empty, GetMessageType(), string.Empty);
            Message.AppendChild(MessageType);
            MessageType.AppendChild(GetMessageBody(Message));
            return Message.OuterXml + "<EOF>";
        }

    }
}
