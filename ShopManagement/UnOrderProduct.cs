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
    public partial class UnOrderProduct : Form
    {
        public UnOrderProduct()
        {
            InitializeComponent();
        }

        private void UnOrderProduct_Load(object sender, EventArgs e)
        {
            ProductClass objP = new ProductClass();
            DataTable dt = new DataTable();
            dt = objP.UnorderProduct();
            dtgUnOrderProduct.DataSource = dt;
            dtgUnOrderProduct.Show();
        }
    }
}
