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
    public partial class UserQuanLyHoaDon : UserControl
    {
        public UserQuanLyHoaDon()
        {
            InitializeComponent();
        }
        private string placeholderText = "Tìm kiếm hóa đơn";
        private Color placeholderColor = Color.Gray;
        private Color textColor = Color.Black;
        private void UserQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            SetPlaceholder();

        }

        private void SetPlaceholder()
        {
            txtTimKiem.Text = placeholderText;
            txtTimKiem.ForeColor = placeholderColor;
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == placeholderText)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = textColor;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                SetPlaceholder();
            }
        }
    }
}
