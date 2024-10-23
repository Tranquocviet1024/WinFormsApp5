
namespace WinFormsApp5
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            txtMotachitiet = new TextBox();
            label6 = new Label();
            txtMotangan = new TextBox();
            label5 = new Label();
            txtAnh = new TextBox();
            label4 = new Label();
            txtGia = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtMa = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnLammoi = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMotachitiet);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMotangan);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAnh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 343);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đồ Ăn", "Nước Uống ", "Loại Loại" });
            comboBox1.Location = new Point(130, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 27;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 306);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 26;
            label7.Text = "Loại";
            label7.Click += label7_Click_1;
            // 
            // txtMotachitiet
            // 
            txtMotachitiet.Location = new Point(130, 246);
            txtMotachitiet.Multiline = true;
            txtMotachitiet.Name = "txtMotachitiet";
            txtMotachitiet.Size = new Size(145, 43);
            txtMotachitiet.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 246);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 24;
            label6.Text = "Mô chi tiết";
            label6.Click += label6_Click;
            // 
            // txtMotangan
            // 
            txtMotangan.ForeColor = SystemColors.ActiveBorder;
            txtMotangan.Location = new Point(130, 205);
            txtMotangan.Name = "txtMotangan";
            txtMotangan.Size = new Size(146, 23);
            txtMotangan.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 213);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 22;
            label5.Text = "Mô tả ngắn";
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(130, 165);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(146, 23);
            txtAnh.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 165);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 20;
            label4.Text = "Hình Ảnh";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(130, 115);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(146, 23);
            txtGia.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 123);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 18;
            label3.Text = "Đơn Giá";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(130, 68);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(146, 23);
            txtTen.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 74);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 16;
            label2.Text = "Ten SP";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(130, 25);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(100, 23);
            txtMa.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 14;
            label1.Text = "Ma SP";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnLammoi);
            groupBox2.Location = new Point(12, 361);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 77);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(252, 33);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(169, 33);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(88, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(7, 33);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(75, 23);
            btnLammoi.TabIndex = 4;
            btnLammoi.Text = "Làm Mới";
            btnLammoi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(btnTimKiem);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(351, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 426);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(6, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(516, 352);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "MaSP";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn Giá";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Hình Ảnh";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Mô tả ngắn";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Mô tả chi tiết";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Loại";
            Column7.Name = "Column7";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(115, 22);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(282, 23);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(419, 22);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 23);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button1_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(35, 30);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 3;
            label9.Text = "Tìm kiếm :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox txtMotachitiet;
        private Label label6;
        private TextBox txtMotangan;
        private Label label5;
        private TextBox txtAnh;
        private Label label4;
        private TextBox txtGia;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMa;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnLammoi;
        private GroupBox groupBox3;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
