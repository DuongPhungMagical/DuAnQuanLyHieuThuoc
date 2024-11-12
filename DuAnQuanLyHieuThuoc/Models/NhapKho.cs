using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class NhapKho
{
    public int Id { get; set; }

    public DateTime NgayNhap { get; set; }

    public int? IdNhanVien { get; set; }

    public int? IdNhaCungCap { get; set; }

    public virtual ICollection<ChiTietNhapKho> ChiTietNhapKhos { get; set; } = new List<ChiTietNhapKho>();

    public virtual NhaCungCap? IdNhaCungCapNavigation { get; set; }

    public virtual NhanVien? IdNhanVienNavigation { get; set; }
}
