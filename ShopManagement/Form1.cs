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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objlogin = new frmLogin();
            objlogin.Show();
            objlogin.MdiParent = this;
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration objUsReg = new frmUserRegistration();
            objUsReg.Show();
            objUsReg.MdiParent = this;
            
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType objType = new frmType();
            objType.Show();
            objType.MdiParent= this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct objProduct = new frmProduct();
            objProduct.Show();
            objProduct.MdiParent= this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize objSize = new frmSize();
            objSize.Show();
            objSize.MdiParent = this;
        }
    }
}
