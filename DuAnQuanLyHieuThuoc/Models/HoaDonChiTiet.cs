using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class HoaDonChiTiet
{
    public int Id { get; set; }

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    public double ThanhTien { get; set; }

    public string? GhiChu { get; set; }

    public int? IdHoaDon { get; set; }

    public int? IdThuoc { get; set; }

    public virtual HoaDon? IdHoaDonNavigation { get; set; }

    public virtual Thuoc? IdThuocNavigation { get; set; }
}
