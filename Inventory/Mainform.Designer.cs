

namespace Inventory
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            panel1 = new Panel();
            button1 = new Button();
            btnorder = new Button();
            btnpr = new Button();
            btnuser = new Button();
            panel3 = new Panel();
            btncate = new Button();
            label1 = new Label();
            btncust = new Button();
            main = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 138);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnorder);
            panel1.Controls.Add(btnpr);
            panel1.Controls.Add(btnuser);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btncate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btncust);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 113);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 58, 138);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(4, 82);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 14;
            button1.Text = "Log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnorder
            // 
            btnorder.FlatStyle = FlatStyle.System;
            btnorder.Font = new Font("Showcard Gothic", 10.2F);
            btnorder.ForeColor = Color.FromArgb(30, 58, 138);
            btnorder.Location = new Point(608, 75);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(125, 28);
            btnorder.TabIndex = 13;
            btnorder.Text = "Orders";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += btnorder_Click;
            // 
            // btnpr
            // 
            btnpr.FlatStyle = FlatStyle.System;
            btnpr.Font = new Font("Showcard Gothic", 10.2F);
            btnpr.ForeColor = Color.FromArgb(30, 58, 138);
            btnpr.Location = new Point(318, 77);
            btnpr.Name = "btnpr";
            btnpr.Size = new Size(125, 28);
            btnpr.TabIndex = 9;
            btnpr.Text = "Product";
            btnpr.UseVisualStyleBackColor = true;
            btnpr.Click += btnpr_Click;
            // 
            // btnuser
            // 
            btnuser.FlatStyle = FlatStyle.System;
            btnuser.Font = new Font("Showcard Gothic", 10.2F);
            btnuser.ForeColor = Color.FromArgb(30, 58, 138);
            btnuser.Location = new Point(749, 75);
            btnuser.Name = "btnuser";
            btnuser.Size = new Size(125, 28);
            btnuser.TabIndex = 12;
            btnuser.Text = "Users";
            btnuser.UseVisualStyleBackColor = true;
            btnuser.Click += btnuser_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(22, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 76);
            panel3.TabIndex = 3;
            // 
            // btncate
            // 
            btncate.FlatStyle = FlatStyle.System;
            btncate.Font = new Font("Showcard Gothic", 10.2F);
            btncate.ForeColor = Color.FromArgb(30, 58, 138);
            btncate.Location = new Point(460, 77);
            btncate.Name = "btncate";
            btncate.Size = new Size(125, 28);
            btncate.TabIndex = 11;
            btncate.Text = "Categories";
            btncate.UseVisualStyleBackColor = true;
            btncate.Click += btncate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(129, -1);
            label1.Name = "label1";
            label1.Size = new Size(841, 60);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management System";
            label1.Click += label1_Click;
            // 
            // btncust
            // 
            btncust.FlatStyle = FlatStyle.System;
            btncust.Font = new Font("Showcard Gothic", 10.2F);
            btncust.ForeColor = Color.FromArgb(30, 58, 138);
            btncust.Location = new Point(167, 77);
            btncust.Name = "btncust";
            btncust.Size = new Size(125, 28);
            btncust.TabIndex = 10;
            btncust.Text = "Customers";
            btncust.UseVisualStyleBackColor = true;
            btncust.Click += btncust_Click;
            // 
            // main
            // 
            main.Location = new Point(1, 115);
            main.MaximumSize = new Size(1035, 507);
            main.MinimumSize = new Size(1035, 507);
            main.Name = "main";
            main.Size = new Size(1035, 507);
            main.TabIndex = 2;
            main.Paint += main_Paint;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 58, 138);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(927, 82);
            button2.Name = "button2";
            button2.Size = new Size(109, 31);
            button2.TabIndex = 15;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 622);
            Controls.Add(main);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1056, 669);
            MinimumSize = new Size(1056, 669);
            Name = "Mainform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Portal";
            Load += Mainform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }


        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Button btnorder;
        private Button btnpr;
        private Button btnuser;
        private Button btncate;
        private Button btncust;
        private Panel main;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
    }
}