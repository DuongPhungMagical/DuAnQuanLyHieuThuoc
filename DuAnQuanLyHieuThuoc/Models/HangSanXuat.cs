using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class HangSanXuat
{
    public int Id { get; set; }

    public string TenHangSanXuat { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public virtual ICollection<Thuoc> Thuocs { get; set; } = new List<Thuoc>();
}
