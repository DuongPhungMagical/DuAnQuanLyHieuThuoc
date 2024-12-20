using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAnQuanLyHieuThuoc.BUS
{
    public class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;
        private readonly DataContext _context;
        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
            _context = new DataContext();
        }
        public async void LoadDanhSachNhanVien(DataGridView dgv)
        {
            var danhSachNhanVien = await dNhanVien.LoadDanhSachNhanVien();
            dgv.DataSource = danhSachNhanVien.Select(x => new
            {
                x.Id,
                x.TenNhanVien,
                x.NgayVaoLam,
                x.Tuoi,
                x.DiaChi,
                x.SoDienThoai,
                TrangThai = x.IdTrangThaiNavigation?.TrangThai1 ?? "chua cap nhat"
            }).ToList();
            dgv.Columns["Id"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public async Task LoadTrangThai(ComboBox comboBox)
        {
            comboBox.DataSource = await dNhanVien.LoadTrangThai();
            comboBox.DisplayMember = "TrangThai1";
            comboBox.ValueMember = "Id";
        }

        public async Task<bool> ThemNhanVien(NhanVien nhanVien)
        {
            return await dNhanVien.ThemNhanVien(nhanVien);
        }
        public async Task<bool> SuaNhanVien(NhanVien nhanVien)
        {
            try
            {
                var nvMoi = _context.NhanViens.FirstOrDefault(x => x.Id == nhanVien.Id);
                if (nvMoi != null)
                {
                    nvMoi.TenNhanVien = nhanVien.TenNhanVien;
                    nvMoi.DiaChi = nhanVien.DiaChi;
                    nvMoi.Tuoi = nhanVien.Tuoi;
                    nvMoi.NgayVaoLam = nhanVien.NgayVaoLam;
                    nvMoi.SoDienThoai = nhanVien.SoDienThoai;
                    nvMoi.IdTrangThai = nhanVien.IdTrangThai;
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
        public async Task<bool> XoaThuoc(int id)
        {
            dNhanVien.XoaNhanVien(id);
            return true;
        }
    }
}
