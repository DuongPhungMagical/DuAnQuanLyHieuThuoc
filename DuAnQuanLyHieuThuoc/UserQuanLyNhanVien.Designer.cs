namespace DuAnQuanLyHieuThuoc
{
    partial class UserQuanLyNhanVien
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
            txtTenNhanVien = new TextBox();
            txtDiaChi = new TextBox();
            txtTuoi = new TextBox();
            txtSoDienThoai = new TextBox();
            dtpNgayVaoLam = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvNhanVien = new DataGridView();
            label8 = new Label();
            txtTimKiem = new TextBox();
            btnSuaNhanVien = new Button();
            btnChoNghiViec = new Button();
            btnThemNhanVien = new Button();
            lblMaNhanVien = new Label();
            cbTrangThai = new ComboBox();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI", 12F);
            txtTenNhanVien.Location = new Point(204, 267);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(403, 50);
            txtTenNhanVien.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(697, 267);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(400, 50);
            txtDiaChi.TabIndex = 2;
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI", 12F);
            txtTuoi.Location = new Point(204, 504);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(403, 50);
            txtTuoi.TabIndex = 4;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 12F);
            txtSoDienThoai.Location = new Point(204, 385);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(403, 50);
            txtSoDienThoai.TabIndex = 5;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Font = new Font("Segoe UI", 12F);
            dtpNgayVaoLam.Location = new Point(697, 385);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(400, 50);
            dtpNgayVaoLam.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(340, 44);
            label1.TabIndex = 8;
            label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(697, 350);
            label2.Name = "label2";
            label2.Size = new Size(167, 29);
            label2.TabIndex = 9;
            label2.Text = "Ngày vào làm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(204, 350);
            label3.Name = "label3";
            label3.Size = new Size(166, 29);
            label3.TabIndex = 10;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.Location = new Point(204, 232);
            label4.Name = "label4";
            label4.Size = new Size(176, 29);
            label4.TabIndex = 11;
            label4.Text = "Tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.Location = new Point(697, 232);
            label5.Name = "label5";
            label5.Size = new Size(92, 29);
            label5.TabIndex = 12;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold);
            label6.Location = new Point(204, 469);
            label6.Name = "label6";
            label6.Size = new Size(63, 29);
            label6.TabIndex = 13;
            label6.Text = "Tuổi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold);
            label7.Location = new Point(697, 469);
            label7.Name = "label7";
            label7.Size = new Size(167, 29);
            label7.TabIndex = 15;
            label7.Text = "Mã nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(96, 633);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 82;
            dgvNhanVien.Size = new Size(1161, 437);
            dgvNhanVien.TabIndex = 16;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold);
            label8.Location = new Point(96, 601);
            label8.Name = "label8";
            label8.Size = new Size(254, 29);
            label8.TabIndex = 17;
            label8.Text = "Danh sách nhân viên";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(854, 588);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(403, 39);
            txtTimKiem.TabIndex = 18;
            txtTimKiem.Click += txtTimKiem_Click;
            txtTimKiem.Leave += txtTimKiem_Leave;
            // 
            // btnSuaNhanVien
            // 
            btnSuaNhanVien.Location = new Point(565, 1100);
            btnSuaNhanVien.Name = "btnSuaNhanVien";
            btnSuaNhanVien.Size = new Size(210, 106);
            btnSuaNhanVien.TabIndex = 44;
            btnSuaNhanVien.Text = "Sửa nhân viên";
            btnSuaNhanVien.UseVisualStyleBackColor = true;
            btnSuaNhanVien.Click += btnSuaNhanVien_Click;
            // 
            // btnChoNghiViec
            // 
            btnChoNghiViec.Location = new Point(1047, 1100);
            btnChoNghiViec.Name = "btnChoNghiViec";
            btnChoNghiViec.Size = new Size(210, 106);
            btnChoNghiViec.TabIndex = 43;
            btnChoNghiViec.Text = "Cho nghỉ việc";
            btnChoNghiViec.UseVisualStyleBackColor = true;
            btnChoNghiViec.Click += btnChoNghiViec_Click;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Location = new Point(96, 1100);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(210, 106);
            btnThemNhanVien.TabIndex = 42;
            btnThemNhanVien.Text = "Thêm nhân viên";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaNhanVien.Location = new Point(697, 512);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(79, 42);
            lblMaNhanVien.TabIndex = 45;
            lblMaNhanVien.Text = "Mã ";
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(855, 512);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(242, 40);
            cbTrangThai.TabIndex = 46;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblTrangThai.Location = new Point(968, 469);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(129, 29);
            lblTrangThai.TabIndex = 47;
            lblTrangThai.Text = "Trạng thái";
            // 
            // UserQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTrangThai);
            Controls.Add(cbTrangThai);
            Controls.Add(lblMaNhanVien);
            Controls.Add(btnSuaNhanVien);
            Controls.Add(btnChoNghiViec);
            Controls.Add(btnThemNhanVien);
            Controls.Add(txtTimKiem);
            Controls.Add(label8);
            Controls.Add(dgvNhanVien);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpNgayVaoLam);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTuoi);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenNhanVien);
            Name = "UserQuanLyNhanVien";
            Size = new Size(1342, 1206);
            Load += UserQuanLyNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenNhanVien;
        private TextBox txtDiaChi;
        private TextBox txtTuoi;
        private TextBox txtSoDienThoai;
        private DateTimePicker dtpNgayVaoLam;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvNhanVien;
        private Label label8;
        private TextBox txtTimKiem;
        private Button btnSuaNhanVien;
        private Button btnChoNghiViec;
        private Button btnThemNhanVien;
        private Label lblMaNhanVien;
        private ComboBox cbTrangThai;
        private Label lblTrangThai;
    }
}
