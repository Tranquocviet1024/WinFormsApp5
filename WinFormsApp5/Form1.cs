using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private List<SanPham> listsanpham = new List<SanPham>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataGridView với danh sách sản phẩm ban đầu (rỗng)
            dataGridView1.DataSource = listsanpham;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham
            {
                MaSP = txtMa.Text,
                TenSP = txtTen.Text,
                DonGia = decimal.TryParse(txtGia.Text, out var price) ? price : 0,
                HinhAnh = txtAnh.Text,
                MoTaNgan = txtMotangan.Text,
                MoTaChiTiet = txtMotachitiet.Text,
                LoaiSP = comboBox1.SelectedItem?.ToString()
            };

            // Thêm sản phẩm vào DataGridView
            dataGridView1.Rows.Add(sanPham.MaSP, sanPham.TenSP, sanPham.DonGia, sanPham.HinhAnh, sanPham.MoTaNgan, sanPham.MoTaChiTiet, sanPham.LoaiSP);
            MessageBox.Show("Sản phẩm đã được thêm.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = dataGridView1.CurrentRow;
                row.Cells[0].Value = txtMa.Text;
                row.Cells[1].Value = txtTen.Text;
                row.Cells[2].Value = decimal.TryParse(txtGia.Text, out var price) ? price : 0;
                row.Cells[3].Value = txtAnh.Text;
                row.Cells[4].Value = txtMotangan.Text;
                row.Cells[5].Value = txtMotachitiet.Text;
                row.Cells[6].Value = comboBox1.SelectedItem?.ToString();

                MessageBox.Show("Sản phẩm đã được sửa.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedProduct = dataGridView1.CurrentRow.DataBoundItem as SanPham;
                if (selectedProduct != null)
                {
                    listsanpham.Remove(selectedProduct);
                    dataGridView1.DataSource = null; // Đặt lại DataSource
                    dataGridView1.DataSource = listsanpham; // Cập nhật DataGridView
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtGia.Clear();
            txtAnh.Clear();
            txtMotangan.Clear();
            txtMotachitiet.Clear();
            comboBox1.SelectedIndex = -1;
            MessageBox.Show("Đã làm mới thông tin.");
        }
    }

    }
