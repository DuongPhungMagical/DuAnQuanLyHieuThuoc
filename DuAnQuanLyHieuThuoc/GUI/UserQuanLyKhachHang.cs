using DuAnQuanLyHieuThuoc.BUS;
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
        BUS_KhachHang bKhachHang;

        public UserQuanLyKhachHang()
        {
            InitializeComponent();
            bKhachHang = new BUS_KhachHang();
        }

        private void UserQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            bKhachHang.LoadDanhSach(dgvDanhSach);
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi <= 3 || tuoi > 111)
            {
                MessageBox.Show("Tuổi phải là số lơn hơn 3 và nhỏ hơn 111!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sdt = txtSDT.Text;
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng 0 và có 10 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char ch in sdt)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Số điện thoại phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            var khachHang = new KhachHang
            {
                TenKhachHang = txtTen.Text,
                SoDienThoai = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                Tuoi = tuoi
            };
            bool result = await bKhachHang.ThemKhachHang(khachHang);
            try
            {
                if (result)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bKhachHang.LoadDanhSach(dgvDanhSach);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int selectedId;
        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi <= 3 || tuoi > 111)
            {
                MessageBox.Show("Tuổi phải là số lơn hơn 3 và nhỏ hơn 111!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sdt = txtSDT.Text;
            if (sdt.Length != 10 || !sdt.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng 0 và có 10 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char ch in sdt)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Số điện thoại phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            var khachHang = new KhachHang
            {
                Id = selectedId,
                TenKhachHang = txtTen.Text,
                Tuoi = tuoi,
                SoDienThoai = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
            };
            bool result = await bKhachHang.SuaKhachHang(khachHang);
            try
            {
                if (result)
                {
                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDanhSach.DataSource = null;
                    bKhachHang.LoadDanhSach(dgvDanhSach);
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row = dgvDanhSach.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                txtTen.Text = row.Cells["TenKhachHang"].Value.ToString();
                txtTuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }
    }
}
