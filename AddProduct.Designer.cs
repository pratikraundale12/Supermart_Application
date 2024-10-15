namespace SuperMart_App
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            groupBox2 = new GroupBox();
            lblProdID = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtQty = new TextBox();
            label2 = new Label();
            txtProdName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            cmbsearch = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = (Image)resources.GetObject("groupBox2.BackgroundImage");
            groupBox2.CausesValidation = false;
            groupBox2.Controls.Add(lblProdID);
            groupBox2.Controls.Add(cmbCategory);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtPrice);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtQty);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtProdName);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(3, -3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1208, 218);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Seller";
            // 
            // lblProdID
            // 
            lblProdID.AutoSize = true;
            lblProdID.Image = (Image)resources.GetObject("lblProdID.Image");
            lblProdID.Location = new Point(9, 160);
            lblProdID.Name = "lblProdID";
            lblProdID.Size = new Size(30, 25);
            lblProdID.TabIndex = 18;
            lblProdID.Text = "ID";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(319, 88);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(239, 33);
            cmbCategory.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(318, 43);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 16;
            label4.Text = "Category";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(607, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(156, 31);
            txtPrice.TabIndex = 15;
            txtPrice.TextChanged += txtPhone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(607, 43);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 14;
            label3.Text = "Prize";
            label3.Click += label3_Click;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(794, 87);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(150, 31);
            txtQty.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(794, 43);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 12;
            label2.Text = "Quantity:";
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(9, 88);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(266, 31);
            txtProdName.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(849, 160);
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
            btnUpdate.Location = new Point(681, 160);
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
            btnAdd.Location = new Point(511, 160);
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
            label1.Location = new Point(9, 43);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 2;
            label1.Text = "Product Name:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1202, 301);
            dataGridView1.TabIndex = 9;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbsearch);
            panel1.Location = new Point(3, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 54);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(551, 6);
            button2.Name = "button2";
            button2.Size = new Size(101, 43);
            button2.TabIndex = 21;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(708, 9);
            button1.Name = "button1";
            button1.Size = new Size(101, 43);
            button1.TabIndex = 20;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 15);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 19;
            label5.Text = "Search";
            // 
            // cmbsearch
            // 
            cmbsearch.FormattingEnabled = true;
            cmbsearch.Location = new Point(176, 12);
            cmbsearch.Name = "cmbsearch";
            cmbsearch.Size = new Size(265, 33);
            cmbsearch.TabIndex = 18;
            cmbsearch.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 561);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtQty;
        private Label label2;
        private TextBox txtProdName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox cmbCategory;
        private Panel panel1;
        private ComboBox cmbsearch;
        private Button button1;
        private Label label5;
        private Label lblProdID;
        private Button button2;
    }
}