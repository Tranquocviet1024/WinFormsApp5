using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetData();
        }
        public void GetData()
        {
            try
            {
                string query = "select * from LoaiSanPham";
                DataSet ds = kn.LayDuLieu(query);
                dgvSanPham.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu sản phẩm: " + ex.Message);
            }
           
        }
        


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into LoaiSanPham VALUES('{0}', N'{1}', {2}, N'{3}', N'{4}', N'{5}', '{6}')",
                            txtMa.Text,
                            txtTen.Text,
                            txtGia.Text,
                            txtAnh.Text,
                            txtMotangan.Text,
                            txtMotachitiet.Text
                            
                );
                if (kn.ThucThi(query) == true)
                {
                    btnLammoi.PerformClick();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu loại sản phẩm: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "UPDATE LoaiSanPham SET TenSP = N'{0}', DonGia = {1}, HinhAnh = N'{2}', MoTaNgan = N'{3}', MoTaChiTiet = N'{4}',  WHERE MaSP = '{5}'",
                txtTen.Text,
                txtGia.Text,
                txtAnh.Text,
                txtMotangan.Text,
                txtMotachitiet.Text,
               
                txtMa.Text
            );

            if (kn.ThucThi(query) == true)
            {
                btnLammoi.PerformClick();
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from loaiSanPham where MaSP = '{0}'",
                txtMa.Text
            );
            if (kn.ThucThi(query) == true)
            {
                btnLammoi.PerformClick();
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
           
            MessageBox.Show("Đã làm mới thông tin.");
            GetData();
        }

        private void btnLammoi_Click_1(object sender, EventArgs e)
        {

        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int r = e.RowIndex;
            if (r >= 0)
            {
                
                txtMa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;


                txtMa.Text = dgvSanPham.Rows[r].Cells["MaSP"].Value.ToString();
                txtTen.Text = dgvSanPham.Rows[r].Cells["TenSP"].Value.ToString();
                txtGia.Text = dgvSanPham.Rows[r].Cells["DonGia"].Value.ToString();
                txtAnh.Text = dgvSanPham.Rows[r].Cells["HinhAnh"].Value.ToString();
                txtMotangan.Text = dgvSanPham.Rows[r].Cells["MoTaNgan"].Value.ToString();
                txtMotachitiet.Text = dgvSanPham.Rows[r].Cells["MoTaChiTiet"].Value.ToString();
                            }
        }

    }


}
