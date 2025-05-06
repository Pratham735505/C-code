namespace Inventory
{
    partial class Customerform
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
            dgv1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv1
            // 
            dgv1.AllowUserToDeleteRows = false;
            dgv1.BackgroundColor = SystemColors.ControlLightLight;
            dgv1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column2, Column4 });
            dgv1.GridColor = Color.FromArgb(30, 58, 138);
            dgv1.Location = new Point(-1, -1);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv1.Size = new Size(1057, 454);
            dgv1.TabIndex = 3;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Customer_id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 120;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Full name";
            Column2.MaxInputLength = 30;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Phone";
            Column4.MaxInputLength = 10;
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 58, 138);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 53);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(894, 18);
            button1.Name = "button1";
            button1.Size = new Size(81, 26);
            button1.TabIndex = 3;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 58, 138);
            label1.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(338, 39);
            label1.TabIndex = 1;
            label1.Text = "Manage Customers";
            // 
            // Customerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 510);
            Controls.Add(panel2);
            Controls.Add(dgv1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customerform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customerform";
            Load += Customerform_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
    }
}