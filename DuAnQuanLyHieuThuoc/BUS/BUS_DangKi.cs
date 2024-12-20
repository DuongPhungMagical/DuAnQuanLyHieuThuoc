using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.BUS
{
    public class BUS_DangKi
    {
        DAO_DangKi dDangKi;
        public BUS_DangKi()
        {
            dDangKi = new DAO_DangKi();
        }
        public async Task<bool> TaoTaiKhoan(TaiKhoan taiKhoan)
        {
            return await dDangKi.TaoTaiKhoan(taiKhoan);

        }
    }
}
