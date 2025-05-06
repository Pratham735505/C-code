namespace Inventory
{
    partial class Ordermodule
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
            panel2 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            dgv2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btninsert = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textprod = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 138);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 59);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 8);
            label1.Name = "label1";
            label1.Size = new Size(405, 52);
            label1.TabIndex = 0;
            label1.Text = "Shopping Module";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 293);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 282);
            panel2.TabIndex = 32;
            panel2.Paint += panel2_Paint;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(38, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(38, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 152);
            label6.Name = "label6";
            label6.Size = new Size(159, 23);
            label6.TabIndex = 36;
            label6.Text = "Customer Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 79);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 35;
            label5.Text = "Customer Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 58, 138);
            label2.Location = new Point(10, 28);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 32;
            label2.Text = "Customer";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(dgv2);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btninsert);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textprod);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(1095, 578);
            panel3.TabIndex = 33;
            panel3.Paint += panel3_Paint;
            // 
            // dgv2
            // 
            dgv2.AllowUserToDeleteRows = false;
            dgv2.BackgroundColor = SystemColors.ControlLightLight;
            dgv2.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column1, Column3, Column4, Column6 });
            dgv2.GridColor = Color.FromArgb(30, 58, 138);
            dgv2.Location = new Point(0, 4);
            dgv2.Name = "dgv2";
            dgv2.ReadOnly = true;
            dgv2.RowHeadersWidth = 51;
            dgv2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv2.Size = new Size(1089, 283);
            dgv2.TabIndex = 6;
            dgv2.CellContentClick += dgv2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "product_id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 109;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MaxInputLength = 30;
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 78;
            // 
            // Column1
            // 
            Column1.HeaderText = "Quantity";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Description";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Category";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.FromArgb(30, 58, 138);
            btninsert.Font = new Font("Lucida Calligraphy", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.ForeColor = SystemColors.ButtonHighlight;
            btninsert.Location = new Point(791, 510);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(149, 53);
            btninsert.TabIndex = 47;
            btninsert.Text = "Add to cart";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(904, 369);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(170, 27);
            numericUpDown1.TabIndex = 46;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(904, 408);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(170, 27);
            textBox6.TabIndex = 45;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(904, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 27);
            textBox5.TabIndex = 44;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(360, 448);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(244, 27);
            textBox4.TabIndex = 43;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(360, 381);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(244, 27);
            textBox3.TabIndex = 39;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(362, 524);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(245, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(835, 406);
            label11.Name = "label11";
            label11.Size = new Size(64, 23);
            label11.TabIndex = 41;
            label11.Text = "Total :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(812, 371);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 40;
            label10.Text = "Quanity :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(835, 330);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 39;
            label4.Text = "Price :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(360, 489);
            label9.Name = "label9";
            label9.Size = new Size(116, 23);
            label9.TabIndex = 38;
            label9.Text = "Order Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(360, 422);
            label8.Name = "label8";
            label8.Size = new Size(144, 23);
            label8.TabIndex = 37;
            label8.Text = "Product Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(360, 349);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 36;
            label7.Text = "Product Id :";
            // 
            // textprod
            // 
            textprod.Location = new Point(751, 286);
            textprod.Name = "textprod";
            textprod.PlaceholderText = "Search Box";
            textprod.Size = new Size(323, 27);
            textprod.TabIndex = 34;
            textprod.TextChanged += textprod_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 58, 138);
            label3.Location = new Point(360, 310);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 33;
            label3.Text = "Product";
            // 
            // Ordermodule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 636);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Ordermodule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart module";
            Load += Ordermodule_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgv2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Label label2;
        private TextBox textprod;
        private Label label3;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private Label label10;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        public Button btninsert;
    }
}