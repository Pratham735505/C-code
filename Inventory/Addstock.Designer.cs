namespace Inventory
{
    partial class Addstock
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
            label5 = new Label();
            textname = new TextBox();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            textamt = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 154);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 36;
            label5.Text = "Quantity:";
            // 
            // textname
            // 
            textname.Enabled = false;
            textname.Location = new Point(182, 108);
            textname.MaxLength = 30;
            textname.Name = "textname";
            textname.Size = new Size(398, 27);
            textname.TabIndex = 35;
            textname.TextChanged += textname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 110);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 34;
            label3.Text = "Product Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 64);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 39;
            label6.Text = "Product Id:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 28);
            comboBox1.TabIndex = 40;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 228);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 41;
            label1.Text = "Amount:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            numericUpDown1.Location = new Point(180, 150);
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 42;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textamt
            // 
            textamt.Enabled = false;
            textamt.Location = new Point(180, 230);
            textamt.MaxLength = 30;
            textamt.Name = "textamt";
            textamt.Size = new Size(398, 27);
            textamt.TabIndex = 43;
            textamt.TextChanged += textamt_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 138);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-24, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 59);
            panel1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(57, 8);
            label2.Name = "label2";
            label2.Size = new Size(318, 52);
            label2.TabIndex = 0;
            label2.Text = "Stock Module";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 193);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 45;
            label4.Text = "Price:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(180, 193);
            textBox1.MaxLength = 30;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 27);
            textBox1.TabIndex = 46;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 58, 138);
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(448, 263);
            button1.Name = "button1";
            button1.Size = new Size(95, 41);
            button1.TabIndex = 47;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Addstock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 316);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(textamt);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textname);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Addstock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buying stock";
            Load += Addstock_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox textname;
        private Label label3;
        private Label label6;
        private ComboBox comboBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private TextBox textamt;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
    }
}