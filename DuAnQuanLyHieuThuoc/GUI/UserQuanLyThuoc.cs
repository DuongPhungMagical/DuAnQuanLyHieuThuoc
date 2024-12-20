using DuAnQuanLyHieuThuoc.BUS;
using DuAnQuanLyHieuThuoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DuAnQuanLyHieuThuoc
{
    public partial class UserQuanLyThuoc : UserControl
    {
        public BUS_Thuoc bThuoc;
        public UserQuanLyThuoc()
        {
            InitializeComponent();
            bThuoc = new BUS_Thuoc();
        }

        private async void UserQuanLyThuoc_Load(object sender, EventArgs e)
        {
            bThuoc.LoadThuocVaoDataGridView(dgvThuoc);
            await bThuoc.LoadNhaCungCap(cbNhaCungCap);
            await bThuoc.LoadLoaiThuoc(cbLoaiThuoc);
            await bThuoc.LoadHangSanXuat(cbHangSanXuat);
        }

        private async void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenThuoc.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu không hợp lệ
            }
            if (string.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtGiaBan.Text, out double giaBan) || giaBan < 0)
            {
                MessageBox.Show("Giá bán phải là một số dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuongTonKho.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng tồn kho phải là một số nguyên không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMoTa.Text.Length > 500)
            {
                MessageBox.Show("Mô tả không được dài quá 500 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hạn sử dụng (hạn sử dụng không thể là ngày trong quá khứ)
            if (dtpHanSuDung.Value < DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng không thể là ngày trong quá khứ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var thuocMoi = new Thuoc
            {
                TenThuoc = txtTenThuoc.Text,
                DonViTinh = txtDonViTinh.Text,
                GiaBan = giaBan,
                SoLuongTonKho = soLuong,
                HanSuDung = dtpHanSuDung.Value,
                MoTa = txtMoTa.Text,
                IdNhaCungCap = Convert.ToInt32(cbNhaCungCap.SelectedValue),
                IdHangSanXuat = Convert.ToInt32(cbHangSanXuat.SelectedValue),
                IdLoaiThuoc = Convert.ToInt32(cbLoaiThuoc.SelectedValue)
            };
            try
            {
                bool result = await bThuoc.ThemThuoc(thuocMoi);
                if (result)
                {
                    MessageBox.Show("Thêm thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bThuoc.LoadThuocVaoDataGridView(dgvThuoc);
                }
                else
                {
                    MessageBox.Show("Thêm thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenThuoc.Text))
            {
                MessageBox.Show("Tên thuốc không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng thực hiện nếu không hợp lệ
            }
            if (string.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtGiaBan.Text, out double giaBan) || giaBan < 0)
            {
                MessageBox.Show("Giá bán phải là một số dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSoLuongTonKho.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng tồn kho phải là một số nguyên không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtMoTa.Text.Length > 500)
            {
                MessageBox.Show("Mô tả không được dài quá 500 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hạn sử dụng (hạn sử dụng không thể là ngày trong quá khứ)
            if (dtpHanSuDung.Value < DateTime.Now)
            {
                MessageBox.Show("Hạn sử dụng không thể là ngày trong quá khứ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var thuocMoi = new Thuoc
            {
                Id = selectedId,
                TenThuoc = txtTenThuoc.Text,
                DonViTinh = txtDonViTinh.Text,
                GiaBan = giaBan,
                SoLuongTonKho = soLuong,
                HanSuDung = dtpHanSuDung.Value,
                MoTa = txtMoTa.Text,
                IdNhaCungCap = Convert.ToInt32(cbNhaCungCap.SelectedValue),
                IdHangSanXuat = Convert.ToInt32(cbHangSanXuat.SelectedValue),
                IdLoaiThuoc = Convert.ToInt32(cbLoaiThuoc.SelectedValue)
            };
            try
            {
                bool result = await bThuoc.SuaThuoc(thuocMoi);
                if (result)
                {
                    MessageBox.Show("Sửa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public int selectedId;
        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                var row = dgvThuoc.Rows[e.RowIndex];

                // Lấy ID thuốc từ cột ẩn hoặc DataBoundItem
                selectedId = Convert.ToInt32(row.Cells["Id"].Value);

                // Gán dữ liệu vào các TextBox và ComboBox
                txtTenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                txtSoLuongTonKho.Text = row.Cells["SoLuongTonKho"].Value.ToString();
                dtpHanSuDung.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();

                // Gán dữ liệu cho ComboBox (nếu có)
                cbNhaCungCap.SelectedItem = row.Cells["TenNhaCungCap"].Value.ToString();
                cbHangSanXuat.SelectedItem = row.Cells["TenHangSanXuat"].Value.ToString();
                cbLoaiThuoc.SelectedItem = row.Cells["TenLoaiThuoc"].Value.ToString();
            }
        }

        private async void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)  // Kiểm tra xem có ID nào được chọn hay không
            {
                MessageBox.Show("Vui lòng chọn thuốc để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = await bThuoc.XoaThuoc(selectedId);
            if (result)
            {
                MessageBox.Show("Xóa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bThuoc.LoadThuocVaoDataGridView(dgvThuoc);
            }
            else
            {
                MessageBox.Show("Xóa thuốc thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            var thuoc = bThuoc.TimThuoc(ten);
            if(thuoc != null)
            {
                dgvThuoc.DataSource = thuoc.Select(t => new
                {
                    t.Id,
                    t.TenThuoc,
                    t.DonViTinh,
                    t.GiaBan,
                    t.SoLuongTonKho,
                    t.HanSuDung,
                    t.MoTa,
                    NhaCungCap = t.IdNhaCungCapNavigation.TenNhaCungCap,
                    HangSanXuat = t.IdHangSanXuatNavigation.TenHangSanXuat,
                    LoaiThuoc = t.IdLoaiThuocNavigation.TenLoaiThuoc
                }).ToList();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}