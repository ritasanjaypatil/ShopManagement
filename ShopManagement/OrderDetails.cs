using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderProducts1 objp = new OrderProducts1();
            objp.Show();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllData objD = new AllData();
            objD.Show();
        }

        private void unorderProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnOrderProduct objP = new UnOrderProduct();
            objP.Show();
        }

        private void unorderCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnOrderCustomer objc = new UnOrderCustomer();
            objc.Show();
        }
    }
}
