﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMart_App
{
    public partial class frmAddNewSeller : Form
    {
        public frmAddNewSeller()
        {
            InitializeComponent();
        }

        private void SuperMart_Click(object sender, EventArgs e)
        {

        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewSeller_Load(object sender, EventArgs e)
        {
            lblSellerID.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
