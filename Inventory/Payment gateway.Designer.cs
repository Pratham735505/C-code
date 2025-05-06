namespace Inventory
{
    partial class Payment_gateway
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
            panel1 = new Panel();
            label1 = new Label();
            amt = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 138);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 59);
            panel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(435, 52);
            label1.TabIndex = 0;
            label1.Text = "Payment Gateway";
            // 
            // amt
            // 
            amt.AutoSize = true;
            amt.Location = new Point(248, 92);
            amt.Name = "amt";
            amt.Size = new Size(50, 20);
            amt.TabIndex = 17;
            amt.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 92);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 18;
            label2.Text = "Total Amount:";
            // 
            // button1
            // 
            button1.Location = new Point(108, 161);
            button1.Name = "button1";
            button1.Size = new Size(124, 27);
            button1.TabIndex = 19;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(248, 161);
            button2.Name = "button2";
            button2.Size = new Size(124, 27);
            button2.TabIndex = 20;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Payment_gateway
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 218);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(amt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(569, 218);
            MinimumSize = new Size(569, 218);
            Name = "Payment_gateway";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment_gateway";
            Load += Payment_gateway_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        public Label amt;
    }
}