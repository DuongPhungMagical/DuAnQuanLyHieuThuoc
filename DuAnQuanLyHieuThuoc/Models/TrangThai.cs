using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class TrangThai
{
    public int Id { get; set; }

    public string? TrangThai1 { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
