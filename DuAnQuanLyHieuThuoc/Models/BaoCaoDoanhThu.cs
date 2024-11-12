using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class BaoCaoDoanhThu
{
    public int Id { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public double TongDoanhThu { get; set; }

    public double TongChiPhi { get; set; }

    public double LoiNhuan { get; set; }
}
