namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            lbl1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button8 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(610, 57);
            button1.Name = "button1";
            button1.Size = new Size(123, 44);
            button1.TabIndex = 0;
            button1.Text = "String ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(610, 107);
            button2.Name = "button2";
            button2.Size = new Size(123, 44);
            button2.TabIndex = 1;
            button2.Text = "Prime Number";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(610, 21);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(127, 20);
            lbl1.TabIndex = 2;
            lbl1.Text = "Choose your form";
            // 
            // button3
            // 
            button3.Location = new Point(609, 157);
            button3.Name = "button3";
            button3.Size = new Size(123, 44);
            button3.TabIndex = 3;
            button3.Text = "Armstrong";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(609, 207);
            button4.Name = "button4";
            button4.Size = new Size(123, 44);
            button4.TabIndex = 4;
            button4.Text = "BMI Calculator";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(609, 257);
            button5.Name = "button5";
            button5.Size = new Size(123, 44);
            button5.TabIndex = 5;
            button5.Text = "Unit Converter";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(559, 357);
            button8.Name = "button8";
            button8.Size = new Size(233, 44);
            button8.TabIndex = 8;
            button8.Text = "Celsius to Fahrenheit";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(609, 307);
            button7.Name = "button7";
            button7.Size = new Size(123, 44);
            button7.TabIndex = 7;
            button7.Text = "factorial";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 619);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(lbl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lbl1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button8;
        private Button button7;
    }
}
