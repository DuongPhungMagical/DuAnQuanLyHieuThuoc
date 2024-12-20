using DuAnQuanLyHieuThuoc.BUS;
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
        BUS_NhanVien bNhanVien;
        public UserQuanLyNhanVien()
        {
            InitializeComponent();
            bNhanVien = new BUS_NhanVien();
        }

        private void UserQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            bNhanVien.LoadDanhSachNhanVien(dgvNhanVien);
            bNhanVien.LoadTrangThai(cbTrangThai);
        }

        private async void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu không hợp lệ
            }
            string sdt = txtSoDienThoai.Text;
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char c in sdt)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số điện thoại phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi >= 50 || tuoi <= 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn 17 và nhỏ hơn 50!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpNgayVaoLam.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không thể ở trong tương lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var nhanvien = new NhanVien
            {
                TenNhanVien = txtTenNhanVien.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                Tuoi = tuoi,
                NgayVaoLam = dtpNgayVaoLam.Value,
                IdTrangThai = Convert.ToInt32(cbTrangThai.SelectedValue)
            };
            try
            {
                bool result = await bNhanVien.ThemNhanVien(nhanvien);
                if (result)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bNhanVien.LoadDanhSachNhanVien(dgvNhanVien);
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu không hợp lệ
            }
            string sdt = txtSoDienThoai.Text;
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char c in sdt)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số điện thoại phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi >= 50 || tuoi <= 18)
            {
                MessageBox.Show("Tuổi phải lớn hơn 17 và nhỏ hơn 50!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpNgayVaoLam.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không thể ở trong tương lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var nhanvien = new NhanVien
            {
                Id = selectedId,
                TenNhanVien = txtTenNhanVien.Text,
                SoDienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                Tuoi = tuoi,
                NgayVaoLam = dtpNgayVaoLam.Value,
                IdTrangThai = Convert.ToInt32(cbTrangThai.SelectedValue)
            };
            try
            {
                bool result = await bNhanVien.SuaNhanVien(nhanvien);
                if (result)
                {
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhanVien.DataSource = null;
                    bNhanVien.LoadDanhSachNhanVien(dgvNhanVien);
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int selectedId;
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                var row = dgvNhanVien.Rows[e.RowIndex];
                // Lấy ID thuốc từ cột ẩn hoặc DataBoundItem
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtTenNhanVien.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtTuoi.Text = row.Cells["Tuoi"].Value.ToString();
                dtpNgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                cbTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnChoNghiViec_Click(object sender, EventArgs e)
        {

        }
    }
}
