using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class LoaiThuoc
{
    public int Id { get; set; }

    public string TenLoaiThuoc { get; set; } = null!;

    public virtual ICollection<Thuoc> Thuocs { get; set; } = new List<Thuoc>();
}
