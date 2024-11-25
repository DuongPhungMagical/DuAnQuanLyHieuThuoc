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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserBanHang : UserControl
    {
        public DataContext _context;
        public UserBanHang()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        private void UserBanHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachThuoc();
        }
        private void LoadDanhSachThuoc()
        {
            var thuoc = _context.Thuocs.Select(x => x.TenThuoc).ToList();
            lbThuoc.DataSource = thuoc;
        }

        private void lbThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenThuoc = lbThuoc.GetItemText(lbThuoc.SelectedItem);
            var layThuoc = _context.Thuocs.FirstOrDefault(x => x.TenThuoc == tenThuoc);
            if (layThuoc != null)
            {
                txtIdThuoc.Text = layThuoc.Id.ToString();
                txtTenThuoc.Text = layThuoc.TenThuoc;
                txtDonGia.Text = layThuoc.GiaBan.ToString();
                txtDonViTinh.Text = layThuoc.DonViTinh;
                dtpHanSuDung.Value = layThuoc.HanSuDung;
            }

        }

        //Khoi tao gio hang
        List<CartItem> cart = new List<CartItem>();

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtSoLuong.Text, out int quantity) && quantity > 0)
            {

                string drugName = txtTenThuoc.Text;
                var checkSoLuong = _context.Thuocs.Where(x => x.TenThuoc == txtTenThuoc.Text).Select(x => x.SoLuongTonKho).FirstOrDefault();
                if (checkSoLuong < int.Parse(txtSoLuong.Text))
                {
                    MessageBox.Show("Số lượng không đủ để bán.");
                }
                else
                {
                    float unitPrice = float.Parse(txtDonGia.Text);
                    float totalPrice = unitPrice * quantity;

                    // Kiểm tra thuốc đã có trong giỏ chưa
                    var existingItem = cart.FirstOrDefault(c => c.TenThuoc == drugName);
                    if (existingItem != null)
                    {
                        // Cập nhật số lượng và tổng tiền cho mặt hàng đã có
                        existingItem.SoLuong += quantity;
                        existingItem.TongTien = existingItem.TongTien * unitPrice;
                    }
                    else
                    {
                        cart.Add(new CartItem { TenThuoc = drugName, DonGia = unitPrice, SoLuong = quantity, TongTien = totalPrice });
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = cart;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                    // Tính tổng tiền giỏ hàng
                    txtTongTien.Text = cart.Sum(item => item.TongTien).ToString();
                }

            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.");
            }

        }
        //dinh nghia gio hanggggg
        public class CartItem
        {
            public string TenThuoc { get; set; }
            public float DonGia { get; set; }
            public int SoLuong { get; set; }
            public float TongTien { get; set; }
        }
        // du na 

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenThuoc = txtTenThuoc.Text;
            var check = cart.FirstOrDefault(x => x.TenThuoc == tenThuoc);
            cart.Remove(check);
            dataGridView1.DataSource = null;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = cart;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < cart.Count)
            {
                txtTenThuoc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTongTien.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void bntTaoHoaDon_Click(object sender, EventArgs e)
        {
            frmTrangChuNhanVien frm = (frmTrangChuNhanVien)Application.OpenForms["frmTrangChuNhanVien"];

            if (frm != null)
            {
                // Kiểm tra nếu UserThanhToan đã được mở, nếu chưa thì tạo mới
                UserThanhToan tt = frm.Controls.OfType<UserThanhToan>().FirstOrDefault();

                if (tt == null)
                {
                    tt = new UserThanhToan();
                    frm.ShowChucNang(tt);  // Đảm bảo form chính hiển thị UserThanhToan
                }

                // Truyền tổng tiền từ form bán hàng vào UserThanhToan
                tt.SetSoTien(float.Parse(txtTongTien.Text));
            }
            else
            {
                MessageBox.Show("Form chính chưa được mở.");
            }

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            var check = _context.KhachHangs.FirstOrDefault(x => x.SoDienThoai == txtSDT.Text);
            if (check != null)
            {
                txtTenKH.Text = check.TenKhachHang.ToString();
            }
        }
    }
}
