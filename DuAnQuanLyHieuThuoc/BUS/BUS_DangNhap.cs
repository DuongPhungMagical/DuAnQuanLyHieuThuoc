using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.BUS
{
    public class BUS_DangNhap
    {
        DAO_DangNhap dDangNhap;
        public BUS_DangNhap()
        {
            dDangNhap = new DAO_DangNhap();
        }
        public async Task<string> DangNhap(string taiKhoan,string matKhau)
        {
            string result = await dDangNhap.DangNhap(taiKhoan,matKhau);
            return result;  
        }
    }
}
