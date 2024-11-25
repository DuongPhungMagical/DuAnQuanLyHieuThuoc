using DuAnQuanLyHieuThuoc.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace DuAnQuanLyHieuThuoc
{
    public partial class frmDangNhap : Form
    {
        private readonly DataContext _context;

        public frmDangNhap()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void lblDangKi_Click(object sender, EventArgs e)
        {
            frmDangKi frmDangKi = new frmDangKi();
            frmDangKi.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // Sử dụng truy vấn bất đồng bộ
            var taiKhoanNguoiDung = await _context.TaiKhoans
                .FirstOrDefaultAsync(x => x.TenTaiKhoan == taiKhoan && x.MatKhau == matKhau);

            if (taiKhoanNguoiDung != null)
            {
                MessageBox.Show($"{taiKhoanNguoiDung.VaiTro} đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);

                frmTrangChuAdmin admin = new frmTrangChuAdmin();
                admin.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        // Đảm bảo giải phóng tài nguyên khi form bị đóng
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
