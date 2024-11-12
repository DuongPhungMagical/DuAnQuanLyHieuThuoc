using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class NhaCungCap
{
    public int Id { get; set; }

    public string TenNhaCungCap { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public virtual ICollection<NhapKho> NhapKhos { get; set; } = new List<NhapKho>();

    public virtual ICollection<Thuoc> Thuocs { get; set; } = new List<Thuoc>();
}
