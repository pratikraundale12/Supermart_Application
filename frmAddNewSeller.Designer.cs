namespace SuperMart_App
{
    partial class frmAddNewSeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewSeller));
            groupBox3 = new GroupBox();
            SuperMart = new Label();
            groupBox2 = new GroupBox();
            txtPass = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label2 = new Label();
            lblSellerID = new Label();
            txtSellerName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DodgerBlue;
            groupBox3.Controls.Add(SuperMart);
            groupBox3.Location = new Point(-185, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2021, 59);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // SuperMart
            // 
            SuperMart.AutoSize = true;
            SuperMart.ForeColor = Color.White;
            SuperMart.Location = new Point(748, 0);
            SuperMart.Name = "SuperMart";
            SuperMart.Size = new Size(95, 25);
            SuperMart.TabIndex = 6;
            SuperMart.Text = "SuperMart";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.CausesValidation = false;
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAge);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(lblSellerID);
            groupBox2.Controls.Add(txtSellerName);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(3, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 494);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Seller";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(177, 274);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(351, 31);
            txtPass.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(13, 281);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 16;
            label4.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(175, 201);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(351, 31);
            txtPhone.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(11, 208);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 14;
            label3.Text = "Phone";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(172, 132);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(351, 31);
            txtAge.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(8, 139);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 12;
            label2.Text = "Seller Age:";
            // 
            // lblSellerID
            // 
            lblSellerID.AutoSize = true;
            lblSellerID.Image = (Image)resources.GetObject("lblSellerID.Image");
            lblSellerID.Location = new Point(139, 27);
            lblSellerID.Name = "lblSellerID";
            lblSellerID.Size = new Size(106, 25);
            lblSellerID.TabIndex = 11;
            lblSellerID.Text = "Description:";
            // 
            // txtSellerName
            // 
            txtSellerName.Location = new Point(171, 58);
            txtSellerName.Name = "txtSellerName";
            txtSellerName.Size = new Size(351, 31);
            txtSellerName.TabIndex = 10;
            txtSellerName.TextChanged += txtCatName_TextChanged_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(409, 355);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 43);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Indigo;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(241, 355);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 43);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(71, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 43);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddCat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 2;
            label1.Text = "Seller Name:";
            label1.Click += label1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(567, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(611, 492);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click_1;
            dataGridView1.ChangeUICues += dataGridView1_ChangeUICues;
            // 
            // frmAddNewSeller
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 561);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddNewSeller";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Seller";
            Load += frmAddNewSeller_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label SuperMart;
        private GroupBox groupBox2;
        private Label lblSellerID;
        private TextBox txtSellerName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtPass;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAge;
        private Label label2;
    }
}