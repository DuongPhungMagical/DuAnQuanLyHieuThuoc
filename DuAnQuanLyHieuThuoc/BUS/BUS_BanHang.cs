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
    public class BUS_BanHang
    {
        private readonly List<CartModel> cart;
        DAO_BanHang dBanHang;
        public BUS_BanHang()
        {
            dBanHang = new DAO_BanHang();
            cart = new List<CartModel>();
        }
        public async void LoadDanhSach(ListBox lb)
        {
            var danhSach = await dBanHang.LoadDanhSachThuoc();
            lb.DataSource = danhSach.Select(x => x.TenThuoc).ToList();
        }
        public async Task<Thuoc> GetThuocByName(string tenThuoc)
        {
            return await dBanHang.GetThuocByName(tenThuoc);
        }
        public List<CartModel> GetCart()
        {
            return cart;
        }

        public bool AddToCart(string tenThuoc, float donGia, int soLuong, string tenKhachHang, string sdt, out string errorMessage)
        {
            errorMessage = string.Empty;

            // Kiểm tra số lượng tồn kho
            int soLuongTonKho = dBanHang.GetSoLuongTonKho(tenThuoc);
            if (soLuong > soLuongTonKho)
            {
                errorMessage = "Số lượng không đủ để bán.";
                return false;
            }

            // Tìm sản phẩm trong giỏ hàng
            var existingItem = cart.FirstOrDefault(c => c.TenThuoc == tenThuoc);
            if (existingItem != null)
            {
                existingItem.SoLuong += soLuong;
                existingItem.TongTien = existingItem.SoLuong * donGia;
            }
            else
            {
                cart.Add(new CartModel
                {
                    TenThuoc = tenThuoc,
                    DonGia = donGia,
                    SoLuong = soLuong,
                    TongTien = donGia * soLuong,
                    TenKhachHang = tenKhachHang,
                    SDT = sdt
                });
            }

            return true;
        }

        public float CalculateTotalPrice()
        {
            return cart.Sum(item => item.TongTien);
        }

        //public async Task<bool> TaoHoaDon(List<CartModel> cart,HoaDon hoaDon)
        //{
        //    using(var transaction = await dBanHang)
        //}
        
    }
}
