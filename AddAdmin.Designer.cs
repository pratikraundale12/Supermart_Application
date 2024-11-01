namespace SuperMart_App
{
    partial class AddAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdmin));
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            txtPass = new TextBox();
            label4 = new Label();
            txtAdminID = new TextBox();
            label3 = new Label();
            lblAdminID = new Label();
            txtAdminName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            SuperMart = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(585, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(611, 551);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.CausesValidation = false;
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAdminID);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblAdminID);
            groupBox2.Controls.Add(txtAdminName);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(1, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 551);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Seller";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(173, 227);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(351, 31);
            txtPass.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(13, 234);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 16;
            label4.Text = "Password";
            // 
            // txtAdminID
            // 
            txtAdminID.Location = new Point(175, 144);
            txtAdminID.Name = "txtAdminID";
            txtAdminID.Size = new Size(351, 31);
            txtAdminID.TabIndex = 15;
            txtAdminID.TextChanged += txtPhone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(11, 151);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 14;
            label3.Text = "Admin UserID";
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Image = (Image)resources.GetObject("lblAdminID.Image");
            lblAdminID.Location = new Point(139, 27);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(106, 25);
            lblAdminID.TabIndex = 11;
            lblAdminID.Text = "Description:";
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(175, 58);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(351, 31);
            txtAdminName.TabIndex = 10;
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
            btnDelete.Click += btnDelete_Click;
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
            btnUpdate.Click += btnUpdate_Click;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 2;
            label1.Text = "Admin Name:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DodgerBlue;
            groupBox3.Controls.Add(SuperMart);
            groupBox3.Location = new Point(-610, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(2021, 59);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            // 
            // SuperMart
            // 
            SuperMart.AutoSize = true;
            SuperMart.ForeColor = Color.White;
            SuperMart.Location = new Point(1149, 0);
            SuperMart.Name = "SuperMart";
            SuperMart.Size = new Size(95, 25);
            SuperMart.TabIndex = 6;
            SuperMart.Text = "SuperMart";
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 561);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAdmin";
            Text = "AddAdmin";
            Load += AddAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private TextBox txtPass;
        private TextBox txtAdminID;
        private Label label3;
        private TextBox txtAge;
        private Label label2;
        private Label lblAdminID;
        private TextBox txtAdminName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private GroupBox groupBox3;
        private Label SuperMart;
        private Label label4;
    }
}