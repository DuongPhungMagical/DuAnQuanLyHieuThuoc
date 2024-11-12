using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class Voucher
{
    public int Id { get; set; }

    public string TenVoucher { get; set; } = null!;

    public decimal PhanTramGiam { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public int SoLuong { get; set; }
}
