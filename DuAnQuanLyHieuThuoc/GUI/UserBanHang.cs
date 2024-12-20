using DuAnQuanLyHieuThuoc.BUS;
using DuAnQuanLyHieuThuoc.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserBanHang : UserControl
    {
        BUS_BanHang bBanHang;
        public UserBanHang()
        {
            InitializeComponent();
            bBanHang = new BUS_BanHang();
        }

        private void UserBanHang_Load(object sender, EventArgs e)
        {
            bBanHang.LoadDanhSach(lbThuoc);
        }

        private async void lbThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbThuoc.SelectedItem == null)
            {
                return;
            }
            string tenThuoc = lbThuoc.SelectedItem.ToString();
            try
            {
                var thuoc = await bBanHang.GetThuocByName(tenThuoc);
                if (thuoc != null)
                {
                    txtTenThuoc.Text = thuoc.TenThuoc;
                    txtIdThuoc.Text = thuoc.Id.ToString();
                    txtDonGia.Text = thuoc.GiaBan.ToString();
                    txtDonViTinh.Text = thuoc.DonViTinh;
                    dtpHanSuDung.Value = thuoc.HanSuDung;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSoLuong.Text, out int quantity) && quantity > 0)
            {
                string drugName = txtTenThuoc.Text;
                float unitPrice = float.Parse(txtDonGia.Text);
                string customerName = txtTenKH.Text;
                string phone = txtSDT.Text;

                // Thêm vào giỏ hàng
                if (bBanHang.AddToCart(drugName, unitPrice, quantity, customerName, phone, out string errorMessage))
                {
                    // Cập nhật DataGridView
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = bBanHang.GetCart();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Tính tổng tiền
                    txtTongTien.Text = bBanHang.CalculateTotalPrice().ToString("N2");
                }
                else
                {
                    MessageBox.Show(errorMessage, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Tạo instance của UserControl UserThanhToan
            var userThanhToan = new UserThanhToan();

            // Truy cập Form cha (frmTrangChuNhanVien)
            var parentForm = this.ParentForm as frmTrangChuNhanVien;

            if (parentForm != null)
            {
                // Gọi phương thức ShowChucNang để thay đổi UserControl
                parentForm.ShowChucNang(userThanhToan);
            }
        }
    }
}
