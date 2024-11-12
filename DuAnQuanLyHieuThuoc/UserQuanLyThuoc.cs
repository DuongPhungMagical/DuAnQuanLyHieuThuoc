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
        private void UserQuanLyThuoc_Load(object sender, EventArgs e)
        {
            SetPlaceholder();
            ShowThuoc();
            ShowLoaiHangNha();
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

        private void ShowThuoc()
        {
            var showThuoc = _context.Thuocs
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
                }).ToList();
            dgvThuoc.DataSource = showThuoc;
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ShowLoaiHangNha()
        {
            var loai = _context.LoaiThuocs.ToList();
            cbLoaiThuoc.DataSource = loai;
            cbLoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cbLoaiThuoc.ValueMember = "Id";

            var hang = _context.HangSanXuats.ToList();
            cbHangSanXuat.DataSource = hang;
            cbHangSanXuat.DisplayMember = "TenHangSanXuat";
            cbHangSanXuat.ValueMember = "Id";

            var cc = _context.NhaCungCaps.ToList();
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

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường thông tin cần thiết
            if (!ValidateTenDonViGMoTa())
            {
                return;
            }

            if (!ValidateGiaTien(txtGiaBan.Text) || !ValidateSltk(txtSoLuongTonKho.Text))
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
                IdHangSanXuat = (int)cbHangSanXuat.SelectedValue
            };
            // Gán giá trị cho GiaBan và SoLuongTonKho nếu hợp lệ
            thuoc.GiaBan = double.Parse(txtGiaBan.Text);
            thuoc.SoLuongTonKho = int.Parse(txtSoLuongTonKho.Text);

            _context.Thuocs.Add(thuoc);
            _context.SaveChanges();
            ShowThuoc();

            MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvThuoc.RowCount)
            {
                string ten = dgvThuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                string mota = dgvThuoc.Rows[e.RowIndex].Cells[5].Value.ToString();
                var maThuoc = _context.Thuocs.FirstOrDefault(x => x.TenThuoc == ten && x.MoTa == mota);
                if (maThuoc != null)
                {
                    lblMaNhanVien.Text = maThuoc.Id.ToString();
                }
                txtTenThuoc.Text = dgvThuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDonViTinh.Text = dgvThuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvThuoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuongTonKho.Text = dgvThuoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpHanSuDung.Text = dgvThuoc.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMoTa.Text = dgvThuoc.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbLoaiThuoc.Text = dgvThuoc.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbHangSanXuat.Text = dgvThuoc.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbNhaCungCap.Text = dgvThuoc.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            var suaThuoc = _context.Thuocs.FirstOrDefault(x => x.Id == int.Parse(lblMaNhanVien.Text));

            if (!ValidateTenDonViGMoTa())
            {
                return; // dừng lại nếu hàm false
            }
            if (!ValidateGiaTien(txtGiaBan.Text) || !ValidateSltk(txtSoLuongTonKho.Text))
            {
                return;
            }
            SetThuoc(suaThuoc);
            if (MessageBox.Show("Bạn có chắc chắn muốn sửa thuốc?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _context.SaveChanges();
                MessageBox.Show("Thành công!!", "Thông báo", MessageBoxButtons.OK);
                ShowThuoc();
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

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa thuốc","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var xoaThuoc = _context.Thuocs.FirstOrDefault(x => x.Id == int.Parse(lblMaNhanVien.Text));
                _context.Thuocs.Remove(xoaThuoc);
                _context.SaveChanges();
                MessageBox.Show("Xóa thuốc thành công", "Thông báo", MessageBoxButtons.OK);
                ShowThuoc();
            }     
        }
    }
}
