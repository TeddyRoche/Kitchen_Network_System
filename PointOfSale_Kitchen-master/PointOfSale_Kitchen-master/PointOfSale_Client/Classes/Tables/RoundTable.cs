using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_Client.Classes
{
    public class RoundTable : TableBase
    {
        public RoundTable(int TableNum, Button InTableButton) : base(TableNum, InTableButton)
        {

        }

        protected override void SetupImages()
        {
            TableOpen = Properties.Resources.RoundTable_White;
            TableOrdered = Properties.Resources.RoundTable_Orange;
            TableFoodDelivered = Properties.Resources.RoundTable_Yellow;
            TableOccupied = Properties.Resources.RoundTable_Blue;
            Ready = Properties.Resources.RoundTable_Red;
            TablePaymentReady = Properties.Resources.RoundTable_Purple;
            TableSelected = Properties.Resources.RoundTable_Green;
        }
    }
}
