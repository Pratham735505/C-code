﻿namespace WinFormsApp3
{
    partial class Prime
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
            btncheck = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btncheck
            // 
            btncheck.Location = new Point(370, 197);
            btncheck.Name = "btncheck";
            btncheck.Size = new Size(77, 33);
            btncheck.TabIndex = 0;
            btncheck.Text = "Check";
            btncheck.UseVisualStyleBackColor = true;
            btncheck.Click += btncheck_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(380, 136);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // Prime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btncheck);
            Name = "Prime";
            Text = "Prime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncheck;
        private TextBox textBox1;
        private Label label1;
    }
}