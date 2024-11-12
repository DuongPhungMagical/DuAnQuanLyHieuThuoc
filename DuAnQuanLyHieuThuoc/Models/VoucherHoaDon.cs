using System;
using System.Collections.Generic;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class VoucherHoaDon
{
    public double GiaTriGiam { get; set; }

    public int? IdHoaDon { get; set; }

    public int? IdVoucher { get; set; }

    public virtual HoaDon? IdHoaDonNavigation { get; set; }

    public virtual Voucher? IdVoucherNavigation { get; set; }
}
