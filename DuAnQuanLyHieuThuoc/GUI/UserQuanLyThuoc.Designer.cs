namespace DuAnQuanLyHieuThuoc
{
    partial class UserQuanLyThuoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            dgvThuoc = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtpHanSuDung = new DateTimePicker();
            txtDonViTinh = new TextBox();
            txtGiaBan = new TextBox();
            txtSoLuongTonKho = new TextBox();
            txtTenThuoc = new TextBox();
            label9 = new Label();
            txtMoTa = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label11 = new Label();
            txtTimKiem = new TextBox();
            btnSuaThuoc = new Button();
            btnXoaThuoc = new Button();
            btnThemThuoc = new Button();
            cbLoaiThuoc = new ComboBox();
            cbHangSanXuat = new ComboBox();
            cbNhaCungCap = new ComboBox();
            lblMaNhanVien = new Label();
            lblMaThuoc = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold);
            label8.Location = new Point(75, 646);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(155, 21);
            label8.TabIndex = 33;
            label8.Text = "Danh sách thuốc";
            // 
            // dgvThuoc
            // 
            dgvThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuoc.Location = new Point(75, 671);
            dgvThuoc.Margin = new Padding(2);
            dgvThuoc.Name = "dgvThuoc";
            dgvThuoc.RowHeadersWidth = 82;
            dgvThuoc.Size = new Size(1664, 558);
            dgvThuoc.TabIndex = 32;
            dgvThuoc.CellClick += dgvThuoc_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold);
            label6.Location = new Point(158, 365);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 28;
            label6.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.Location = new Point(1052, 180);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 21);
            label5.TabIndex = 27;
            label5.Text = "Số lượng tồn kho";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.Location = new Point(158, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 26;
            label4.Text = "Tên thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(158, 272);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 25;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(1052, 272);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 24;
            label2.Text = "Hạn sử dụng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 33);
            label1.TabIndex = 23;
            label1.Text = "Quản lý thuốc";
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Font = new Font("Segoe UI", 12F);
            dtpHanSuDung.Location = new Point(1052, 300);
            dtpHanSuDung.Margin = new Padding(2);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(625, 39);
            dtpHanSuDung.TabIndex = 22;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 12F);
            txtDonViTinh.Location = new Point(158, 300);
            txtDonViTinh.Margin = new Padding(2);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(628, 39);
            txtDonViTinh.TabIndex = 21;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Font = new Font("Segoe UI", 12F);
            txtGiaBan.Location = new Point(158, 392);
            txtGiaBan.Margin = new Padding(2);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(628, 39);
            txtGiaBan.TabIndex = 20;
            // 
            // txtSoLuongTonKho
            // 
            txtSoLuongTonKho.Font = new Font("Segoe UI", 12F);
            txtSoLuongTonKho.Location = new Point(1052, 208);
            txtSoLuongTonKho.Margin = new Padding(2);
            txtSoLuongTonKho.Name = "txtSoLuongTonKho";
            txtSoLuongTonKho.Size = new Size(625, 39);
            txtSoLuongTonKho.TabIndex = 19;
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Segoe UI", 12F);
            txtTenThuoc.Location = new Point(158, 208);
            txtTenThuoc.Margin = new Padding(2);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(628, 39);
            txtTenThuoc.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold);
            label9.Location = new Point(158, 454);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 21);
            label9.TabIndex = 35;
            label9.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI", 12F);
            txtMoTa.Location = new Point(158, 481);
            txtMoTa.Margin = new Padding(2);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(628, 39);
            txtMoTa.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold);
            label10.Location = new Point(1052, 454);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(134, 21);
            label10.TabIndex = 37;
            label10.Text = "Hãng sản xuất";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold);
            label7.Location = new Point(1052, 365);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 39;
            label7.Text = "Loại thuốc ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9F, FontStyle.Bold);
            label11.Location = new Point(158, 531);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(128, 21);
            label11.TabIndex = 41;
            label11.Text = "Nhà cung cấp";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(1426, 635);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(312, 28);
            txtTimKiem.TabIndex = 42;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnSuaThuoc
            // 
            btnSuaThuoc.BackColor = Color.DodgerBlue;
            btnSuaThuoc.Location = new Point(841, 1265);
            btnSuaThuoc.Margin = new Padding(2);
            btnSuaThuoc.Name = "btnSuaThuoc";
            btnSuaThuoc.Size = new Size(161, 49);
            btnSuaThuoc.TabIndex = 47;
            btnSuaThuoc.Text = "Sửa thuốc";
            btnSuaThuoc.UseVisualStyleBackColor = false;
            btnSuaThuoc.Click += btnSuaThuoc_Click;
            // 
            // btnXoaThuoc
            // 
            btnXoaThuoc.BackColor = Color.DodgerBlue;
            btnXoaThuoc.Location = new Point(1577, 1265);
            btnXoaThuoc.Margin = new Padding(2);
            btnXoaThuoc.Name = "btnXoaThuoc";
            btnXoaThuoc.Size = new Size(161, 49);
            btnXoaThuoc.TabIndex = 46;
            btnXoaThuoc.Text = "Xóa thuốc";
            btnXoaThuoc.UseVisualStyleBackColor = false;
            btnXoaThuoc.Click += btnXoaThuoc_Click;
            // 
            // btnThemThuoc
            // 
            btnThemThuoc.BackColor = Color.DodgerBlue;
            btnThemThuoc.Location = new Point(78, 1265);
            btnThemThuoc.Margin = new Padding(2);
            btnThemThuoc.Name = "btnThemThuoc";
            btnThemThuoc.Size = new Size(161, 49);
            btnThemThuoc.TabIndex = 45;
            btnThemThuoc.Text = "Thêm thuốc";
            btnThemThuoc.UseVisualStyleBackColor = false;
            btnThemThuoc.Click += btnThemThuoc_Click;
            // 
            // cbLoaiThuoc
            // 
            cbLoaiThuoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLoaiThuoc.FormattingEnabled = true;
            cbLoaiThuoc.Location = new Point(1050, 392);
            cbLoaiThuoc.Margin = new Padding(2);
            cbLoaiThuoc.Name = "cbLoaiThuoc";
            cbLoaiThuoc.Size = new Size(629, 40);
            cbLoaiThuoc.TabIndex = 48;
            // 
            // cbHangSanXuat
            // 
            cbHangSanXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHangSanXuat.FormattingEnabled = true;
            cbHangSanXuat.Location = new Point(1048, 479);
            cbHangSanXuat.Margin = new Padding(2);
            cbHangSanXuat.Name = "cbHangSanXuat";
            cbHangSanXuat.Size = new Size(629, 40);
            cbHangSanXuat.TabIndex = 49;
            // 
            // cbNhaCungCap
            // 
            cbNhaCungCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNhaCungCap.FormattingEnabled = true;
            cbNhaCungCap.Location = new Point(158, 556);
            cbNhaCungCap.Margin = new Padding(2);
            cbNhaCungCap.Name = "cbNhaCungCap";
            cbNhaCungCap.Size = new Size(629, 40);
            cbNhaCungCap.TabIndex = 50;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(1048, 562);
            lblMaNhanVien.Margin = new Padding(2, 0, 2, 0);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(34, 32);
            lblMaNhanVien.TabIndex = 51;
            lblMaNhanVien.Text = "Id";
            // 
            // lblMaThuoc
            // 
            lblMaThuoc.AutoSize = true;
            lblMaThuoc.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblMaThuoc.Location = new Point(1050, 541);
            lblMaThuoc.Margin = new Padding(2, 0, 2, 0);
            lblMaThuoc.Name = "lblMaThuoc";
            lblMaThuoc.Size = new Size(89, 21);
            lblMaThuoc.TabIndex = 52;
            lblMaThuoc.Text = "Mã thuốc";
            // 
            // UserQuanLyThuoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblMaThuoc);
            Controls.Add(lblMaNhanVien);
            Controls.Add(cbNhaCungCap);
            Controls.Add(cbHangSanXuat);
            Controls.Add(cbLoaiThuoc);
            Controls.Add(btnSuaThuoc);
            Controls.Add(btnXoaThuoc);
            Controls.Add(btnThemThuoc);
            Controls.Add(txtTimKiem);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtMoTa);
            Controls.Add(label8);
            Controls.Add(dgvThuoc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpHanSuDung);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtGiaBan);
            Controls.Add(txtSoLuongTonKho);
            Controls.Add(txtTenThuoc);
            Margin = new Padding(2);
            Name = "UserQuanLyThuoc";
            Size = new Size(1828, 1340);
            Load += UserQuanLyThuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DataGridView dgvThuoc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpHanSuDung;
        private TextBox txtDonViTinh;
        private TextBox txtGiaBan;
        private TextBox txtSoLuongTonKho;
        private TextBox txtTenThuoc;
        private Label label9;
        private TextBox txtMoTa;
        private Label label10;
        private Label label7;
        private Label label11;
        private TextBox txtTimKiem;
        private Button btnSuaThuoc;
        private Button btnXoaThuoc;
        private Button btnThemThuoc;
        private ComboBox cbLoaiThuoc;
        private ComboBox cbHangSanXuat;
        private ComboBox cbNhaCungCap;
        private Label lblMaNhanVien;
        private Label lblMaThuoc;
    }
}
