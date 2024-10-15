using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Form1.loginname != null)
            {
                toolStripStatusLabel2.Text = Form1.loginname;
            }
            if (!string.IsNullOrEmpty(Form1.logintype) && Form1.logintype == "Seller")
            {
                // Disable or hide certain menu items for sellers
                // productToolStripMenuItem.Enabled = false;
                // addUserToolStripMenuItem.Enabled = false;

                // Y hide completely if needed:
                productToolStripMenuItem.Visible = false;
                addUserToolStripMenuItem.Visible = false;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void SuperMart_Click(object sender, EventArgs e)
        {

        }

        private void SuperMart_Click_1(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCategory fcat = new();
            fcat.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewSeller frmAddNewSeller = new frmAddNewSeller();
            frmAddNewSeller.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin aaf = new AddAdmin();
            aaf.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct ap = new AddProduct();
            ap.ShowDialog();
        }
    }
}
