using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserQuanLyNhanVien : UserControl
    {
        private readonly DataContext _context;
        public UserQuanLyNhanVien()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void UserQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            SetPlaceHolder();
            ShowNhanVien();
            ShowTrangThai();
        }
        private string textPlaceholder = "Tìm kiếm nhân viên";
        private Color textColor = Color.Gray;
        private Color color2 = Color.Black;
        private void SetPlaceHolder()
        {
            txtTimKiem.Text = textPlaceholder;
            txtTimKiem.ForeColor = textColor;
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == textPlaceholder)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = color2;
            }
        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                SetPlaceHolder();
            }
        }
        private void ShowNhanVien()
        {
            var show = _context.NhanViens.Join(_context.TrangThais, x => x.IdTrangThai, y => y.Id, (x, y) => new
            {
                x.TenNhanVien,
                x.Tuoi,
                x.SoDienThoai,
                x.DiaChi,
                x.NgayVaoLam,
                y.TrangThai1
            }).ToList();
            var show1 = show.Select((x, index) => new
            {
                STT = index + 1,
                x.TenNhanVien,
                x.Tuoi,
                x.SoDienThoai,
                x.DiaChi,
                x.NgayVaoLam,
                x.TrangThai1
            }).ToList();
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.DataSource = show1;
        }
        private void ShowTrangThai()
        {
            var tt = _context.TrangThais.ToList();
            cbTrangThai.DataSource = tt;
            cbTrangThai.DisplayMember = "TrangThai1";
            cbTrangThai.ValueMember = "Id";
        }

        //ham validate so dien thoai
        private bool ValidateSDT(string sdt)
        {
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                return false;
            }
            return sdt.All(char.IsDigit);
        }
        //ham validate tuoi
        private bool ValidateTuoi(string tuoi)
        {
            if (int.TryParse(tuoi, out int result))
            {
                return result >= 1 && result <= 100;
            }
            return false;
        }
        private bool ValidateNgayVaoLam(DateTime dateTime)
        {
            if (dateTime <= DateTime.Today)
            {
                return true;
            }
            MessageBox.Show("Ngày vào làm không hợp lệ");
            return false;

        }
        private bool ValidateTenDiaChi()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Kiểm tra từng điều kiện trước khi tiến hành thêm
                if (!ValidateTenDiaChi() || !ValidateSDT(txtSoDienThoai.Text) || !ValidateTuoi(txtTuoi.Text) || !ValidateNgayVaoLam(dtpNgayVaoLam.Value))
                {
                    MessageBox.Show("Nhap sai du lieu", "", MessageBoxButtons.OK);
                    return; 
                }

                // Tạo đối tượng nhân viên mới sau khi đã xác minh dữ liệu
                NhanVien nhanVien1 = new NhanVien
                {
                    TenNhanVien = txtTenNhanVien.Text,
                    DiaChi = txtDiaChi.Text,
                    Tuoi = int.Parse(txtTuoi.Text),
                    NgayVaoLam = dtpNgayVaoLam.Value,
                    SoDienThoai = txtSoDienThoai.Text,
                    IdTrangThai = (int)cbTrangThai.SelectedValue
                };

                _context.Add(nhanVien1);
                _context.SaveChanges();

                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                ShowNhanVien();
            }


        }



        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            int maNhanVien = int.Parse(lblMaNhanVien.Text);
            var kiemTra = _context.NhanViens.FirstOrDefault(x => x.Id == maNhanVien);
            if (kiemTra != null)
            {
                kiemTra.TenNhanVien = txtTenNhanVien.Text;
                kiemTra.DiaChi = txtDiaChi.Text;
                if (!ValidateSDT(txtSoDienThoai.Text))
                {
                    MessageBox.Show("Số điện thoại bao gồm 10 chữ số và bắt đầu từ chữ số 0");
                }
                else
                {
                    kiemTra.SoDienThoai = txtSoDienThoai.Text;
                }
                if (!ValidateTuoi(txtTuoi.Text))
                {
                    MessageBox.Show("Tuổi phải từ 1 đến 100");
                }
                else
                {
                    kiemTra.Tuoi = int.Parse(txtTuoi.Text);
                }
                kiemTra.NgayVaoLam = dtpNgayVaoLam.Value;
                if (ValidateNgayVaoLam(dtpNgayVaoLam.Value))
                {
                    kiemTra.NgayVaoLam = dtpNgayVaoLam.Value;
                }
                kiemTra.IdTrangThai = (int)(cbTrangThai.SelectedValue);
            }
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            _context.SaveChanges();
            ShowNhanVien();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.RowCount)
            {
                string ten = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sdt = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                var ma = _context.NhanViens.FirstOrDefault(x => x.TenNhanVien == ten && x.SoDienThoai == sdt);
                txtTenNhanVien.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoDienThoai.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTuoi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpNgayVaoLam.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (ma != null)
                {
                    lblMaNhanVien.Text = ma.Id.ToString();
                }
                else
                {
                    lblMaNhanVien.Text = "Không tìm thấy";
                }
                cbTrangThai.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
        }

        private void btnChoNghiViec_Click(object sender, EventArgs e)
        {

        }

    }
}
