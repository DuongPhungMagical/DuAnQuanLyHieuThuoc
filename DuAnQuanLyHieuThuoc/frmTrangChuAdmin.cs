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
    public partial class frmTrangChuAdmin : Form
    {
        public frmTrangChuAdmin()
        {
            InitializeComponent();
        }

        private void ShowChucNang(UserControl userControl)
        {
            pnShow.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnShow.Controls.Add(userControl);
        }
        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserQuanLyNhanVien());
        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserQuanLyThuoc());
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserQuanLyHoaDon());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserThanhToan());
        }

        private void pnShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserQuanLyKhachHang());
        }
    }
}
