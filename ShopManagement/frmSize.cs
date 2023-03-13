using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace ShopManagement
{
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void btnSSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbSType.SelectedValue.ToString());
            int ProductId = Convert.ToInt32(cmbSProduct.SelectedValue.ToString());
            ProductClass objSize = new ProductClass(TypeId, ProductId, txtSSize.Text,(Convert.ToInt32(txtSMRP.Text)),(Convert.ToInt32(txtSRprice.Text)));
            objSize.SaveSize();
            MessageBox.Show("Save Size Suceessfully...");
        }

        private void btnSCLear_Click(object sender, EventArgs e)
        {
            cmbSType.Text = String.Empty; 
            cmbSProduct.Text=String.Empty;
            txtSSize.Clear();
            txtSMRP.Clear();
            txtSRprice.Clear(); 
        }

        private void cmbSType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbSType.SelectedValue.ToString());
            ProductClass objSize = new ProductClass(TypeId);
            DataTable dt = new DataTable();
            dt = objSize.GetProduct();
            cmbSProduct.DisplayMember = "ProductName";
            cmbSProduct.ValueMember = "ProductId";

            cmbSProduct.DataSource = dt;
        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            ProductClass objS = new ProductClass();
             DataTable dt = new DataTable();
            dt = objS.GetType();
            cmbSType.DisplayMember = "TypeName";
            cmbSType.ValueMember = "TypeId";

            cmbSType.DataSource = dt;
        }

        private void cmbSProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
