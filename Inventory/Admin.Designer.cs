namespace Inventory
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_cust = new Label();
            llbcust = new Label();
            lblp = new Label();
            lblearn = new Label();
            label6 = new Label();
            lblprofit = new Label();
            lbltime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 58, 138);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-9, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 53);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 58, 138);
            label1.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(406, 6);
            label1.Name = "label1";
            label1.Size = new Size(218, 39);
            label1.TabIndex = 1;
            label1.Text = "Dash Board";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(91, 32);
            label2.Name = "label2";
            label2.Size = new Size(222, 29);
            label2.TabIndex = 6;
            label2.Text = "Total Customers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(647, 32);
            label3.Name = "label3";
            label3.Size = new Size(176, 29);
            label3.TabIndex = 7;
            label3.Text = "Total Orders";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(92, 185);
            label4.Name = "label4";
            label4.Size = new Size(205, 29);
            label4.TabIndex = 8;
            label4.Text = "Total Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(647, 185);
            label5.Name = "label5";
            label5.Size = new Size(196, 29);
            label5.TabIndex = 9;
            label5.Text = "Total Earning";
            // 
            // lbl_cust
            // 
            lbl_cust.AutoSize = true;
            lbl_cust.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cust.ForeColor = Color.Black;
            lbl_cust.Location = new Point(91, 70);
            lbl_cust.Name = "lbl_cust";
            lbl_cust.Size = new Size(222, 29);
            lbl_cust.TabIndex = 10;
            lbl_cust.Text = "Total Customers";
            lbl_cust.Click += lbl_cust_Click;
            // 
            // llbcust
            // 
            llbcust.AutoSize = true;
            llbcust.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbcust.ForeColor = Color.Black;
            llbcust.Location = new Point(621, 70);
            llbcust.Name = "llbcust";
            llbcust.Size = new Size(222, 29);
            llbcust.TabIndex = 11;
            llbcust.Text = "Total Customers";
            llbcust.Click += llbcust_Click;
            // 
            // lblp
            // 
            lblp.AutoSize = true;
            lblp.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblp.ForeColor = Color.Black;
            lblp.Location = new Point(92, 227);
            lblp.Name = "lblp";
            lblp.Size = new Size(222, 29);
            lblp.TabIndex = 13;
            lblp.Text = "Total Customers";
            lblp.Click += lblp_Click;
            // 
            // lblearn
            // 
            lblearn.AutoSize = true;
            lblearn.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblearn.ForeColor = Color.Black;
            lblearn.Location = new Point(630, 227);
            lblearn.Name = "lblearn";
            lblearn.Size = new Size(222, 29);
            lblearn.TabIndex = 14;
            lblearn.Text = "Total Customers";
            lblearn.Click += lblearn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(388, 277);
            label6.Name = "label6";
            label6.Size = new Size(167, 29);
            label6.TabIndex = 15;
            label6.Text = "Total Profit";
            // 
            // lblprofit
            // 
            lblprofit.AutoSize = true;
            lblprofit.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblprofit.ForeColor = Color.Black;
            lblprofit.Location = new Point(388, 316);
            lblprofit.Name = "lblprofit";
            lblprofit.Size = new Size(177, 29);
            lblprofit.TabIndex = 16;
            lblprofit.Text = "Total Proffit";
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltime.ForeColor = Color.Black;
            lbltime.Location = new Point(388, 377);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(205, 29);
            lbltime.TabIndex = 17;
            lbltime.Text = "Total Products";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 463);
            Controls.Add(lbltime);
            Controls.Add(lblprofit);
            Controls.Add(label6);
            Controls.Add(lblearn);
            Controls.Add(lblp);
            Controls.Add(llbcust);
            Controls.Add(lbl_cust);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_cust;
        private Label llbcust;
        private Label lblp;
        private Label lblearn;
        private Label label6;
        private Label lblprofit;
        private Label lbltime;
        private System.Windows.Forms.Timer timer1;
    }
}