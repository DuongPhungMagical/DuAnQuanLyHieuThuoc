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
            panel1.Location = new Point(-4, 1);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 1071);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(23, 157);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 11;
            label1.Text = "Trang chủ nhân viên";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_employers_64;
            pictureBox1.Location = new Point(18, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.FlatStyle = FlatStyle.Popup;
            btnQuanLyNhanVien.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyNhanVien.Location = new Point(5, 322);
            btnQuanLyNhanVien.Margin = new Padding(2);
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(311, 51);
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
            btnDoanhThu.Location = new Point(5, 883);
            btnDoanhThu.Margin = new Padding(2);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(311, 51);
            btnDoanhThu.TabIndex = 4;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyThuoc
            // 
            btnQuanLyThuoc.FlatStyle = FlatStyle.Popup;
            btnQuanLyThuoc.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyThuoc.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyThuoc.Location = new Point(0, 408);
            btnQuanLyThuoc.Margin = new Padding(2);
            btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            btnQuanLyThuoc.Size = new Size(311, 51);
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
            btnQuanLyVoucher.Location = new Point(3, 796);
            btnQuanLyVoucher.Margin = new Padding(2);
            btnQuanLyVoucher.Name = "btnQuanLyVoucher";
            btnQuanLyVoucher.Size = new Size(311, 51);
            btnQuanLyVoucher.TabIndex = 3;
            btnQuanLyVoucher.Text = "Quản lý voucher";
            btnQuanLyVoucher.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyHoaDon
            // 
            btnQuanLyHoaDon.FlatStyle = FlatStyle.Popup;
            btnQuanLyHoaDon.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyHoaDon.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyHoaDon.Location = new Point(5, 509);
            btnQuanLyHoaDon.Margin = new Padding(2);
            btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            btnQuanLyHoaDon.Size = new Size(311, 51);
            btnQuanLyHoaDon.TabIndex = 7;
            btnQuanLyHoaDon.Text = "Tra cứu thuốc";
            btnQuanLyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNhapKho
            // 
            btnQuanLyNhapKho.FlatStyle = FlatStyle.Popup;
            btnQuanLyNhapKho.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyNhapKho.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyNhapKho.Location = new Point(5, 601);
            btnQuanLyNhapKho.Margin = new Padding(2);
            btnQuanLyNhapKho.Name = "btnQuanLyNhapKho";
            btnQuanLyNhapKho.Size = new Size(311, 51);
            btnQuanLyNhapKho.TabIndex = 6;
            btnQuanLyNhapKho.Text = "Quản lý đơn lý đặt hàng";
            btnQuanLyNhapKho.UseVisualStyleBackColor = true;
            btnQuanLyNhapKho.Click += btnQuanLyNhapKho_Click;
            // 
            // btnQuanLyKhachHang
            // 
            btnQuanLyKhachHang.FlatStyle = FlatStyle.Popup;
            btnQuanLyKhachHang.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyKhachHang.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyKhachHang.Location = new Point(5, 701);
            btnQuanLyKhachHang.Margin = new Padding(2);
            btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            btnQuanLyKhachHang.Size = new Size(311, 51);
            btnQuanLyKhachHang.TabIndex = 1;
            btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatStyle = FlatStyle.Popup;
            btnThongKe.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ButtonHighlight;
            btnThongKe.Location = new Point(0, 234);
            btnThongKe.Margin = new Padding(2);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(311, 51);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // pnShow
            // 
            pnShow.Location = new Point(312, 1);
            pnShow.Margin = new Padding(2);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(1452, 1071);
            pnShow.TabIndex = 2;
            pnShow.Paint += pnShow_Paint;
            // 
            // frmTrangChuNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1763, 1071);
            Controls.Add(pnShow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
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