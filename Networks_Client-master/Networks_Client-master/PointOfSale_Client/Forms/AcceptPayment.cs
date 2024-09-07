using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale_Client.Classes;

namespace PointOfSale_Client.Forms
{
    public partial class AcceptPayment : Form
    {
        public AcceptPayment(FoodOrder InOrder)
        {
            InitializeComponent();

            this.OrderListBox.DataSource = InOrder.Order;
            this.OrderListBox.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PayByCardButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PayByCashButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
