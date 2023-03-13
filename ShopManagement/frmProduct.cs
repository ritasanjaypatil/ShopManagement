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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
           int TypeId =  Convert.ToInt32(cmbPType.SelectedValue.ToString());
            ProductClass objShop = new ProductClass(TypeId, txtPProduct.Text);

            objShop.SaveProduct();
            MessageBox.Show("Save Product Successfully...!");
        }

        private void btnPClear_Click(object sender, EventArgs e)
        {
            cmbPType.Text = String.Empty;
            txtPProduct.Clear();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            ProductClass objPro = new ProductClass();
            DataTable dt = new DataTable();
            dt = objPro.GetType();
            cmbPType.DisplayMember = "TypeName";
            cmbPType.ValueMember = "TypeId";

            cmbPType.DataSource = dt;
        }

        private void cmbPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
