namespace WinFormsApp3
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(21, 268);
            button1.Name = "button1";
            button1.Size = new Size(230, 56);
            button1.TabIndex = 0;
            button1.Text = "kg<-->g";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(297, 268);
            button2.Name = "button2";
            button2.Size = new Size(230, 56);
            button2.TabIndex = 1;
            button2.Text = "Kilometre to miles";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(572, 268);
            button4.Name = "button4";
            button4.Size = new Size(230, 56);
            button4.TabIndex = 3;
            button4.Text = "kph to m/s";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 58);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter in kg";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 127);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter in grams";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Meiryo UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(337, 193);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 7;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // Form2
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.convert;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form2";
            Text = "Unit Converter";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}