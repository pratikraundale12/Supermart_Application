using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using GoMartApplication;

namespace SuperMart_App
{
    public partial class frmAddNewSeller : Form
    {

        DBConnect dbCon = new DBConnect();
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
            BindSeller();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSellerName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter seller name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSellerName.Focus();
                return;
            }
            else if (txtPass.Text == String.Empty)
            {
                MessageBox.Show("Please Enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select SellerName from tblSeller where SellerName=@SellerName", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@SellerName", txtSellerName.Text);
                dbCon.OpenCon();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show("Seller Name already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClear();
                }
                else
                {
                    cmd = new SqlCommand("spSellerInsert", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@SellerName", txtSellerName.Text);
                    cmd.Parameters.AddWithValue("@SellerAge", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@SellerPhone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@SellerPass", txtPass.Text);
                    cmd.CommandType = CommandType.StoredProcedure;
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Seller Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindSeller();
                    }
                }
                dbCon.CloseCon();
            }
        }
        public void txtClear()
        {
            txtSellerName.Clear();
            txtPhone.Clear();
            txtPass.Clear();
            txtAge.Clear();
        }
        private void BindSeller()
        {
            SqlCommand cmd = new SqlCommand("select * from tblSeller", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblSellerID.Text == String.Empty)
                {
                    MessageBox.Show("Please select sellerID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtSellerName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSellerName.Focus();
                    return;
                }
                else if (txtPass.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                    return;
                }
                else
                {
                    // Fetch the current seller name from the database
                    SqlCommand fetchCmd = new SqlCommand("select SellerName from tblSeller where SellerID=@SellerID", dbCon.GetCon());
                    fetchCmd.Parameters.AddWithValue("@SellerID", Convert.ToInt32(lblSellerID.Text));
                    dbCon.OpenCon();
                    var currentSellerName = fetchCmd.ExecuteScalar()?.ToString();
                    dbCon.CloseCon();

                    // Check if the name has changed
                    if (currentSellerName != txtSellerName.Text)
                    {
                        // Perform the check for duplicate seller name only if the name has changed
                        SqlCommand checkCmd = new SqlCommand("select SellerName from tblSeller where SellerName=@SellerName", dbCon.GetCon());
                        checkCmd.Parameters.AddWithValue("@SellerName", txtSellerName.Text);
                        dbCon.OpenCon();
                        var result = checkCmd.ExecuteScalar();
                        dbCon.CloseCon();

                        if (result != null)
                        {
                            MessageBox.Show("Seller Name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClear();
                            return;
                        }
                    }

                    SqlCommand updateCmd = new SqlCommand("spSellerUpadte", dbCon.GetCon());
                    updateCmd.Parameters.AddWithValue("@SellerID", Convert.ToInt32(lblSellerID.Text));
                    updateCmd.Parameters.AddWithValue("@SellerName", txtSellerName.Text);
                    updateCmd.Parameters.AddWithValue("@SellerAge", Convert.ToInt32(txtAge.Text));
                    updateCmd.Parameters.AddWithValue("@SellerPhone", txtPhone.Text);
                    updateCmd.Parameters.AddWithValue("@SellerPass", txtPass.Text);
                    updateCmd.CommandType = CommandType.StoredProcedure;

                    dbCon.OpenCon();
                    int i = updateCmd.ExecuteNonQuery();
                    dbCon.CloseCon();

                    if (i > 0)
                    {
                        MessageBox.Show("Seller updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear();
                        BindSeller();
                        btnUpdate.Visible = false;
                        btnDelete.Visible = false;
                        btnAdd.Visible = true;
                        lblSellerID.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Update failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblSellerID.Text == String.Empty)
                {
                    MessageBox.Show("Please select CategoryID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblSellerID.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("spSellerDelete", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@SellerID", Convert.ToInt32(lblSellerID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Seller Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            BindSeller();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAdd.Visible = true;
                            lblSellerID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Delete failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClear();
                        }
                        dbCon.CloseCon();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddNewSeller_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            lblSellerID.Visible = true;
            btnAdd.Visible = false;

            lblSellerID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtSellerName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPass.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }

}

