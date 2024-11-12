using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class ChiTietNhapKho
{
    public int Id { get; set; }

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    public DateTime NgayNhap { get; set; }

    public double ThanhTien { get; set; }

    public int? IdThuoc { get; set; }

    public int? IdNhapKho { get; set; }

    public virtual NhapKho? IdNhapKhoNavigation { get; set; }

    public virtual Thuoc? IdThuocNavigation { get; set; }
}
