using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_ThanhToan
    {
        private readonly DataContext _context;
        public DAO_ThanhToan()
        {
            _context = new DataContext();
        }
        public async Task<int> AddHoadDon(HoaDon hoaDon)
        {
            await _context.HoaDons.AddAsync(hoaDon);
            await _context.SaveChangesAsync();
            return hoaDon.Id;
        }
        public async Task HoaDonChiTiet(HoaDonChiTiet hdct)
        {
            await _context.HoaDonChiTiets.AddAsync(hdct);
            await _context.SaveChangesAsync();
        }
        public async Task<Thuoc?> GetThuocById(int id)
        {
            return await _context.Thuocs.FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task ExecuteInTransactionAsync(Func<Task> action)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                await action();
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

    }
}
