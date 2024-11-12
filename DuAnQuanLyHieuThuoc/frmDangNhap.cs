
using DuAnQuanLyHieuThuoc.Models;
using System.Security.Cryptography.Xml;

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
        frmTrangChuAdmin admin = new frmTrangChuAdmin();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var taiKhoan = txtTaiKhoan.Text;
            var matKhau = txtMatKhau.Text;

            var kiemTra = _context.TaiKhoans.FirstOrDefault(x => x.TenTaiKhoan == taiKhoan && x.MatKhau == matKhau);
            if (kiemTra != null && kiemTra.VaiTro == "Nhân viên")
            {
                MessageBox.Show($"{kiemTra.VaiTro} đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                
                admin.Show();               
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "zz", MessageBoxButtons.OK);

            }

        }
    }
}
