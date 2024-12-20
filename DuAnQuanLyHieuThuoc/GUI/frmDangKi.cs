using DuAnQuanLyHieuThuoc.BUS;
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
    public partial class frmDangKi : Form
    {
        BUS_DangKi bDangKi;

        public frmDangKi()
        {
            InitializeComponent();
            bDangKi = new BUS_DangKi();
        }

        private async void btnDangKi_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên tài khoản
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tên tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu
            string pass = txtMatKhau.Text;
            bool vietHoa = pass.Any(char.IsUpper);
            bool chuaSo = pass.Any(char.IsDigit);

            if (!vietHoa || !chuaSo)
            {
                MessageBox.Show("Mật khẩu phải chứa ít nhất một chữ cái hoa và một chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (pass != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng tài khoản
            var taiKhoan = new TaiKhoan
            {
                TenTaiKhoan = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
            };

            try
            {
                // Gọi BUS để tạo tài khoản
                bool result = await bDangKi.TaoTaiKhoan(taiKhoan);
                if (result)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Chuyển sang form khác
 
                    frmDangNhap dangNhap = new frmDangNhap();
                    dangNhap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

