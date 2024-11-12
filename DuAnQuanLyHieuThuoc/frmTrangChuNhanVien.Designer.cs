namespace DuAnQuanLyHieuThuoc
{
    partial class frmTrangChuNhanVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnQuanLyNhanVien = new Button();
            btnDoanhThu = new Button();
            btnQuanLyThuoc = new Button();
            btnQuanLyVoucher = new Button();
            btnQuanLyHoaDon = new Button();
            btnQuanLyNhapKho = new Button();
            btnQuanLyKhachHang = new Button();
            btnThongKe = new Button();
            pnShow = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnQuanLyNhanVien);
            panel1.Controls.Add(btnDoanhThu);
            panel1.Controls.Add(btnQuanLyThuoc);
            panel1.Controls.Add(btnQuanLyVoucher);
            panel1.Controls.Add(btnQuanLyHoaDon);
            panel1.Controls.Add(btnQuanLyNhapKho);
            panel1.Controls.Add(btnQuanLyKhachHang);
            panel1.Controls.Add(btnThongKe);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 1135);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(37, 251);
            label1.Name = "label1";
            label1.Size = new Size(439, 51);
            label1.TabIndex = 11;
            label1.Text = "Trang chủ nhân viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_employers_64;
            pictureBox1.Location = new Point(29, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.FlatStyle = FlatStyle.Popup;
            btnQuanLyNhanVien.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyNhanVien.Location = new Point(0, 457);
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(506, 82);
            btnQuanLyNhanVien.TabIndex = 9;
            btnQuanLyNhanVien.Text = "Bán hàng";
            btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            btnQuanLyNhanVien.Click += btnQuanLyNhanVien_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.FlatStyle = FlatStyle.Popup;
            btnDoanhThu.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDoanhThu.ForeColor = SystemColors.ButtonHighlight;
            btnDoanhThu.Location = new Point(0, 949);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(506, 82);
            btnDoanhThu.TabIndex = 4;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyThuoc
            // 
            btnQuanLyThuoc.FlatStyle = FlatStyle.Popup;
            btnQuanLyThuoc.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyThuoc.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyThuoc.Location = new Point(0, 539);
            btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            btnQuanLyThuoc.Size = new Size(506, 82);
            btnQuanLyThuoc.TabIndex = 8;
            btnQuanLyThuoc.Text = "Quản lý khách hàng";
            btnQuanLyThuoc.UseVisualStyleBackColor = true;
            btnQuanLyThuoc.Click += btnQuanLyThuoc_Click;
            // 
            // btnQuanLyVoucher
            // 
            btnQuanLyVoucher.FlatStyle = FlatStyle.Popup;
            btnQuanLyVoucher.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyVoucher.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyVoucher.Location = new Point(0, 867);
            btnQuanLyVoucher.Name = "btnQuanLyVoucher";
            btnQuanLyVoucher.Size = new Size(506, 82);
            btnQuanLyVoucher.TabIndex = 3;
            btnQuanLyVoucher.Text = "Quản lý voucher";
            btnQuanLyVoucher.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyHoaDon
            // 
            btnQuanLyHoaDon.FlatStyle = FlatStyle.Popup;
            btnQuanLyHoaDon.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyHoaDon.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyHoaDon.Location = new Point(0, 621);
            btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            btnQuanLyHoaDon.Size = new Size(506, 82);
            btnQuanLyHoaDon.TabIndex = 7;
            btnQuanLyHoaDon.Text = "Tra cứu thuốc";
            btnQuanLyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNhapKho
            // 
            btnQuanLyNhapKho.FlatStyle = FlatStyle.Popup;
            btnQuanLyNhapKho.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyNhapKho.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyNhapKho.Location = new Point(0, 703);
            btnQuanLyNhapKho.Name = "btnQuanLyNhapKho";
            btnQuanLyNhapKho.Size = new Size(506, 82);
            btnQuanLyNhapKho.TabIndex = 6;
            btnQuanLyNhapKho.Text = "Quản lý đơn lý đặt hàng";
            btnQuanLyNhapKho.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyKhachHang
            // 
            btnQuanLyKhachHang.FlatStyle = FlatStyle.Popup;
            btnQuanLyKhachHang.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyKhachHang.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyKhachHang.Location = new Point(0, 785);
            btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            btnQuanLyKhachHang.Size = new Size(506, 82);
            btnQuanLyKhachHang.TabIndex = 1;
            btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatStyle = FlatStyle.Popup;
            btnThongKe.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ButtonHighlight;
            btnThongKe.Location = new Point(0, 375);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(506, 82);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // pnShow
            // 
            pnShow.Location = new Point(507, 1);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(1308, 1135);
            pnShow.TabIndex = 2;
            // 
            // frmTrangChuNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1810, 1133);
            Controls.Add(pnShow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTrangChuNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTrangChuNhanVien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnQuanLyNhanVien;
        private Button btnDoanhThu;
        private Button btnQuanLyThuoc;
        private Button btnQuanLyVoucher;
        private Button btnQuanLyHoaDon;
        private Button btnQuanLyNhapKho;
        private Button btnQuanLyKhachHang;
        private Button btnThongKe;
        private Panel pnShow;
        private PictureBox pictureBox1;
        private Label label1;
    }
}