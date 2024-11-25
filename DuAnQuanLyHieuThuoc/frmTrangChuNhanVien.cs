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
    public partial class frmTrangChuNhanVien : Form
    {
        public frmTrangChuNhanVien()
        {
            InitializeComponent();
        }
        public void ShowChucNang(UserControl userControl)
        {
            pnShow.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnShow.Controls.Add(userControl);
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserBanHang());
        }

        private void btnQuanLyThuoc_Click(object sender, EventArgs e)
        {
            ShowChucNang(new UserQuanLyKhachHang());
        }

        private void btnQuanLyNhapKho_Click(object sender, EventArgs e)
        {

        }

        private void pnShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
