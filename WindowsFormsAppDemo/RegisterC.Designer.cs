namespace WindowsFormsAppDemo
{
    partial class RegisterC
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
            this.label5 = new System.Windows.Forms.Label();
            this.chp = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.TextBox();
            this.pen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.epylog = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.usn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "If you\'re Employee click the button below";
            // 
            // chp
            // 
            this.chp.Location = new System.Drawing.Point(310, 409);
            this.chp.Name = "chp";
            this.chp.Size = new System.Drawing.Size(205, 33);
            this.chp.TabIndex = 32;
            this.chp.Text = "Employee\'s Register";
            this.chp.UseVisualStyleBackColor = true;
            this.chp.Click += new System.EventHandler(this.chp_Click);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(323, 252);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(204, 26);
            this.pwd.TabIndex = 31;
            // 
            // pen
            // 
            this.pen.Location = new System.Drawing.Point(323, 202);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(204, 26);
            this.pen.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 52);
            this.label3.TabIndex = 27;
            this.label3.Text = "Register ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Username";
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(359, 293);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(106, 33);
            this.btnreg.TabIndex = 24;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // epylog
            // 
            this.epylog.Location = new System.Drawing.Point(310, 459);
            this.epylog.Name = "epylog";
            this.epylog.Size = new System.Drawing.Size(205, 33);
            this.epylog.TabIndex = 34;
            this.epylog.Text = "Employee\'s Login";
            this.epylog.UseVisualStyleBackColor = true;
            this.epylog.Click += new System.EventHandler(this.epylog_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Phone";
            // 
            // usn
            // 
            this.usn.Location = new System.Drawing.Point(323, 154);
            this.usn.Name = "usn";
            this.usn.Size = new System.Drawing.Size(204, 26);
            this.usn.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 34);
            this.button1.TabIndex = 37;
            this.button1.Text = "Already have one?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegisterC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 508);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.epylog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chp);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.usn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreg);
            this.Name = "RegisterC";
            this.Text = "Customer\'s Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button chp;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox pen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button epylog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usn;
        private System.Windows.Forms.Button button1;
    }
}