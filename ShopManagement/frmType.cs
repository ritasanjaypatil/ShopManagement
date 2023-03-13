﻿using System;
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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void btnTSave_Click(object sender, EventArgs e)
        {
            ProductClass objShop = new ProductClass(cmbTType.SelectedItem.ToString());
            objShop.SaveType();
            MessageBox.Show("Save Product Successfully...!");

        }

        private void btnTClear_Click(object sender, EventArgs e)
        {
            cmbTType.SelectedItem = null;
        }

        private void frmType_Load(object sender, EventArgs e)
        {

        }
    }
}
