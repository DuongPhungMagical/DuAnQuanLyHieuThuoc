using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_Thuoc
    {
        private readonly DataContext _context;
        public DAO_Thuoc()
        {
            _context = new DataContext();
        }
        //lay danh sach thuoc
        public async Task<List<Thuoc>> GetDanhSachThuoc()
        {
            var danhSachThuoc = await _context.Thuocs
                .Include(t => t.IdLoaiThuocNavigation)         // Include bảng LoaiThuoc
                .Include(t => t.IdHangSanXuatNavigation)       // Include bảng HangSanXuat
                .Include(t => t.IdNhaCungCapNavigation)        // Include bảng NhaCungCap
                .ToListAsync();

            return danhSachThuoc;
        }
        //lay nha cung cap
        public async Task<List<NhaCungCap>> GetNhaCungCap()
        {
            using( var context = new DataContext())
            {
                var nhaCungCap = await context.NhaCungCaps.ToListAsync();
                return nhaCungCap;
            }
        }
        //lay loai thuoc
        public async Task<List<LoaiThuoc>> GetLoaiThuoc()
        {
            using(var context = new DataContext())
            {
                var loaiThuoc = await context.LoaiThuocs.ToListAsync();
                return loaiThuoc;
            }
        }
        //lay hang san xuat
        public async Task<List<HangSanXuat>> GetHangSanXat()
        {
            using (var context = new DataContext())
            {
                var hangSX = await context.HangSanXuats.ToListAsync();
                return hangSX;
            }
        }
        //them thuoc
        public async Task<bool> ThemThuoc(Thuoc newThuoc)
        {
            try
            {
                _context.Thuocs.Add(newThuoc);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //sua thuoc
        public async Task<bool> SuaThuoc(Thuoc newThuoc)
        {
            try
            {
                _context.Thuocs.Update(newThuoc);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Thuoc> TimThuoc(string tenThuoc)
        {
            var danhSachThuoc = _context.Thuocs
                .Include(t => t.IdLoaiThuocNavigation)         // Include bảng LoaiThuoc
                .Include(t => t.IdHangSanXuatNavigation)       // Include bảng HangSanXuat
                .Include(t => t.IdNhaCungCapNavigation)        // Include bảng NhaCungCap
                .Where(t => t.TenThuoc.Contains(tenThuoc))
            .ToList();

            return danhSachThuoc;
        }

    }
}
