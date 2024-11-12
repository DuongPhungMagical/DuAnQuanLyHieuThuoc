using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class NhanVien
{
    public int Id { get; set; }

    public string TenNhanVien { get; set; } = null!;

    public int Tuoi { get; set; }

    public string SoDienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public DateTime NgayVaoLam { get; set; }

    public int? IdTrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual TrangThai? IdTrangThaiNavigation { get; set; }

    public virtual ICollection<NhapKho> NhapKhos { get; set; } = new List<NhapKho>();

    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();
}
