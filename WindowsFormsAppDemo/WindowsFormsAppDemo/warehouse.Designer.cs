namespace WindowsFormsAppDemo
{
    partial class warehouse
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnref = new System.Windows.Forms.Button();
            this.btnflt = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.ctgr = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.pdn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbb = new System.Windows.Forms.ComboBox();
            this.searchinput = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnupd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvp = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.btnref2 = new System.Windows.Forms.Button();
            this.searchinput2 = new System.Windows.Forms.TextBox();
            this.btnsearch2 = new System.Windows.Forms.Button();
            this.btnupd2 = new System.Windows.Forms.Button();
            this.btndel2 = new System.Windows.Forms.Button();
            this.prc = new System.Windows.Forms.TextBox();
            this.qtt = new System.Windows.Forms.TextBox();
            this.prdn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvo = new System.Windows.Forms.DataGridView();
            this.SalesDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnref);
            this.tabPage1.Controls.Add(this.btnflt);
            this.tabPage1.Controls.Add(this.btnsort);
            this.tabPage1.Controls.Add(this.ctgr);
            this.tabPage1.Controls.Add(this.quantity);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.pdn);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbb);
            this.tabPage1.Controls.Add(this.searchinput);
            this.tabPage1.Controls.Add(this.btnseach);
            this.tabPage1.Controls.Add(this.btnupd);
            this.tabPage1.Controls.Add(this.btndel);
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.dgvp);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnref
            // 
            this.btnref.Location = new System.Drawing.Point(943, 352);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(75, 31);
            this.btnref.TabIndex = 37;
            this.btnref.Text = "Refresh";
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click_1);
            // 
            // btnflt
            // 
            this.btnflt.Location = new System.Drawing.Point(817, 351);
            this.btnflt.Name = "btnflt";
            this.btnflt.Size = new System.Drawing.Size(75, 31);
            this.btnflt.TabIndex = 36;
            this.btnflt.Text = "Filter";
            this.btnflt.UseVisualStyleBackColor = true;
            this.btnflt.Click += new System.EventHandler(this.btnflt_Click_1);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(690, 351);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(75, 31);
            this.btnsort.TabIndex = 35;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click_1);
            // 
            // ctgr
            // 
            this.ctgr.Location = new System.Drawing.Point(173, 307);
            this.ctgr.Name = "ctgr";
            this.ctgr.Size = new System.Drawing.Size(122, 26);
            this.ctgr.TabIndex = 34;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(173, 234);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(122, 26);
            this.quantity.TabIndex = 33;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(173, 165);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(122, 26);
            this.price.TabIndex = 32;
            // 
            // pdn
            // 
            this.pdn.Location = new System.Drawing.Point(173, 97);
            this.pdn.Name = "pdn";
            this.pdn.Size = new System.Drawing.Size(122, 26);
            this.pdn.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Product Name";
            // 
            // cmbb
            // 
            this.cmbb.FormattingEnabled = true;
            this.cmbb.Items.AddRange(new object[] {
            "Android",
            "Chips",
            "Part",
            "Tool",
            "Item"});
            this.cmbb.Location = new System.Drawing.Point(798, 388);
            this.cmbb.Name = "cmbb";
            this.cmbb.Size = new System.Drawing.Size(112, 28);
            this.cmbb.TabIndex = 26;
            // 
            // searchinput
            // 
            this.searchinput.Location = new System.Drawing.Point(487, 405);
            this.searchinput.Name = "searchinput";
            this.searchinput.Size = new System.Drawing.Size(278, 26);
            this.searchinput.TabIndex = 25;
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(366, 401);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(75, 30);
            this.btnseach.TabIndex = 24;
            this.btnseach.Text = "Search";
            this.btnseach.UseVisualStyleBackColor = true;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click_1);
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(433, 352);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(75, 30);
            this.btnupd.TabIndex = 23;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click_1);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(565, 352);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 30);
            this.btndel.TabIndex = 22;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(309, 353);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 30);
            this.btnadd.TabIndex = 21;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvp
            // 
            this.dgvp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.SellingPrice,
            this.InventoryQuantity,
            this.Category});
            this.dgvp.Location = new System.Drawing.Point(340, 1);
            this.dgvp.Name = "dgvp";
            this.dgvp.RowHeadersWidth = 62;
            this.dgvp.RowTemplate.Height = 28;
            this.dgvp.Size = new System.Drawing.Size(830, 345);
            this.dgvp.TabIndex = 20;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 8;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "Price";
            this.SellingPrice.MinimumWidth = 8;
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            this.SellingPrice.Width = 150;
            // 
            // InventoryQuantity
            // 
            this.InventoryQuantity.HeaderText = "Quantity";
            this.InventoryQuantity.MinimumWidth = 8;
            this.InventoryQuantity.Name = "InventoryQuantity";
            this.InventoryQuantity.Width = 150;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnref2);
            this.tabPage2.Controls.Add(this.searchinput2);
            this.tabPage2.Controls.Add(this.btnsearch2);
            this.tabPage2.Controls.Add(this.btnupd2);
            this.tabPage2.Controls.Add(this.btndel2);
            this.tabPage2.Controls.Add(this.prc);
            this.tabPage2.Controls.Add(this.qtt);
            this.tabPage2.Controls.Add(this.prdn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1215, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Manage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 77;
            this.label11.Text = "Product Name";
            // 
            // btnref2
            // 
            this.btnref2.Location = new System.Drawing.Point(766, 381);
            this.btnref2.Name = "btnref2";
            this.btnref2.Size = new System.Drawing.Size(75, 31);
            this.btnref2.TabIndex = 76;
            this.btnref2.Text = "Refresh";
            this.btnref2.UseVisualStyleBackColor = true;
            this.btnref2.Click += new System.EventHandler(this.btnref2_Click);
            // 
            // searchinput2
            // 
            this.searchinput2.Location = new System.Drawing.Point(544, 432);
            this.searchinput2.Name = "searchinput2";
            this.searchinput2.Size = new System.Drawing.Size(278, 26);
            this.searchinput2.TabIndex = 75;
            // 
            // btnsearch2
            // 
            this.btnsearch2.Location = new System.Drawing.Point(421, 428);
            this.btnsearch2.Name = "btnsearch2";
            this.btnsearch2.Size = new System.Drawing.Size(75, 30);
            this.btnsearch2.TabIndex = 74;
            this.btnsearch2.Text = "Search";
            this.btnsearch2.UseVisualStyleBackColor = true;
            this.btnsearch2.Click += new System.EventHandler(this.btnsearch2_Click);
            // 
            // btnupd2
            // 
            this.btnupd2.Location = new System.Drawing.Point(477, 381);
            this.btnupd2.Name = "btnupd2";
            this.btnupd2.Size = new System.Drawing.Size(75, 30);
            this.btnupd2.TabIndex = 73;
            this.btnupd2.Text = "Update";
            this.btnupd2.UseVisualStyleBackColor = true;
            this.btnupd2.Click += new System.EventHandler(this.btnupd2_Click);
            // 
            // btndel2
            // 
            this.btndel2.Location = new System.Drawing.Point(615, 382);
            this.btndel2.Name = "btndel2";
            this.btndel2.Size = new System.Drawing.Size(75, 30);
            this.btndel2.TabIndex = 72;
            this.btndel2.Text = "Delete";
            this.btndel2.UseVisualStyleBackColor = true;
            this.btndel2.Click += new System.EventHandler(this.btndel2_Click);
            // 
            // prc
            // 
            this.prc.Location = new System.Drawing.Point(185, 256);
            this.prc.Name = "prc";
            this.prc.Size = new System.Drawing.Size(100, 26);
            this.prc.TabIndex = 71;
            // 
            // qtt
            // 
            this.qtt.Location = new System.Drawing.Point(185, 183);
            this.qtt.Name = "qtt";
            this.qtt.Size = new System.Drawing.Size(100, 26);
            this.qtt.TabIndex = 70;
            // 
            // prdn
            // 
            this.prdn.Location = new System.Drawing.Point(185, 112);
            this.prdn.Name = "prdn";
            this.prdn.Size = new System.Drawing.Size(100, 26);
            this.prdn.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Quantity";
            // 
            // dgvo
            // 
            this.dgvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesDetailID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvo.Location = new System.Drawing.Point(361, -3);
            this.dgvo.Name = "dgvo";
            this.dgvo.RowHeadersWidth = 62;
            this.dgvo.RowTemplate.Height = 28;
            this.dgvo.Size = new System.Drawing.Size(815, 347);
            this.dgvo.TabIndex = 65;
            // 
            // SalesDetailID
            // 
            this.SalesDetailID.DataPropertyName = "SalesDetailID";
            this.SalesDetailID.HeaderText = "Sales Detail ID";
            this.SalesDetailID.MinimumWidth = 8;
            this.SalesDetailID.Name = "SalesDetailID";
            this.SalesDetailID.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "warehouse";
            this.Text = "warehouse";
            this.Load += new System.EventHandler(this.warehouse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Button btnflt;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.TextBox ctgr;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox pdn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbb;
        private System.Windows.Forms.TextBox searchinput;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnupd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Button btnref2;
        private System.Windows.Forms.TextBox searchinput2;
        private System.Windows.Forms.Button btnsearch2;
        private System.Windows.Forms.Button btnupd2;
        private System.Windows.Forms.Button btndel2;
        private System.Windows.Forms.TextBox prc;
        private System.Windows.Forms.TextBox qtt;
        private System.Windows.Forms.TextBox prdn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}