using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_BanHang
    {
        private readonly DataContext _context;
        public DAO_BanHang()
        {
            _context = new DataContext();
        }
        public async Task<List<Thuoc>> LoadDanhSachThuoc()
        {
            var danhSach = await _context.Thuocs.ToListAsync();
            return danhSach;
        }
        public async Task<Thuoc> GetThuocByName(string tenThuoc)
        {
            return await _context.Thuocs.FirstOrDefaultAsync(x => x.TenThuoc == tenThuoc);          
        }
        public int GetSoLuongTonKho(string tenThuoc)
        {
            return _context.Thuocs
                .Where(x => x.TenThuoc == tenThuoc)
                .Select(x => x.SoLuongTonKho)
                .FirstOrDefault();
        }
    }
}
