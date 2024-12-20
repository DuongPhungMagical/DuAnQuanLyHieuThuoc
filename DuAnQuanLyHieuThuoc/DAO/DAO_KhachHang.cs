using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_KhachHang
    {
        private readonly DataContext _context;
        public DAO_KhachHang()
        {
            _context = new DataContext();
        }
        public async Task<List<KhachHang>> LoadDanhSachKhachHang()
        {
            var danhSach = await _context.KhachHangs.ToListAsync();
            return danhSach;
        }
        public async Task<bool> ThemKhachHang(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Add(khachHang);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> SuaKhachHang(KhachHang khachHang)
        {
            try
            {
                _context.KhachHangs.Update(khachHang);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
