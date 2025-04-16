namespace WindowsFormsAppDemo
{
    partial class customer
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
            this.cmbb = new System.Windows.Forms.ComboBox();
            this.searchinput = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.dgvp = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnref);
            this.tabPage1.Controls.Add(this.btnflt);
            this.tabPage1.Controls.Add(this.btnsort);
            this.tabPage1.Controls.Add(this.cmbb);
            this.tabPage1.Controls.Add(this.searchinput);
            this.tabPage1.Controls.Add(this.btnseach);
            this.tabPage1.Controls.Add(this.btnbuy);
            this.tabPage1.Controls.Add(this.dgvp);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnref
            // 
            this.btnref.Location = new System.Drawing.Point(718, 432);
            this.btnref.Name = "btnref";
            this.btnref.Size = new System.Drawing.Size(75, 31);
            this.btnref.TabIndex = 29;
            this.btnref.Text = "Refresh";
            this.btnref.UseVisualStyleBackColor = true;
            this.btnref.Click += new System.EventHandler(this.btnref_Click);
            // 
            // btnflt
            // 
            this.btnflt.Location = new System.Drawing.Point(718, 356);
            this.btnflt.Name = "btnflt";
            this.btnflt.Size = new System.Drawing.Size(75, 31);
            this.btnflt.TabIndex = 28;
            this.btnflt.Text = "Filter";
            this.btnflt.UseVisualStyleBackColor = true;
            this.btnflt.Click += new System.EventHandler(this.btnflt_Click);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(506, 357);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(75, 31);
            this.btnsort.TabIndex = 27;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
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
            this.cmbb.Location = new System.Drawing.Point(718, 393);
            this.cmbb.Name = "cmbb";
            this.cmbb.Size = new System.Drawing.Size(112, 28);
            this.cmbb.TabIndex = 26;
            // 
            // searchinput
            // 
            this.searchinput.Location = new System.Drawing.Point(411, 432);
            this.searchinput.Name = "searchinput";
            this.searchinput.Size = new System.Drawing.Size(278, 26);
            this.searchinput.TabIndex = 25;
            this.searchinput.TextChanged += new System.EventHandler(this.searchinput_TextChanged);
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(277, 428);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(75, 30);
            this.btnseach.TabIndex = 24;
            this.btnseach.Text = "Search";
            this.btnseach.UseVisualStyleBackColor = true;
            this.btnseach.Click += new System.EventHandler(this.btnseach_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.Location = new System.Drawing.Point(277, 357);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(75, 30);
            this.btnbuy.TabIndex = 21;
            this.btnbuy.Text = "Buy";
            this.btnbuy.UseVisualStyleBackColor = true;
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
            this.dgvp.Location = new System.Drawing.Point(193, 6);
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
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 150;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
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
            this.InventoryQuantity.DataPropertyName = "InventoryQuantity";
            this.InventoryQuantity.HeaderText = "Quantity";
            this.InventoryQuantity.MinimumWidth = 8;
            this.InventoryQuantity.Name = "InventoryQuantity";
            this.InventoryQuantity.ReadOnly = true;
            this.InventoryQuantity.Width = 150;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txt);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dgvh);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1189, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Purchase HIstory";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 70;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(484, 439);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(278, 26);
            this.txt.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 68;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvh
            // 
            this.dgvh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column1,
            this.Sale});
            this.dgvh.Location = new System.Drawing.Point(173, 8);
            this.dgvh.Name = "dgvh";
            this.dgvh.RowHeadersWidth = 62;
            this.dgvh.RowTemplate.Height = 28;
            this.dgvh.Size = new System.Drawing.Size(843, 389);
            this.dgvh.TabIndex = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SalesID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sales ID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TotalAmount";
            this.Column1.HeaderText = "Total Amount";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Sale
            // 
            this.Sale.DataPropertyName = "SaleDate";
            this.Sale.HeaderText = "SaleDate";
            this.Sale.MinimumWidth = 8;
            this.Sale.Name = "Sale";
            this.Sale.Width = 150;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.customer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvp)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnref;
        private System.Windows.Forms.Button btnflt;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.ComboBox cmbb;
        private System.Windows.Forms.TextBox searchinput;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Button btnbuy;
        private System.Windows.Forms.DataGridView dgvp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
    }
}