using System;

namespace WinFormsApp5
{
    public class SanPham
    {
        // Các thuộc tính có thể là null (ví dụ như chuỗi)
        public string MaSP { get; set; } // Mã sản phẩm, không thể null vì nó là khóa chính
        public string TenSP { get; set; } // Tên sản phẩm
        public decimal DonGia { get; set; } // Đơn giá, không thể null
        public string HinhAnh { get; set; } // Đường dẫn hình ảnh, có thể null
        public string MoTaNgan { get; set; } // Mô tả ngắn gọn, có thể null
        public string MoTaChiTiet { get; set; } // Mô tả chi tiết, có thể null
        public string LoaiSP { get; set; } // Loại sản phẩm, có thể null

        // Constructor để tạo mới đối tượng nếu cần thiết
        public SanPham(string maSP, string tenSP, decimal donGia, string hinhAnh = "", string moTaNgan = "", string moTaChiTiet = "", string loaiSP = "")
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            HinhAnh = hinhAnh;
            MoTaNgan = moTaNgan;
            MoTaChiTiet = moTaChiTiet;
            LoaiSP = loaiSP;
        }

        // Phương thức để kiểm tra tính hợp lệ của sản phẩm
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(MaSP) && !string.IsNullOrEmpty(TenSP) && DonGia > 0;
        }
    }
}
