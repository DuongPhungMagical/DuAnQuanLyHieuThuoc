using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class TaiKhoan
{
    public int Id { get; set; }

    public string TenTaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int? IdNhanVien { get; set; }

    public string? TrangThai { get; set; }

    public string? Email { get; set; }

    public string? VaiTro { get; set; }

    public virtual NhanVien? IdNhanVienNavigation { get; set; }
}
