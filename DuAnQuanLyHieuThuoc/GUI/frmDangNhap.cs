using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DuAnQuanLyHieuThuoc.BUS;

namespace DuAnQuanLyHieuThuoc
{
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap bDangNhap;
        public frmDangNhap()
        {
            InitializeComponent();
            bDangNhap = new BUS_DangNhap();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string result = await bDangNhap.DangNhap(tenTaiKhoan, matKhau);

            if (result == "Đăng nhập thành công!")
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Chuyển sang form khác
                frmTrangChuNhanVien trangChu = new frmTrangChuNhanVien();
                trangChu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
