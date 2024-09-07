using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale_Client.Classes.Managers;

namespace PointOfSale_Client.Forms
{
    public partial class ConnectToServer : Form
    {
        public ConnectToServer()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if(!MessageManager.ConnectToServer(this.IpAddressTextBox.Text))
            {
                MessageBox.Show("Unable to establish connection to server.");
                this.DialogResult = DialogResult.None;
                return;
            }
            SaleManager.ClearAllOrders();
            this.DialogResult = DialogResult.OK;
        }
    }
}
