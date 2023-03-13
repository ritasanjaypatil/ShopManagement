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
    public partial class OrderProducts1 : Form
    {
        public string SizeId;
        public string UserId;
        public string PName;
        public string PPrice;
       // public string DiscountPrice;
        public OrderProducts1()
        {
            InitializeComponent();
        }

        private void OrderProducts1_Load(object sender, EventArgs e)
        {
            ProductClass objP = new ProductClass();
            DataTable dt = new DataTable();
            dt = objP.OrderProduct();
            DTGOrderDetails.DataSource = dt;
            DTGOrderDetails.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSBName.Text !="")
            {
                ProductClass objP = new ProductClass(txtSBName.Text);
                DataTable dt = new DataTable();
                dt = objP.SearchName();
                DTGOrderDetails.DataSource = dt;
                DTGOrderDetails.Show();
            }
            
        }

        private void txtSBName_TextChanged(object sender, EventArgs e)
        {
            if (txtSBName.Text != "")
            {
                ProductClass objP = new ProductClass();
                DataTable dt = new DataTable();
                dt = objP.OrderProduct();
                DTGOrderDetails.DataSource = dt;
                DTGOrderDetails.Show();
            }
               
        }

        private void txtSBProduct_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void DTGOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        //    DiscountPrice=DTGOrderDetails.CurrentRow.Cells[1].Value.ToString();
            if(DTGOrderDetails.Columns[e.ColumnIndex].HeaderText == "Offer")
            {
                SizeId = DTGOrderDetails.CurrentRow.Cells[2].Value.ToString();
                UserId = DTGOrderDetails.CurrentRow.Cells[12].Value.ToString();
                PName = DTGOrderDetails.CurrentRow.Cells[8].Value.ToString();
                PPrice = DTGOrderDetails.CurrentRow.Cells[11].Value.ToString();
                FrmDiscount objdis = new FrmDiscount(SizeId,UserId,PName,PPrice);
                

                
                objdis.Show();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ProductClass objP = new ProductClass();
            DataTable dt = new DataTable();
            dt = objP.OrderProduct();
            DTGOrderDetails.DataSource = dt;
            DTGOrderDetails.Show();
        }

        private void DTGOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteD_Click(object sender, EventArgs e)
        {
            //string Pr = DTGOrderDetails.CurrentRow.Cells[0].Value.ToString();
            //string A = DTGOrderDetails.CurrentRow.Cells [1].Value.ToString();
            //string B = DTGOrderDetails.CurrentRow.Cells[2].Value.ToString();
            //string C = DTGOrderDetails.CurrentRow.Cells[3].Value.ToString();
            //string D = DTGOrderDetails.CurrentRow.Cells[4].Value.ToString();
            //string E = DTGOrderDetails.CurrentRow.Cells[5].Value.ToString();
            //string F = DTGOrderDetails.CurrentRow.Cells[6].Value.ToString();
            //string G = DTGOrderDetails.CurrentRow.Cells[7].Value.ToString();
            //string H = DTGOrderDetails.CurrentRow.Cells[8].Value.ToString();
            //string I = DTGOrderDetails.CurrentRow.Cells[9].Value.ToString();
            //string J = DTGOrderDetails.CurrentRow.Cells[10].Value.ToString();
            //string K = DTGOrderDetails.CurrentRow.Cells[11].Value.ToString();
            //string L = DTGOrderDetails.CurrentRow.Cells[12].Value.ToString();
            //string M = DTGOrderDetails.CurrentRow.Cells[13].Value.ToString();

            for ( int i = 0; i< DTGOrderDetails.Rows.Count; i++ )
            {
                
                if (DTGOrderDetails.Rows[i].Cells[0].Value != null) 
                {
                    bool a = (bool)DTGOrderDetails.Rows[i].Cells[0].Value;
                    if (a==true)
                    {
                        int b =Convert.ToInt32(DTGOrderDetails.Rows[i].Cells[3].Value.ToString());
                        ProductClass objP = new ProductClass(b);
                        objP.DeleteData();
                        MessageBox.Show("Deleted..");


                    }
                }
                //CheckBox chk = (CheckBox)DTGOrderDetails.Rows[i].Cells[1].Value;
            }
        }
    }
}
