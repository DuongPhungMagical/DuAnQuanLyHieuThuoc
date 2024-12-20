using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.DAO
{
    public class DAO_DangNhap
    {
        private readonly DataContext _context;
        public DAO_DangNhap()
        {
            _context = new DataContext();
        }
        public async Task<string> DangNhap(string taiKhoan, string matKhau)
        {
            try
            {
                var check = await _context.TaiKhoans.FirstOrDefaultAsync(x => x.TenTaiKhoan == taiKhoan);
                if(check == null)
                {
                    return "Tên tài khoản không tồn tại.";
                }
                if(matKhau != check.MatKhau)
                {
                    return "Mật khẩu không chính xác.";
                }
                return "Đăng nhập thành công!";
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (nếu cần)
                Console.WriteLine($"Lỗi đăng nhập: {ex.Message}");
                return "Đã xảy ra lỗi trong quá trình đăng nhập.";
            }
        }

    }
}
