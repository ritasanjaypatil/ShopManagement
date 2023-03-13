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
    public partial class FrmDiscount : Form
    {
        string Id;
        string Id2;
        string P3;
        string P4;
        string DiscountPrice;
        public FrmDiscount()
        {
            InitializeComponent();
        }
        public FrmDiscount(string SizeId1, string UserId1,  string PName1, string PPrice1)
        {
            InitializeComponent();
            Id = SizeId1;
            Id2 = UserId1;
             lblOName.Text  = PName1;
            lblDOSPrice.Text= PPrice1;
           // DiscountPrice = DiscountP;


        }


        private void FrmDiscount_Load(object sender, EventArgs e)
        {

        }

        private void btnCAlNP_Click(object sender, EventArgs e)
        {
           
            int Discount = ((Convert.ToInt32(lblDOSPrice.Text) * Convert.ToInt32(txtDPercent.Text) / 100));

            txtNprice.Text = (Convert.ToInt32(lblDOSPrice.Text) - Discount).ToString();
            //txtNprice.Text = DiscountPrice.ToString();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatedP_Click(object sender, EventArgs e)
        {
            
            ProductClass objp = new ProductClass(Convert.ToInt32(Id), Convert.ToInt32(Id2), txtDPercent.Text);
            objp.UpdateDiscount();
            MessageBox.Show("Updated..");
        }
    }
}
