using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_Server.Classes
{
    public class VerticalTable : TableBase
    {

        public VerticalTable(int TableNum, Button InTableButton) : base(TableNum, InTableButton)
        {

        }

        protected override void SetupImages()
        {
            TableOpen = Properties.Resources.LongTable_White;
            TableOrdered = Properties.Resources.LongTable_Orange;
            TableFoodDelivered = Properties.Resources.LongTable_Yellow;
            TableOccupied = Properties.Resources.LongTable_Blue;
            Ready = Properties.Resources.LongTable_Red;
            TablePaymentReady = Properties.Resources.LongTable_Purple;
            TableSelected = Properties.Resources.LongTable_Green;
        }
    }
}
