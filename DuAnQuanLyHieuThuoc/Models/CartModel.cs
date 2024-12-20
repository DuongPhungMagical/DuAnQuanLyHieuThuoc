using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.Models
{
    public class CartModel
    {
        public string TenThuoc { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }
        public float TongTien { get; set; }
        public string? SDT { get; set; }
        public string? TenKhachHang { get; set; }
    }
}
