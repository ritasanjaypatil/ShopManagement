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
    public partial class AllData : Form
    {
        public AllData()
        {
            InitializeComponent();
        }

        private void AllData_Load(object sender, EventArgs e)
        {
            ProductClass objP = new ProductClass();
            DataTable dt = new DataTable();
            dt = objP.AllData1();
            dtgvALLDATA.DataSource = dt;
            dtgvALLDATA.Show();
        }
    }
}
