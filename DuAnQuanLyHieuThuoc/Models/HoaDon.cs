using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class HoaDon
{
    public int Id { get; set; }

    public DateTime NgayLap { get; set; }

    public double TongTien { get; set; }

    public string HinhThucThanhToan { get; set; } = null!;

    public string TrangThai { get; set; } = null!;

    public int? IdNhanVien { get; set; }

    public int? IdKhachHang { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? IdKhachHangNavigation { get; set; }

    public virtual NhanVien? IdNhanVienNavigation { get; set; }
}
