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
using GoMartApplication;

namespace SuperMart_App
{
    public partial class FrmCategory : Form
    {
        DBConnect dbCon = new DBConnect();
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmCategory));
            groupBox3 = new GroupBox();
            SuperMart = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblCatID = new Label();
            txtCatName = new TextBox();
            rtbCatDes = new RichTextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAddCat = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DodgerBlue;
            groupBox3.Controls.Add(SuperMart);
            groupBox3.Location = new Point(0, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1171, 72);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // SuperMart
            // 
            SuperMart.AutoSize = true;
            SuperMart.ForeColor = Color.White;
            SuperMart.Location = new Point(527, 15);
            SuperMart.Name = "SuperMart";
            SuperMart.Size = new Size(95, 25);
            SuperMart.TabIndex = 6;
            SuperMart.Text = "SuperMart";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(24, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(571, 437);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.CausesValidation = false;
            groupBox2.Controls.Add(lblCatID);
            groupBox2.Controls.Add(txtCatName);
            groupBox2.Controls.Add(rtbCatDes);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAddCat);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(1, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 492);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Category";
            // 
            // lblCatID
            // 
            lblCatID.AutoSize = true;
            lblCatID.Image = (Image)resources.GetObject("lblCatID.Image");
            lblCatID.Location = new Point(139, 27);
            lblCatID.Name = "lblCatID";
            lblCatID.Size = new Size(106, 25);
            lblCatID.TabIndex = 11;
            lblCatID.Text = "Description:";
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(171, 58);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(351, 31);
            txtCatName.TabIndex = 10;
            // 
            // rtbCatDes
            // 
            rtbCatDes.Location = new Point(173, 141);
            rtbCatDes.Name = "rtbCatDes";
            rtbCatDes.Size = new Size(349, 129);
            rtbCatDes.TabIndex = 9;
            rtbCatDes.Text = "";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(409, 325);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 43);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button3_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Indigo;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(241, 325);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 43);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAddCat
            // 
            btnAddCat.BackColor = Color.SeaGreen;
            btnAddCat.Cursor = Cursors.Hand;
            btnAddCat.ForeColor = Color.White;
            btnAddCat.Location = new Point(71, 325);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(101, 43);
            btnAddCat.TabIndex = 6;
            btnAddCat.Text = "Add";
            btnAddCat.UseVisualStyleBackColor = false;
            btnAddCat.Click += btnAddCat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(10, 146);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 2;
            label1.Text = "Category Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(560, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(611, 492);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // FrmCategory
            // 
            AutoScroll = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1197, 561);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Category";
            Load += FrmCategory_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnUpdate;
        private Button btnAddCat;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button btnDelete;
        private RichTextBox rtbCatDes;
        private DataGridView dataGridView1;
        private TextBox txtCatName;
        private Label lblCatID;
        private Label SuperMart;

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            lblCatID.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            BindCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCatID.Text == String.Empty)
                {
                    MessageBox.Show("Please select CategoryID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (lblCatID.Text != String.Empty)
                {
                    if (DialogResult.Yes == MessageBox.Show("Do You Want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        SqlCommand cmd = new SqlCommand("spCatDelete", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(lblCatID.Text));
                        cmd.CommandType = CommandType.StoredProcedure;
                        dbCon.OpenCon();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Category Deleted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtclear();
                            BindCategory();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAddCat.Visible = true;
                            lblCatID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Delete failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtclear();
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

private void btnAddCat_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text == String.Empty)
            {
                MessageBox.Show("Please Enter valid Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclear();
                txtCatName.Focus();
                return;
            }
            if (rtbCatDes.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclear();
                rtbCatDes.Focus();
                return;
            }
            else
            {
                // Correct SQL query
                SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName = @CategoryName", dbCon.GetCon());
                cmd.Parameters.AddWithValue("@CategoryName", txtCatName.Text);
                dbCon.OpenCon();

                // Execute the query to check if the category exists
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    // Display message that the category already exists
                    MessageBox.Show($"Category {txtCatName.Text} already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtclear();
                }
                else
                {
                    // Insert new category using stored procedure
                    cmd = new SqlCommand("spCatInsert", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@CategoryName", txtCatName.Text);
                    cmd.Parameters.AddWithValue("@CategoryDesc", rtbCatDes.Text);
                    cmd.CommandType = CommandType.StoredProcedure;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Category Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtclear();
                        BindCategory();
                    }

                }
            }

        }
        private void txtclear()
        {
            txtCatName.Clear();
            rtbCatDes.Clear();
        }
        private void BindCategory()
        {
            SqlCommand cmd = new SqlCommand("select  CatID as CategoryID,CategoryName,CategoryDesc as CategoryDescription from tblCategory", dbCon.GetCon());
            dbCon.OpenCon();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dbCon.CloseCon();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            lblCatID.Visible = true;
            btnAddCat.Visible = false;

            lblCatID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtCatName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            rtbCatDes.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCatID.Text == String.Empty)
                {
                    MessageBox.Show("Please select CategoryID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatName.Focus();
                    return;
                }
                if (txtCatName.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter CategoryName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCatName.Focus();
                    return;
                }
                else if (rtbCatDes.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Category Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbCatDes.Focus();
                    return;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select CategoryName from tblCategory where CategoryName=@CategoryName", dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@CategoryName", txtCatName.Text);
                    dbCon.OpenCon();
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("CategoryName already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtclear();
                    }
                    else
                    {
                        cmd = new SqlCommand("spCatUpdate", dbCon.GetCon());
                        cmd.Parameters.AddWithValue("@CatID", Convert.ToInt32(lblCatID.Text));
                        cmd.Parameters.AddWithValue("@CategoryName", txtCatName.Text);
                        cmd.Parameters.AddWithValue("@CategoryDesc", rtbCatDes.Text);
                        cmd.CommandType = CommandType.StoredProcedure;
                        int i = cmd.ExecuteNonQuery();
                        dbCon.CloseCon();
                        if (i > 0)
                        {
                            MessageBox.Show("Category updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtclear();
                            BindCategory();
                            btnUpdate.Visible = false;
                            btnDelete.Visible = false;
                            btnAddCat.Visible = true;
                            lblCatID.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("update failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtclear();
                        }
                    }
                    dbCon.CloseCon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
