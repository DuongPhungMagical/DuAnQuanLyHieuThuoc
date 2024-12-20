using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_DangKi
    {
        private readonly DataContext _context;
        public DAO_DangKi()
        {
            _context = new DataContext();
        }
        public async Task<bool> TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                var check = _context.TaiKhoans.FirstOrDefault(x => x.Email == taiKhoan.TenTaiKhoan);
                if (check == null)
                {
                    _context.TaiKhoans.Add(taiKhoan);
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
