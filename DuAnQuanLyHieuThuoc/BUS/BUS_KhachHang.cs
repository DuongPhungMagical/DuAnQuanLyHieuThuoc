using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.BUS
{
    public class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;
        private readonly DataContext _context;
        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
            _context = new DataContext();
        }
        public async void LoadDanhSach(DataGridView dgv)
        {
            var danhSach = await dKhachHang.LoadDanhSachKhachHang();
            dgv.DataSource = danhSach.Select(x => new
            {
                x.Id,
                x.TenKhachHang,
                x.Tuoi,
                x.SoDienThoai,
                x.DiaChi
            }).ToList();
            dgv.Columns["Id"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public async Task<bool> ThemKhachHang(KhachHang khachHang)
        {
            return await dKhachHang.ThemKhachHang(khachHang);
        }
        public async Task<bool> SuaKhachHang(KhachHang khachHang)
        {
            try
            {
                var khachHangMoi = _context.KhachHangs.FirstOrDefault(x => x.Id == khachHang.Id);
                if (khachHangMoi != null)
                {
                    khachHangMoi.TenKhachHang = khachHang.TenKhachHang;
                    khachHangMoi.Tuoi = khachHang.Tuoi;
                    khachHangMoi.SoDienThoai = khachHang.SoDienThoai;
                    khachHangMoi.DiaChi = khachHang.DiaChi;
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                return false;
            }
        }
    }
}
