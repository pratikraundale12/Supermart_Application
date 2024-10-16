namespace SuperMart_App
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            panel1 = new Panel();
            lblDate = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProdID = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtQty = new TextBox();
            dataGridView1_Order = new DataGridView();
            ProdID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            cmbCategory = new ComboBox();
            dataGridView1 = new DataGridView();
            dataGridView2_Product = new DataGridView();
            btnRefCat = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblGrandTot = new Label();
            txtBillNo = new TextBox();
            button5 = new Button();
            btnAddBill_Details = new Button();
            label9 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2_Product).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.SeaGreen;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 51);
            panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.SeaGreen;
            lblDate.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(1042, 26);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(96, 25);
            lblDate.TabIndex = 3;
            lblDate.Text = "Oct 2024";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(954, 26);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Date :";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(630, 13);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Selling Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1168, 315);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 1;
            label3.Text = "Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 113);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 2;
            label4.Text = "Product :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(13, 167);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 3;
            label7.Text = "Price :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(13, 220);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 4;
            label8.Text = "Quantity :";
            label8.Click += label8_Click;
            // 
            // txtProdID
            // 
            txtProdID.Location = new Point(133, 64);
            txtProdID.Name = "txtProdID";
            txtProdID.Size = new Size(208, 31);
            txtProdID.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(134, 111);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(208, 31);
            txtProductName.TabIndex = 5;
            txtProductName.TextChanged += textBox2_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(133, 161);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(208, 31);
            txtPrice.TabIndex = 5;
            txtPrice.TextChanged += textBox2_TextChanged;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(133, 214);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(208, 31);
            txtQty.TabIndex = 5;
            txtQty.TextChanged += textBox2_TextChanged;
            // 
            // dataGridView1_Order
            // 
            dataGridView1_Order.AllowUserToAddRows = false;
            dataGridView1_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1_Order.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_Order.Columns.AddRange(new DataGridViewColumn[] { ProdID, ProductName, Price, Quantity, Total });
            dataGridView1_Order.Location = new Point(453, 51);
            dataGridView1_Order.Name = "dataGridView1_Order";
            dataGridView1_Order.RowHeadersVisible = false;
            dataGridView1_Order.RowHeadersWidth = 62;
            dataGridView1_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1_Order.Size = new Size(947, 261);
            dataGridView1_Order.TabIndex = 10;
            // 
            // ProdID
            // 
            ProdID.HeaderText = "\u007fProdID";
            ProdID.MinimumWidth = 8;
            ProdID.Name = "ProdID";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(13, 348);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(187, 33);
            cmbCategory.TabIndex = 12;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(453, 389);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(947, 237);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2_Product
            // 
            dataGridView2_Product.AllowUserToAddRows = false;
            dataGridView2_Product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2_Product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2_Product.Location = new Point(12, 410);
            dataGridView2_Product.Name = "dataGridView2_Product";
            dataGridView2_Product.RowHeadersVisible = false;
            dataGridView2_Product.RowHeadersWidth = 62;
            dataGridView2_Product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2_Product.Size = new Size(419, 265);
            dataGridView2_Product.TabIndex = 14;
            dataGridView2_Product.CellContentClick += dataGridView2_Product_CellContentClick;
            dataGridView2_Product.Click += dataGridView2_Product_Click;
            dataGridView2_Product.DoubleClick += dataGridView2_Product_DoubleClick;
            // 
            // btnRefCat
            // 
            btnRefCat.BackColor = Color.MediumBlue;
            btnRefCat.Cursor = Cursors.Hand;
            btnRefCat.ForeColor = Color.White;
            btnRefCat.Location = new Point(322, 348);
            btnRefCat.Name = "btnRefCat";
            btnRefCat.Size = new Size(109, 37);
            btnRefCat.TabIndex = 15;
            btnRefCat.Text = "Refresh";
            btnRefCat.UseVisualStyleBackColor = false;
            btnRefCat.Click += btnRefCat_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(453, 352);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 0;
            label5.Text = "Sells List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(13, 70);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 1;
            label6.Text = "Id :";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumBlue;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(605, 720);
            button1.Name = "button1";
            button1.Size = new Size(109, 37);
            button1.TabIndex = 17;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumBlue;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1145, 637);
            button3.Name = "button3";
            button3.Size = new Size(113, 43);
            button3.TabIndex = 18;
            button3.Text = "Print";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(82, 23);
            button4.TabIndex = 19;
            // 
            // lblGrandTot
            // 
            lblGrandTot.AutoSize = true;
            lblGrandTot.BackColor = Color.Transparent;
            lblGrandTot.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTot.ForeColor = Color.Black;
            lblGrandTot.Location = new Point(1274, 315);
            lblGrandTot.Name = "lblGrandTot";
            lblGrandTot.Size = new Size(40, 25);
            lblGrandTot.TabIndex = 1;
            lblGrandTot.Text = "0.0";
            // 
            // txtBillNo
            // 
            txtBillNo.Location = new Point(805, 352);
            txtBillNo.Name = "txtBillNo";
            txtBillNo.Size = new Size(208, 31);
            txtBillNo.TabIndex = 5;
            txtBillNo.TextChanged += textBox1_TextChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.Cursor = Cursors.Hand;
            button5.ForeColor = Color.White;
            button5.Location = new Point(133, 263);
            button5.Name = "button5";
            button5.Size = new Size(141, 49);
            button5.TabIndex = 20;
            button5.Text = "Add Order";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnAddBill_Details
            // 
            btnAddBill_Details.BackColor = Color.SeaGreen;
            btnAddBill_Details.ForeColor = Color.White;
            btnAddBill_Details.Location = new Point(1042, 353);
            btnAddBill_Details.Name = "btnAddBill_Details";
            btnAddBill_Details.Size = new Size(123, 34);
            btnAddBill_Details.TabIndex = 21;
            btnAddBill_Details.Text = "Add";
            btnAddBill_Details.UseVisualStyleBackColor = false;
            btnAddBill_Details.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(660, 356);
            label9.Name = "label9";
            label9.Size = new Size(122, 25);
            label9.TabIndex = 22;
            label9.Text = "Bill_Number";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrchid;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(206, 348);
            button2.Name = "button2";
            button2.Size = new Size(109, 37);
            button2.TabIndex = 23;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SellingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1400, 687);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(btnAddBill_Details);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(btnRefCat);
            Controls.Add(dataGridView2_Product);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(cmbCategory);
            Controls.Add(dataGridView1_Order);
            Controls.Add(txtQty);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtBillNo);
            Controls.Add(txtProdID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(lblGrandTot);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SellingForm";
            Text = "SellingForm";
            Load += SellingForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Order).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2_Product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblDate;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox txtProdID;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtQty;
        private DataGridView dataGridView1_Order;
        private ComboBox cmbCategory;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2_Product;
        private Button btnRefCat;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn ProdID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private Label lblGrandTot;
        private TextBox txtBillNo;
        private Button button5;
        private Button btnAddBill_Details;
        private Label label9;
        private Button button2;
    }
}