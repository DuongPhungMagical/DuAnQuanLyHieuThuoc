using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_NhanVien
    {
        private readonly DataContext _context;
        public DAO_NhanVien()
        {
            _context = new DataContext();
        }
        public async Task<List<NhanVien>> LoadDanhSachNhanVien()
        {
            var danhSach = await _context.NhanViens
                .Include(x => x.IdTrangThaiNavigation)
                .ToListAsync();
            return danhSach;
        }
        public async Task<List<TrangThai>> LoadTrangThai()
        {
            using(var context = new DataContext())
            {
                var danhSach = await context.TrangThais.ToListAsync();
                return danhSach;
            }
           
        }
        public async Task<bool> ThemNhanVien(NhanVien nhanVien)
        {
            try
            {
                _context.NhanViens.Add(nhanVien);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> SuaNhanVien(NhanVien nhanVien)
        {
            try
            {
                _context.NhanViens.Update(nhanVien);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> XoaNhanVien(int id)
        {
            try
            {
                var check = _context.NhanViens.FirstOrDefault(x => x.Id == id);
                if(check != null)
                {
                    _context.NhanViens.Remove(check);
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
