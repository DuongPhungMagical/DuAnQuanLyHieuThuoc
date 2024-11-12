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
        private readonly DataContext _context;

        public frmDangKi()
        {
            _context = new DataContext();
            InitializeComponent();
        }
        // Khai báo placeholder và màu placeholder
        private string placeholderText = "Xác nhận mật khẩu";
        private Color placeholderColor = Color.Gray;
        private Color textColor = Color.Black;

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            SetPlaceholder();
            SetVaiTro();
        }


        private void SetPlaceholder()
        {
            txtXacNhan.Text = placeholderText;
            txtXacNhan.ForeColor = placeholderColor;
        }

        private void txtXacNhan_Click(object sender, EventArgs e)
        {
            if (txtXacNhan.Text == placeholderText)
            {
                txtXacNhan.Text = "";
                txtXacNhan.ForeColor = textColor;
            }
        }

        private void txtXacNhan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXacNhan.Text))
            {
                SetPlaceholder();
            }
        }
        private void SetVaiTro()
        {
            var vaiTro = _context.VaiTros.ToList();
            cbVaiTro.DataSource = vaiTro;
            cbVaiTro.DisplayMember = "VaiTro1";
            cbVaiTro.ValueMember = "Id";
        }

        private void btnDangKi_Click_1(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtXacNhan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(txtMatKhau.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            TaiKhoan tk = new TaiKhoan()
            {
                TenTaiKhoan = txtTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                VaiTro = cbVaiTro.Text,
            };
            MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK);
           
            _context.Add(tk);
            _context.SaveChanges();

            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
            this.Close();
        }
    }
}

