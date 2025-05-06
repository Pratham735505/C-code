namespace Inventory
{
    partial class Orderform
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
            panel2 = new Panel();
            btn_cart = new Button();
            btnorder = new Button();
            btnadd = new Button();
            label1 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
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
            dgv1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column2, Column4, Column8, Column1 });
            dgv1.GridColor = Color.FromArgb(30, 58, 138);
            dgv1.Location = new Point(2, 3);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv1.Size = new Size(1034, 452);
            dgv1.TabIndex = 6;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 58, 138);
            panel2.Controls.Add(btn_cart);
            panel2.Controls.Add(btnorder);
            panel2.Controls.Add(btnadd);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 455);
            panel2.Name = "panel2";
            panel2.Size = new Size(1034, 53);
            panel2.TabIndex = 7;
            // 
            // btn_cart
            // 
            btn_cart.Location = new Point(642, 18);
            btn_cart.Name = "btn_cart";
            btn_cart.Size = new Size(110, 26);
            btn_cart.TabIndex = 4;
            btn_cart.Text = "Cart";
            btn_cart.UseVisualStyleBackColor = true;
            btn_cart.Click += btn_cart_Click;
            // 
            // btnorder
            // 
            btnorder.Location = new Point(779, 18);
            btnorder.Name = "btnorder";
            btnorder.Size = new Size(110, 26);
            btnorder.TabIndex = 3;
            btnorder.Text = "Place order";
            btnorder.UseVisualStyleBackColor = true;
            btnorder.Click += button1_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(921, 18);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(81, 26);
            btnadd.TabIndex = 2;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 58, 138);
            label1.Font = new Font("Lucida Calligraphy", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(277, 39);
            label1.TabIndex = 1;
            label1.Text = "Manage Orders";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "order_id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 93;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Order Date";
            Column2.MaxInputLength = 30;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 112;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Customer_id";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Amount";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 91;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Address";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Orderform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 516);
            Controls.Add(panel2);
            Controls.Add(dgv1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orderform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orderform";
            Load += Orderform_Load;
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv1;
        private Panel panel2;
        private Button btnadd;
        private Label label1;
        private Button btnorder;
        private Button btn_cart;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
    }
}