namespace Inventory
{
    partial class Productmodule
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
            textuser = new TextBox();
            label6 = new Label();
            button3 = new Button();
            button1 = new Button();
            textqty = new TextBox();
            label5 = new Label();
            textname = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textprice = new TextBox();
            label2 = new Label();
            textdesc = new TextBox();
            label4 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textuser
            // 
            textuser.Enabled = false;
            textuser.Location = new Point(263, 73);
            textuser.MaxLength = 30;
            textuser.Name = "textuser";
            textuser.Size = new Size(398, 27);
            textuser.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(125, 77);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 37;
            label6.Text = "Product Id:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 58, 38);
            button3.Font = new Font("Lucida Calligraphy", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(595, 344);
            button3.Name = "button3";
            button3.Size = new Size(108, 50);
            button3.TabIndex = 36;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 58, 138);
            button1.Font = new Font("Lucida Calligraphy", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(354, 344);
            button1.Name = "button1";
            button1.Size = new Size(108, 50);
            button1.TabIndex = 34;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textqty
            // 
            textqty.Location = new Point(263, 165);
            textqty.MaxLength = 10;
            textqty.Name = "textqty";
            textqty.Size = new Size(398, 27);
            textqty.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 167);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 32;
            label5.Text = "Quantity:";
            // 
            // textname
            // 
            textname.Location = new Point(263, 119);
            textname.MaxLength = 30;
            textname.Name = "textname";
            textname.Size = new Size(398, 27);
            textname.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 119);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 30;
            label3.Text = "Product Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 138);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 59);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(381, 52);
            label1.TabIndex = 0;
            label1.Text = "Product Module";
            // 
            // textprice
            // 
            textprice.Location = new Point(266, 216);
            textprice.MaxLength = 10;
            textprice.Name = "textprice";
            textprice.Size = new Size(398, 27);
            textprice.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 218);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 39;
            label2.Text = "Price:";
            // 
            // textdesc
            // 
            textdesc.Location = new Point(264, 263);
            textdesc.MaxLength = 10;
            textdesc.Name = "textdesc";
            textdesc.Size = new Size(398, 27);
            textdesc.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 262);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 41;
            label4.Text = "Description:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(122, 306);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(89, 23);
            label7.TabIndex = 43;
            label7.Text = "Category:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 28);
            comboBox1.TabIndex = 44;
            // 
            // Productmodule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 409);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textdesc);
            Controls.Add(label4);
            Controls.Add(textprice);
            Controls.Add(label2);
            Controls.Add(textuser);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textqty);
            Controls.Add(label5);
            Controls.Add(textname);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Productmodule";
            Text = "Productmodule";
            Load += Productmodule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textuser;
        private Label label6;
        public Button button3;
        public Button button1;
        private TextBox textqty;
        private Label label5;
        private TextBox textname;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private TextBox textprice;
        private Label label2;
        private TextBox textdesc;
        private Label label4;
        private Label label7;
        private ComboBox comboBox1;
    }
}