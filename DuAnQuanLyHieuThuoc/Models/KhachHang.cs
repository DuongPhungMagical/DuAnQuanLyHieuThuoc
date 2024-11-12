using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class KhachHang
{
    public int Id { get; set; }

    public string TenKhachHang { get; set; } = null!;

    public int Tuoi { get; set; }

    public string SoDienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
