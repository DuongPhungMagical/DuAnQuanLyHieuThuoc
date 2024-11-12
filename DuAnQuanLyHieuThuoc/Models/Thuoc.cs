using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class Thuoc
{
    public int Id { get; set; }

    public string TenThuoc { get; set; } = null!;

    public string DonViTinh { get; set; } = null!;

    public double GiaBan { get; set; }

    public int SoLuongTonKho { get; set; }

    public DateTime HanSuDung { get; set; }

    public string? MoTa { get; set; }

    public int? IdLoaiThuoc { get; set; }

    public int? IdHangSanXuat { get; set; }

    public int? IdNhaCungCap { get; set; }

    public virtual ICollection<ChiTietNhapKho> ChiTietNhapKhos { get; set; } = new List<ChiTietNhapKho>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual HangSanXuat? IdHangSanXuatNavigation { get; set; }

    public virtual LoaiThuoc? IdLoaiThuocNavigation { get; set; }

    public virtual NhaCungCap? IdNhaCungCapNavigation { get; set; }
}
