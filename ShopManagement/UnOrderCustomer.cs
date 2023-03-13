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
    public partial class UnOrderCustomer : Form
    {
        public UnOrderCustomer()
        {
            InitializeComponent();
        }

        private void UnOrderCustomer_Load(object sender, EventArgs e)
        {
            ProductClass objP = new ProductClass();
            DataTable dt = new DataTable();
            dt = objP.UnorderCustomer();
            dtgUnorderCustomer.DataSource = dt;
            dtgUnorderCustomer.Show();
        }

        private void dtgUnorderCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
