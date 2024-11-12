namespace DuAnQuanLyHieuThuoc
{
    partial class frmTrangChuAdmin
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
            button3 = new Button();
            btnDoanhThu = new Button();
            btnQuanLyThuoc = new Button();
            btnQuanLyVoucher = new Button();
            btnQuanLyHoaDon = new Button();
            btnQuanLyNhapKho = new Button();
            button6 = new Button();
            btnQuanLyKhachHang = new Button();
            btnThongKe = new Button();
            pnShow = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnQuanLyNhanVien);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnDoanhThu);
            panel1.Controls.Add(btnQuanLyThuoc);
            panel1.Controls.Add(btnQuanLyVoucher);
            panel1.Controls.Add(btnQuanLyHoaDon);
            panel1.Controls.Add(btnQuanLyNhapKho);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btnQuanLyKhachHang);
            panel1.Controls.Add(btnThongKe);
            panel1.Location = new Point(-12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 1206);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(64, 213);
            label1.Name = "label1";
            label1.Size = new Size(390, 51);
            label1.TabIndex = 11;
            label1.Text = "Trang chủ quản lý";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_administrator_94;
            pictureBox1.Location = new Point(35, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(439, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnQuanLyNhanVien
            // 
            btnQuanLyNhanVien.BackColor = Color.Black;
            btnQuanLyNhanVien.FlatStyle = FlatStyle.Popup;
            btnQuanLyNhanVien.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyNhanVien.Location = new Point(11, 406);
            btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            btnQuanLyNhanVien.Size = new Size(495, 82);
            btnQuanLyNhanVien.TabIndex = 9;
            btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            btnQuanLyNhanVien.Click += btnQuanLyNhanVien_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(11, 1062);
            button3.Name = "button3";
            button3.Size = new Size(495, 82);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.BackColor = Color.Black;
            btnDoanhThu.FlatStyle = FlatStyle.Popup;
            btnDoanhThu.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDoanhThu.ForeColor = SystemColors.ButtonHighlight;
            btnDoanhThu.Location = new Point(11, 898);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(495, 82);
            btnDoanhThu.TabIndex = 4;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyThuoc
            // 
            btnQuanLyThuoc.BackColor = Color.Black;
            btnQuanLyThuoc.FlatStyle = FlatStyle.Popup;
            btnQuanLyThuoc.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyThuoc.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyThuoc.Location = new Point(11, 488);
            btnQuanLyThuoc.Name = "btnQuanLyThuoc";
            btnQuanLyThuoc.Size = new Size(495, 82);
            btnQuanLyThuoc.TabIndex = 8;
            btnQuanLyThuoc.Text = "Quản lý thuốc";
            btnQuanLyThuoc.UseVisualStyleBackColor = false;
            btnQuanLyThuoc.Click += btnQuanLyThuoc_Click;
            // 
            // btnQuanLyVoucher
            // 
            btnQuanLyVoucher.BackColor = Color.Black;
            btnQuanLyVoucher.FlatStyle = FlatStyle.Popup;
            btnQuanLyVoucher.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyVoucher.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyVoucher.Location = new Point(11, 816);
            btnQuanLyVoucher.Name = "btnQuanLyVoucher";
            btnQuanLyVoucher.Size = new Size(495, 82);
            btnQuanLyVoucher.TabIndex = 3;
            btnQuanLyVoucher.Text = "Quản lý voucher";
            btnQuanLyVoucher.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyHoaDon
            // 
            btnQuanLyHoaDon.BackColor = Color.Black;
            btnQuanLyHoaDon.FlatStyle = FlatStyle.Popup;
            btnQuanLyHoaDon.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyHoaDon.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyHoaDon.Location = new Point(11, 570);
            btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            btnQuanLyHoaDon.Size = new Size(495, 82);
            btnQuanLyHoaDon.TabIndex = 7;
            btnQuanLyHoaDon.Text = "Quản lý hóa đơn";
            btnQuanLyHoaDon.UseVisualStyleBackColor = false;
            btnQuanLyHoaDon.Click += btnQuanLyHoaDon_Click;
            // 
            // btnQuanLyNhapKho
            // 
            btnQuanLyNhapKho.BackColor = Color.Black;
            btnQuanLyNhapKho.FlatStyle = FlatStyle.Popup;
            btnQuanLyNhapKho.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyNhapKho.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyNhapKho.Location = new Point(11, 652);
            btnQuanLyNhapKho.Name = "btnQuanLyNhapKho";
            btnQuanLyNhapKho.Size = new Size(495, 82);
            btnQuanLyNhapKho.TabIndex = 6;
            btnQuanLyNhapKho.Text = "Quản lý kho";
            btnQuanLyNhapKho.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Arial", 12F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(11, 980);
            button6.Name = "button6";
            button6.Size = new Size(495, 82);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyKhachHang
            // 
            btnQuanLyKhachHang.BackColor = Color.Black;
            btnQuanLyKhachHang.FlatStyle = FlatStyle.Popup;
            btnQuanLyKhachHang.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnQuanLyKhachHang.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyKhachHang.Location = new Point(11, 734);
            btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            btnQuanLyKhachHang.Size = new Size(495, 82);
            btnQuanLyKhachHang.TabIndex = 1;
            btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            btnQuanLyKhachHang.UseVisualStyleBackColor = false;
            btnQuanLyKhachHang.Click += btnQuanLyKhachHang_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Black;
            btnThongKe.FlatStyle = FlatStyle.Popup;
            btnThongKe.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnThongKe.ForeColor = SystemColors.ButtonHighlight;
            btnThongKe.Location = new Point(11, 324);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(495, 82);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            // 
            // pnShow
            // 
            pnShow.Location = new Point(493, -1);
            pnShow.Name = "pnShow";
            pnShow.Size = new Size(1342, 1206);
            pnShow.TabIndex = 1;
            pnShow.Paint += pnShow_Paint;
            // 
            // frmTrangChuAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 1204);
            Controls.Add(pnShow);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTrangChuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThongKe;
        private Button btnQuanLyNhanVien;
        private Button button3;
        private Button btnDoanhThu;
        private Button btnQuanLyThuoc;
        private Button btnQuanLyVoucher;
        private Button btnQuanLyHoaDon;
        private Button btnQuanLyNhapKho;
        private Button button6;
        private Button btnQuanLyKhachHang;
        private Panel pnShow;
        private PictureBox pictureBox1;
        private Label label1;
    }
}