using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace ShopManagement
{
    public partial class frmLogin : Form
    {
        string text1;
        string text2;
        string text3;
        int text4;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserClasss objT = new UserClasss(txtEmail.Text,txtPassword.Text);
            SqlDataReader dt;
            dt = objT.LoginData();
            while (dt.Read())
            {
                text1 = dt["UserName"].ToString();
                text2 = dt["UserEmail"].ToString();
                text3 = dt["UserPhoneNo"].ToString() ;
                text4 = Convert.ToInt32(dt["UserId"].ToString());
            }
            if (dt.HasRows == true)
            {
                if(cmbType.SelectedItem.ToString()=="Customer")
                {
                    dt.Close();
                    MessageBox.Show("Login Successfully");

                    FrmOrder objO = new FrmOrder(text1,text2,text3,text4);
                    objO.Show();
                    
                }else if (cmbType.SelectedItem.ToString()=="Admin")
                {
                   MessageBox.Show("Login Successfully");
                   OrderDetails objL = new OrderDetails();
                   objL.Show();

                }
            }



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbType.SelectedItem = null;
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}
