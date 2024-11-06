using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    public class LoaiSP
    {
        public string Maloai { get; set; } // Mã sản phẩm, không thể null vì nó là khóa chính
        public string Tenloai { get; set; }

        public LoaiSP(string ma,string ten) 
        {
             Maloai=ma;
            Tenloai = ten;
        }
    }
}
