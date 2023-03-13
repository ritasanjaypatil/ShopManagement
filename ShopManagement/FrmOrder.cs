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
using System.Data.SqlClient;

namespace ShopManagement
{
    public partial class FrmOrder : Form
    {
       public int UId = 0;
        public FrmOrder()
        {
            InitializeComponent();
        }
        public FrmOrder(string Name,string Email,string PhoneNo,int UserId)
        {
            InitializeComponent();
            txtOName.Text = Name;   
            txtOEmail.Text = Email;
            txtOPhone.Text = PhoneNo;
            UId = UserId;
        }

        private void lblOrderProduct_Click(object sender, EventArgs e)
        {

        }

        private void cmbOProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbOProduct.SelectedValue.ToString());
            ProductClass objP = new ProductClass(TypeId);
            DataTable dt = new DataTable();
            dt = objP.GetSize();
            dtgVOrder.DataSource = dt;
            dtgVOrder.Show();
        }

        private void lblOrderType_Click(object sender, EventArgs e)
        {

        }

        private void cmbOType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbOType.SelectedValue.ToString());
            ProductClass objP = new ProductClass(TypeId);
            DataTable dt = new DataTable();
            dt = objP.GetProduct();
            cmbOProduct.ValueMember = "ProductId";
            cmbOProduct.DisplayMember = "ProductName";
            cmbOProduct.DataSource = dt;
        }

        private void dtgVOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgVOrder_MouseClick(object sender, MouseEventArgs e)
        {
            int SizeId = Convert.ToInt32 ( dtgVOrder.SelectedRows[0].Cells[0].Value.ToString());
            ProductClass objp = new ProductClass(SizeId);
            SqlDataReader dr;

            dr = objp.GetPrice();
            while (dr.Read())
            {
                txtOPrice.Text = dr["MRP"].ToString();

            }
            dr.Close();
        }
        private void Add(string Type1, string Product1, string SizeId2, string Size1, string Price1)
        {if(Price1 != null)
            {
                ListViewItem lst = new ListViewItem(Type1);
                lst.SubItems.Add(Product1);
                lst.SubItems.Add(SizeId2);
                lst.SubItems.Add(Size1);
                lst.SubItems.Add(Price1);
                lvOrder.Items.Add(lst);
                //lvOrder.Columns[4].Width = 0;
            }

        }

        private void btnOAddToC_Click(object sender, EventArgs e)
        {if(dtgVOrder.SelectedRows.Count > 0)
            {
                string SizeId1 = dtgVOrder.SelectedRows[0].Cells[0].Value.ToString();
                string Size2 = dtgVOrder.SelectedRows[0].Cells[1].Value.ToString();
                string Type = cmbOType.Text;
                string Product = cmbOProduct.Text;
                string Price = txtOPrice.Text;

                Add(Type, Product, SizeId1, Size2, Price);
             }
        else
            {
                MessageBox.Show("Please select all fields");

            }

        }

        private void btnORFrC_Click(object sender, EventArgs e)
        {
            // cmbOType.SelectedItem = null;
            //cmbOProduct.SelectedItem = null;
            // dtgVOrder.Rows.Clear();
            // txtOPrice.Clear();
            lvOrder.Items.Remove(lvOrder.SelectedItems[0]);
        }

        private void btnOTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lvOrder.Items.Count;i++)
            {
                if (lvOrder.Items[i].SubItems[3].Text != null)
                {
                    sum += int.Parse(lvOrder.Items[i].SubItems[4].Text); 
                }
            }
            txtOTotal.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string status = "confirmed";
            string Discount2  = "";
            for (int i = 0; i < lvOrder.Items.Count; i++)
            {
                int SizeId1 = Convert.ToInt32(lvOrder.Items[i].SubItems[2].Text);
                ProductClass objP = new ProductClass(UId, SizeId1, status, Discount2);
                objP.OrderConfirmed();



            }
            MessageBox.Show("confirmed..");

        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
           //int TypeId = Convert.ToInt32(cmbOType.SelectedValue.ToString());
            ProductClass objPro = new ProductClass();
            DataTable dt = new DataTable();
            dt = objPro.GetType();
            cmbOType.DisplayMember = "TypeName";
            cmbOType.ValueMember = "TypeId";

            cmbOType.DataSource = dt;

            lvOrder.Columns.Add("ProductType",100,HorizontalAlignment.Center);
            lvOrder.Columns.Add("ProductName", 100, HorizontalAlignment.Center);
            lvOrder.Columns.Add("SizeId", 100, HorizontalAlignment.Center);
            lvOrder.Columns.Add("Size", 100, HorizontalAlignment.Center);
            lvOrder.Columns.Add("Price", 100, HorizontalAlignment.Center);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblOName_Click(object sender, EventArgs e)
        {

        }

        private void lvOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
