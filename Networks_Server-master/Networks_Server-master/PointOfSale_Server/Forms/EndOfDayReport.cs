using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale_Server.Classes.Managers;

namespace PointOfSale_Server.Forms
{
    public partial class EndOfDayReport : Form
    {
        public EndOfDayReport()
        {
            InitializeComponent();

            this.OrdersListBox.DataSource = SaleManager.GetAllOrders();
            this.TotalRevenueLabel.Text = "$" + String.Format("{0:0.00}", SaleManager.GetTotalRevenue());
            this.TotalTaxesLabel.Text = "$" + String.Format("{0:0.00}", SaleManager.GetTotalTaxes());
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
