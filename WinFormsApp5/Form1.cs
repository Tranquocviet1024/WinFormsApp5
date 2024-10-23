using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
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
            string maSP = txtMa.Text; // Lấy mã sản phẩm từ TextBox
            string tenSP = txtTen.Text;
            decimal donGia;
            if (!decimal.TryParse(txtGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }
            string hinhAnh = txtAnh.Text;
            string moTaNgan = txtMotangan.Text;
            string moTaChiTiet = txtMotachitiet.Text;
            string? loaiSP = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(loaiSP))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                return;
            }
            SanPham sanPham = new()
            {
                MaSP = maSP,
                TenSP = tenSP,
                DonGia = donGia,
                HinhAnh = hinhAnh,
                MoTaNgan = moTaNgan,
                MoTaChiTiet = moTaChiTiet,
                LoaiSP = loaiSP,
            };

            // Thêm sản phẩm vào danh sách
            listsanpham.Add(sanPham);

            // Cập nhật lại DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listsanpham;

            MessageBox.Show("Sản phẩm đã được thêm.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rowIndex = dataGridView1.CurrentRow.Index;

                // Cập nhật thông tin sản phẩm trong danh sách
                listsanpham[rowIndex] = new SanPham
                {
                    MaSP = txtMa.Text,
                    TenSP = txtTen.Text,
                    DonGia = decimal.TryParse(txtGia.Text, out var price) ? price : 0,
                    HinhAnh = txtAnh.Text,
                    MoTaNgan = txtMotangan.Text,
                    MoTaChiTiet = txtMotachitiet.Text,
                    LoaiSP = comboBox1.SelectedItem?.ToString()
                };

                // Cập nhật lại DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listsanpham;

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
                // Lấy chỉ số hàng hiện tại
                int rowIndex = dataGridView1.CurrentRow.Index;

                // Kiểm tra chỉ số có hợp lệ hay không
                if (rowIndex >= 0 && rowIndex < listsanpham.Count)
                {
                    // Xóa sản phẩm khỏi danh sách
                    listsanpham.RemoveAt(rowIndex);

                    // Cập nhật lại DataGridView
                    dataGridView1.DataSource = null; // Đặt lại DataSource
                    dataGridView1.DataSource = listsanpham; // Cập nhật DataGridView

                    MessageBox.Show("Sản phẩm đã được xóa.");
                }
                else
                {
                    MessageBox.Show("Chỉ số không hợp lệ.");
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
