using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
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

        private async void UserQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            SetPlaceHolder();
            await ShowNhanVien();
            await ShowTrangThai();
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

        // Asynchronous method to fetch and display employees
        private async Task ShowNhanVien()
        {
            var show = await _context.NhanViens.Join(_context.TrangThais, x => x.IdTrangThai, y => y.Id, (x, y) => new
            {
                x.TenNhanVien,
                x.Tuoi,
                x.SoDienThoai,
                x.DiaChi,
                x.NgayVaoLam,
                y.TrangThai1
            }).ToListAsync();

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

        // Asynchronous method to fetch and display employee statuses
        private async Task ShowTrangThai()
        {
            var tt = await _context.TrangThais.ToListAsync();
            cbTrangThai.DataSource = tt;
            cbTrangThai.DisplayMember = "TrangThai1";
            cbTrangThai.ValueMember = "Id";
        }

        // Validate phone number
        private bool ValidateSDT(string sdt)
        {
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                return false;
            }
            return sdt.All(char.IsDigit);
        }

        // Validate age
        private bool ValidateTuoi(string tuoi)
        {
            if (int.TryParse(tuoi, out int result))
            {
                return result >= 1 && result <= 100;
            }
            return false;
        }

        // Validate the joining date
        private bool ValidateNgayVaoLam(DateTime dateTime)
        {
            if (dateTime <= DateTime.Today)
            {
                return true;
            }
            MessageBox.Show("Ngày vào làm không hợp lệ");
            return false;
        }

        // Validate that name and address are not empty
        private bool ValidateTenDiaChi()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Asynchronous method to add a new employee
        private async void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!ValidateTenDiaChi() || !ValidateSDT(txtSoDienThoai.Text) || !ValidateTuoi(txtTuoi.Text) || !ValidateNgayVaoLam(dtpNgayVaoLam.Value))
                {
                    MessageBox.Show("Nhập sai dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }

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
                await _context.SaveChangesAsync();

                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                await ShowNhanVien();
            }
        }

        // Asynchronous method to update employee information
        private async void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            int maNhanVien = int.Parse(lblMaNhanVien.Text);
            var kiemTra = await _context.NhanViens.FirstOrDefaultAsync(x => x.Id == maNhanVien);

            if (kiemTra != null)
            {
                kiemTra.TenNhanVien = txtTenNhanVien.Text;
                kiemTra.DiaChi = txtDiaChi.Text;

                if (ValidateSDT(txtSoDienThoai.Text))
                {
                    kiemTra.SoDienThoai = txtSoDienThoai.Text;
                }

                if (ValidateTuoi(txtTuoi.Text))
                {
                    kiemTra.Tuoi = int.Parse(txtTuoi.Text);
                }

                if (ValidateNgayVaoLam(dtpNgayVaoLam.Value))
                {
                    kiemTra.NgayVaoLam = dtpNgayVaoLam.Value;
                }

                kiemTra.IdTrangThai = (int)(cbTrangThai.SelectedValue);

                await _context.SaveChangesAsync();

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                await ShowNhanVien();
            }
        }

        // Handle the cell click event in the employee grid view
        private async void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.RowCount)
            {
                string ten = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sdt = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                var ma = await _context.NhanViens.FirstOrDefaultAsync(x => x.TenNhanVien == ten && x.SoDienThoai == sdt);
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
    }
}
