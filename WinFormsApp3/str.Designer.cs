namespace WinFormsApp3
{
    partial class str
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
            textBox1 = new TextBox();
            btnc = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 0;
            // 
            // btnc
            // 
            btnc.Location = new Point(294, 146);
            btnc.Name = "btnc";
            btnc.Size = new Size(137, 27);
            btnc.TabIndex = 1;
            btnc.Text = "Convert";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // str
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnc);
            Controls.Add(textBox1);
            Name = "str";
            Text = "str";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnc;
    }
}