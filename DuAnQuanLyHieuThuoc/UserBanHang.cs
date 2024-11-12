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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

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
                    var existingItem = cart.FirstOrDefault(c => c.DrugName == drugName);
                    if (existingItem != null)
                    {
                        // Cập nhật số lượng và tổng tiền cho mặt hàng đã có
                        existingItem.Quantity += quantity;
                        existingItem.TotalPrice = existingItem.Quantity * unitPrice;
                    }
                    else
                    {
                        cart.Add(new CartItem { DrugName = drugName, UnitPrice = unitPrice, Quantity = quantity, TotalPrice = totalPrice });
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = cart;

                    // Tính tổng tiền giỏ hàng
                    txtTongTien.Text = cart.Sum(item => item.TotalPrice).ToString();
                }

            }
            else
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số hợp lệ.");
            }

        }
        //dinh nghia gio hang
        public class CartItem
        {
            public string DrugName { get; set; }
            public float UnitPrice { get; set; }
            public int Quantity { get; set; }
            public float TotalPrice { get; set; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenThuoc = txtTenThuoc.Text;
            var check = cart.FirstOrDefault(x => x.DrugName == tenThuoc);
            cart.Remove(check);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cart;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < cart.Count)
            {
                txtTenThuoc.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTongTien.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
