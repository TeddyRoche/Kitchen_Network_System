using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PointOfSale_Client.Classes.Messages
{
    public class PaymentAcceptedMessage : OrderUpdateMessage
    {

        public PaymentAcceptedMessage(FoodOrder InOrderComplete) : base(InOrderComplete)
        {

        }

        public PaymentAcceptedMessage(XmlDocument Message) : base(Message)
        {

        }

        public PaymentAcceptedMessage() : base() { }

       
        public override string GetMessageType() { return "PAYMENTACCEPTED"; }

    }
}
