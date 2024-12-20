using DuAnQuanLyHieuThuoc.DAO;
using DuAnQuanLyHieuThuoc.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DuAnQuanLyHieuThuoc.BUS
{
    public class BUS_Thuoc
    {
        DAO_Thuoc dThuoc;
        private readonly DataContext _context;
        public BUS_Thuoc()
        {
            dThuoc = new DAO_Thuoc();
            _context = new DataContext();
        }
        public async void LoadThuocVaoDataGridView(DataGridView dgv)
        {
            var danhSachThuoc = await dThuoc.GetDanhSachThuoc();

            // Đưa dữ liệu vào DataGridView
            dgv.DataSource = danhSachThuoc.Select(t => new
            {
                t.Id,
                t.TenThuoc,
                t.DonViTinh,
                t.GiaBan,
                t.SoLuongTonKho,
                t.HanSuDung,
                t.MoTa,
                TenLoaiThuoc = t.IdLoaiThuocNavigation?.TenLoaiThuoc,
                TenHangSanXuat = t.IdHangSanXuatNavigation?.TenHangSanXuat,
                TenNhaCungCap = t.IdNhaCungCapNavigation?.TenNhaCungCap
            }).ToList();
            dgv.Columns["Id"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public async Task LoadNhaCungCap(ComboBox comboBox)
        {
            var nhaCungCapList = await dThuoc.GetNhaCungCap();
            comboBox.DataSource = nhaCungCapList;
            comboBox.DisplayMember = "TenNhaCungCap"; //hiển thị tên nhà cung cấp
            comboBox.ValueMember = "Id"; // lấy Id khi chọn
        }
        public async Task LoadLoaiThuoc(ComboBox comboBox)
        {
            var loaiThuocList = await dThuoc.GetLoaiThuoc();
            comboBox.DataSource = loaiThuocList;
            comboBox.DisplayMember = "TenLoaiThuoc";
            comboBox.ValueMember = "Id";
        }
        public async Task<bool> ThemThuoc(Thuoc newThuoc)
        {
            return await dThuoc.ThemThuoc(newThuoc);
        }
        public async Task<bool> SuaThuoc(Thuoc newThuoc)
        {
            try
            {
                var thuocSua = _context.Thuocs.FirstOrDefault(x => x.Id == newThuoc.Id);
                if (thuocSua != null)
                {
                    thuocSua.TenThuoc = newThuoc.TenThuoc;
                    thuocSua.DonViTinh = newThuoc.DonViTinh;
                    thuocSua.GiaBan = newThuoc.GiaBan;
                    thuocSua.SoLuongTonKho = newThuoc.SoLuongTonKho;
                    thuocSua.HanSuDung = newThuoc.HanSuDung;
                    thuocSua.MoTa = newThuoc.MoTa;
                    thuocSua.IdNhaCungCap = newThuoc.IdNhaCungCap;
                    thuocSua.IdHangSanXuat = newThuoc.IdHangSanXuat;
                    thuocSua.IdLoaiThuoc = newThuoc.IdLoaiThuoc;

                    // Lưu thay đổi vào cơ sở dữ liệu
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
            try
            {
                var check = _context.Thuocs.FirstOrDefault(x => x.Id == id);
                if(check != null)
                {
                    _context.Thuocs.Remove(check);
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
        public async Task LoadHangSanXuat(ComboBox comboBox)
        {
            var hangSXList = await dThuoc.GetHangSanXat();
            comboBox.DataSource = hangSXList;
            comboBox.DisplayMember = "TenHangSanXuat";
            comboBox.ValueMember = "Id";
        }
        public List<Thuoc> TimThuoc(string tenThuoc)
        {
            return dThuoc.TimThuoc(tenThuoc);
        }
    }
}
