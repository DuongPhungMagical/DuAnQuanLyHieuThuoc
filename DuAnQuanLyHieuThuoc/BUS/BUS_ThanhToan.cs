using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace DuAnQuanLyHieuThuoc.BUS
{
    public class BUS_ThanhToan
    {
        DAO_ThanhToan dThanhToan;
        public BUS_ThanhToan()
        {
            dThanhToan = new DAO_ThanhToan();
        }
        public async Task<bool> TaoHoaDonAsync(List<CartModel> cart, HoaDon hoaDon)
        {
            // Kiểm tra nếu không có sản phẩm trong giỏ hàng
            if (cart == null || !cart.Any())
            {
                throw new Exception("Giỏ hàng rỗng, không thể tạo hóa đơn.");
            }

            await dThanhToan.ExecuteInTransactionAsync(async () =>
            {
                // 1. Thêm hóa đơn
                int hoaDonId = await dThanhToan.AddHoadDon(hoaDon);

                // 2. Thêm chi tiết hóa đơn
                foreach (var item in cart)
                {
                    var hoaDonChiTiet = new HoaDonChiTiet
                    {
                        IdHoaDon = hoaDonId,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        ThanhTien = item.TongTien
                    };
                    await dThanhToan.HoaDonChiTiet(hoaDonChiTiet);
                }
            });

            return true;
        }
    }
}
