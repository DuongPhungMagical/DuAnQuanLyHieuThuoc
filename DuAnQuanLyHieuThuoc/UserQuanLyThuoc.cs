using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserQuanLyThuoc : UserControl
    {
        private readonly DataContext _context;
        public UserQuanLyThuoc()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private string textPlaceholder = "Tìm kiếm thuốc";
        private Color colorHolder = Color.Gray;

        private async void UserQuanLyThuoc_Load(object sender, EventArgs e)
        {
            SetPlaceholder();
            await ShowThuocAsync();
            await ShowLoaiHangNhaAsync();
        }

        private void SetPlaceholder()
        {
            txtTimKiem.Text = textPlaceholder;
            txtTimKiem.ForeColor = Color.Black;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == textPlaceholder)
            {
                txtTimKiem.Text = "";
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                SetPlaceholder();
            }
        }

        private async Task ShowThuocAsync()
        {
            var showThuoc = await _context.Thuocs
                .Join(_context.LoaiThuocs, thuoc => thuoc.IdLoaiThuoc, x => x.Id, (thuoc, x) => new { thuoc, x })
                .Join(_context.HangSanXuats, a => a.thuoc.IdHangSanXuat, b => b.Id, (a, b) => new { a, b })
                .Join(_context.NhaCungCaps, c => c.a.thuoc.IdNhaCungCap, z => z.Id, (c, z) => new
                {
                    c.a.thuoc.TenThuoc,
                    c.a.thuoc.DonViTinh,
                    c.a.thuoc.GiaBan,
                    c.a.thuoc.SoLuongTonKho,
                    c.a.thuoc.HanSuDung,
                    c.a.thuoc.MoTa,
                    c.a.x.TenLoaiThuoc,
                    c.b.TenHangSanXuat,
                    z.TenNhaCungCap
                }).ToListAsync();

            dgvThuoc.DataSource = showThuoc;
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async Task ShowLoaiHangNhaAsync()
        {
            var loai = await _context.LoaiThuocs.ToListAsync();
            cbLoaiThuoc.DataSource = loai;
            cbLoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cbLoaiThuoc.ValueMember = "Id";

            var hang = await _context.HangSanXuats.ToListAsync();
            cbHangSanXuat.DataSource = hang;
            cbHangSanXuat.DisplayMember = "TenHangSanXuat";
            cbHangSanXuat.ValueMember = "Id";

            var cc = await _context.NhaCungCaps.ToListAsync();
            cbNhaCungCap.DataSource = cc;
            cbNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbNhaCungCap.ValueMember = "Id";
        }

        private bool ValidateGiaTien(string giaBan)
        {
            if (double.TryParse(giaBan, out double result))
            {
                return result >= 0;
            }
            MessageBox.Show("Giá bán không hợp lệ", "Thông báo", MessageBoxButtons.OK);
            return false;
        }

        private bool ValidateSltk(string sl)
        {
            if (int.TryParse(sl, out int result))
            {
                return result >= 0;
            }
            MessageBox.Show("Số lượng tồn kho không hợp lệ", "Thông báo", MessageBoxButtons.OK);
            return false;
        }

        private bool ValidateTenDonViGMoTa()
        {
            if (string.IsNullOrWhiteSpace(txtTenThuoc.Text) || string.IsNullOrEmpty(txtDonViTinh.Text) || string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private async void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (!ValidateTenDonViGMoTa() || !ValidateGiaTien(txtGiaBan.Text) || !ValidateSltk(txtSoLuongTonKho.Text))
            {
                return;
            }

            Thuoc thuoc = new Thuoc
            {
                TenThuoc = txtTenThuoc.Text,
                MoTa = txtMoTa.Text,
                DonViTinh = txtDonViTinh.Text,
                HanSuDung = dtpHanSuDung.Value,
                IdLoaiThuoc = (int)cbLoaiThuoc.SelectedValue,
                IdNhaCungCap = (int)cbNhaCungCap.SelectedValue,
                IdHangSanXuat = (int)cbHangSanXuat.SelectedValue,
                GiaBan = double.Parse(txtGiaBan.Text),
                SoLuongTonKho = int.Parse(txtSoLuongTonKho.Text)
            };

            await _context.Thuocs.AddAsync(thuoc);
            await _context.SaveChangesAsync();
            await ShowThuocAsync();

            MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private async void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            var suaThuoc = await _context.Thuocs.FirstOrDefaultAsync(x => x.Id == int.Parse(lblMaNhanVien.Text));

            if (suaThuoc == null || !ValidateTenDonViGMoTa() || !ValidateGiaTien(txtGiaBan.Text) || !ValidateSltk(txtSoLuongTonKho.Text))
            {
                return;
            }

            SetThuoc(suaThuoc);

            if (MessageBox.Show("Bạn có chắc chắn muốn sửa thuốc?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await _context.SaveChangesAsync();
                MessageBox.Show("Thành công!!", "Thông báo", MessageBoxButtons.OK);
                await ShowThuocAsync();
            }
        }

        private async void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var xoaThuoc = await _context.Thuocs.FirstOrDefaultAsync(x => x.Id == int.Parse(lblMaNhanVien.Text));

                if (xoaThuoc != null)
                {
                    _context.Thuocs.Remove(xoaThuoc);
                    await _context.SaveChangesAsync();
                    MessageBox.Show("Xóa thuốc thành công", "Thông báo", MessageBoxButtons.OK);
                    await ShowThuocAsync();
                }
            }
        }

        private void SetThuoc(Thuoc thuoc)
        {
            thuoc.TenThuoc = txtTenThuoc.Text;
            thuoc.DonViTinh = txtDonViTinh.Text;
            thuoc.MoTa = txtMoTa.Text;
            thuoc.HanSuDung = dtpHanSuDung.Value;
            thuoc.IdLoaiThuoc = (int)cbLoaiThuoc.SelectedValue;
            thuoc.IdNhaCungCap = (int)cbNhaCungCap.SelectedValue;
            thuoc.IdHangSanXuat = (int)cbHangSanXuat.SelectedValue;

            if (ValidateGiaTien(txtGiaBan.Text))
            {
                thuoc.GiaBan = double.Parse(txtGiaBan.Text);
            }

            if (ValidateSltk(txtSoLuongTonKho.Text))
            {
                thuoc.SoLuongTonKho = int.Parse(txtSoLuongTonKho.Text);
            }
        }
    }
}