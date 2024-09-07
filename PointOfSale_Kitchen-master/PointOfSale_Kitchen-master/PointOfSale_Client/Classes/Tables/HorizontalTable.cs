﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale_Client.Classes
{
    public class HorizontalTable : TableBase
    {
        public HorizontalTable(int TableNum, Button InTableButton) : base(TableNum, InTableButton)
        {

        }

        protected override void SetupImages()
        {
            TableOpen = Properties.Resources.LongTable2_White;
            TableOrdered = Properties.Resources.LongTable2_Orange;
            TableFoodDelivered = Properties.Resources.LongTable2_Yellow;
            TableOccupied = Properties.Resources.LongTable2_Blue;
            Ready = Properties.Resources.LongTable2_Red;
            TablePaymentReady = Properties.Resources.LongTable2_Purple;
            TableSelected = Properties.Resources.LongTable2_Green;
        }
    }
}
