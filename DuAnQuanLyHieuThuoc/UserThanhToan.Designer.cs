namespace DuAnQuanLyHieuThuoc
{
    partial class UserThanhToan
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
            button1 = new Button();
            cbNganHang = new ComboBox();
            label1 = new Label();
            txtSoTaiKhoan = new TextBox();
            cbTemplate = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtSoTien = new TextBox();
            label4 = new Label();
            txtThongTinThem = new TextBox();
            txtTenTaiKhoan = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(479, 756);
            button1.Name = "button1";
            button1.Size = new Size(285, 71);
            button1.TabIndex = 0;
            button1.Text = "Tạo mã";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbNganHang
            // 
            cbNganHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNganHang.FormattingEnabled = true;
            cbNganHang.Location = new Point(74, 116);
            cbNganHang.Name = "cbNganHang";
            cbNganHang.Size = new Size(360, 53);
            cbNganHang.TabIndex = 1;
            cbNganHang.Text = "Tên ngân hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 2;
            label1.Text = "Ngân hàng";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoTaiKhoan.Location = new Point(548, 119);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(303, 50);
            txtSoTaiKhoan.TabIndex = 3;
            txtSoTaiKhoan.Text = "27012002999999";
            // 
            // cbTemplate
            // 
            cbTemplate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTemplate.FormattingEnabled = true;
            cbTemplate.Items.AddRange(new object[] { "compact", "compact2", "qr_only", "print" });
            cbTemplate.Location = new Point(913, 116);
            cbTemplate.Name = "cbTemplate";
            cbTemplate.Size = new Size(360, 53);
            cbTemplate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(913, 81);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 6;
            label2.Text = "Template";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(548, 81);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 7;
            label3.Text = "Số tài khoản";
            // 
            // txtSoTien
            // 
            txtSoTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoTien.Location = new Point(74, 286);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(360, 50);
            txtSoTien.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 251);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 9;
            label4.Text = "Số tiền";
            // 
            // txtThongTinThem
            // 
            txtThongTinThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThongTinThem.Location = new Point(913, 286);
            txtThongTinThem.Name = "txtThongTinThem";
            txtThongTinThem.Size = new Size(360, 50);
            txtThongTinThem.TabIndex = 10;
            txtThongTinThem.Text = "DuongPhungMH";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenTaiKhoan.Location = new Point(548, 286);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(303, 50);
            txtTenTaiKhoan.TabIndex = 11;
            txtTenTaiKhoan.Text = "Phùng Văn Dương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(913, 251);
            label5.Name = "label5";
            label5.Size = new Size(181, 32);
            label5.TabIndex = 12;
            label5.Text = "Thông tin thêm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(548, 251);
            label6.Name = "label6";
            label6.Size = new Size(158, 32);
            label6.TabIndex = 13;
            label6.Text = "Tên tài khoản";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(819, 410);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // UserThanhToan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTenTaiKhoan);
            Controls.Add(txtThongTinThem);
            Controls.Add(label4);
            Controls.Add(txtSoTien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbTemplate);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(label1);
            Controls.Add(cbNganHang);
            Controls.Add(button1);
            Name = "UserThanhToan";
            Size = new Size(1342, 1206);
            Load += UserThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox cbNganHang;
        private Label label1;
        private TextBox txtSoTaiKhoan;
        private ComboBox cbTemplate;
        private Label label2;
        private Label label3;
        private TextBox txtSoTien;
        private Label label4;
        private TextBox txtThongTinThem;
        private TextBox txtTenTaiKhoan;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
