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
    public partial class frmUserRegistration : Form
    {
        string Gender;
        public frmUserRegistration()
        {
            InitializeComponent();
        }

        private void lblRegEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
           if( rdbMale.Checked == true)
            {
                Gender = "Male";
            }
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFemale.Checked == true)
            {
                Gender = "Female";
            }
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserClasss objCLS = new UserClasss(cmbRegType.Text,txtRegUserName.Text,txtRegEmail.Text,Gender,cmbRegState.Text,txtRegPassword.Text,txtPhoneNo.Text);
            objCLS.RegisterData();

            MessageBox.Show("Save Sucessfully....");

            
        }

        private void btnRegClear_Click(object sender, EventArgs e)
        {
            cmbRegType.SelectedItem= null;
            txtRegUserName.Clear();
            txtRegEmail.Clear();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            cmbRegState.SelectedItem = null;
            txtRegPassword.Clear();
        }
    }
}
