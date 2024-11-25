using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserQuanLyKhachHang : UserControl
    {
        private readonly DataContext _context;

        public UserQuanLyKhachHang()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private async void UserQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            SetPlaceHolder();
            await ShowKhachHangAsync();
        }

        private async Task ShowKhachHangAsync()
        {
            var show = await _context.KhachHangs.ToListAsync();
            var show1 = show.Select((x, index) => new
            {
                STT = index + 1,
                x.TenKhachHang,
                x.Tuoi,
                x.SoDienThoai,
                x.DiaChi
            }).ToList();
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.DataSource = show1;
        }

        private string textPlaceholder = "Tìm kiếm khách hàng";
        private Color textColor = Color.Gray;
        private Color color2 = Color.Black;

        private void SetPlaceHolder()
        {
            txtTimKiem.Text = textPlaceholder;
            txtTimKiem.ForeColor = textColor;
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                SetPlaceHolder();
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTimKiem.Text == textPlaceholder)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private bool ValidateSDT(string sdt)
        {
            if (sdt.Length != 10 && !sdt.StartsWith("0"))
            {
                return false;
            }
            return sdt.All(char.IsDigit);
        }

        private bool ValidateTuoi(string tuoi)
        {
            if (int.TryParse(tuoi, out int result))
            {
                return result >= 1 && result <= 100;
            }
            return false;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thêm khách hàng?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Kiểm tra từng điều kiện trước khi tiến hành thêm
                if (!ValidateSDT(txtSDT.Text) || !ValidateTuoi(txtTuoi.Text))
                {
                    MessageBox.Show("Nhập sai dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }

                // Tạo đối tượng khách hàng mới sau khi đã xác minh dữ liệu
                KhachHang khachHang = new KhachHang
                {
                    TenKhachHang = txtTen.Text,
                    DiaChi = txtDiaChi.Text,
                    Tuoi = int.Parse(txtTuoi.Text),
                    SoDienThoai = txtSDT.Text,
                };

                _context.Add(khachHang);
                await _context.SaveChangesAsync();

                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK);
                await ShowKhachHangAsync();
            }
        }

        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(lblMa.Text, out id))
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var khachHang = await _context.KhachHangs.FirstOrDefaultAsync(x => x.Id == id);

                if (khachHang == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                khachHang.TenKhachHang = txtTen.Text;
                khachHang.DiaChi = txtDiaChi.Text;

                int tuoi;
                if (!int.TryParse(txtTuoi.Text, out tuoi) || tuoi <= 0)
                {
                    MessageBox.Show("Tuổi không hợp lệ. Vui lòng nhập một số dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                khachHang.Tuoi = tuoi;
                if (!ValidateSDT(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 chữ số và bắt đầu bằng số 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                khachHang.SoDienThoai = txtSDT.Text;

                await _context.SaveChangesAsync();
                MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await ShowKhachHangAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                string ten = dgvDanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                string sdt = dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                var ma = await _context.KhachHangs.FirstOrDefaultAsync(x => x.TenKhachHang == ten && x.SoDienThoai == sdt);

                txtTen.Text = dgvDanhSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvDanhSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTuoi.Text = dgvDanhSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (ma != null)
                {
                    lblMa.Text = ma.Id.ToString();
                }
                else
                {
                    lblMa.Text = "Không tìm thấy";
                }
            }
        }
    }
}
