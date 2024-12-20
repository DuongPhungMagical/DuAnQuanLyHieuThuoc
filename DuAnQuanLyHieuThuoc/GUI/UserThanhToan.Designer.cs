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
            btnXuatHoaDon = new Button();
            dataGridView1 = new DataGridView();
            cbHinhThucThanhToan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(998, 362);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(219, 55);
            button1.TabIndex = 0;
            button1.Text = "Tạo mã";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbNganHang
            // 
            cbNganHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNganHang.FormattingEnabled = true;
            cbNganHang.Location = new Point(293, 165);
            cbNganHang.Margin = new Padding(2);
            cbNganHang.Name = "cbNganHang";
            cbNganHang.Size = new Size(278, 40);
            cbNganHang.TabIndex = 1;
            cbNganHang.Text = "Tên ngân hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 139);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 2;
            label1.Text = "Ngân hàng";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoTaiKhoan.Location = new Point(657, 168);
            txtSoTaiKhoan.Margin = new Padding(2);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(234, 39);
            txtSoTaiKhoan.TabIndex = 3;
            txtSoTaiKhoan.Text = "27012002999999";
            // 
            // cbTemplate
            // 
            cbTemplate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTemplate.FormattingEnabled = true;
            cbTemplate.Items.AddRange(new object[] { "compact", "compact2", "qr_only", "print" });
            cbTemplate.Location = new Point(939, 165);
            cbTemplate.Margin = new Padding(2);
            cbTemplate.Name = "cbTemplate";
            cbTemplate.Size = new Size(278, 40);
            cbTemplate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(939, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 6;
            label2.Text = "Template";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 139);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 7;
            label3.Text = "Số tài khoản";
            // 
            // txtSoTien
            // 
            txtSoTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoTien.Location = new Point(293, 299);
            txtSoTien.Margin = new Padding(2);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(278, 39);
            txtSoTien.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 271);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 9;
            label4.Text = "Số tiền";
            // 
            // txtThongTinThem
            // 
            txtThongTinThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThongTinThem.Location = new Point(939, 299);
            txtThongTinThem.Margin = new Padding(2);
            txtThongTinThem.Name = "txtThongTinThem";
            txtThongTinThem.Size = new Size(278, 39);
            txtThongTinThem.TabIndex = 10;
            txtThongTinThem.Text = "DuongPhungMH";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenTaiKhoan.Location = new Point(657, 299);
            txtTenTaiKhoan.Margin = new Padding(2);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(234, 39);
            txtTenTaiKhoan.TabIndex = 11;
            txtTenTaiKhoan.Text = "Phùng Văn Dương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(939, 271);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 12;
            label5.Text = "Thông tin thêm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(657, 271);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 13;
            label6.Text = "Tên tài khoản";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(1269, 165);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // btnXuatHoaDon
            // 
            btnXuatHoaDon.Location = new Point(998, 436);
            btnXuatHoaDon.Margin = new Padding(2);
            btnXuatHoaDon.Name = "btnXuatHoaDon";
            btnXuatHoaDon.Size = new Size(219, 55);
            btnXuatHoaDon.TabIndex = 15;
            btnXuatHoaDon.Text = "Xuất hóa đơn";
            btnXuatHoaDon.UseVisualStyleBackColor = true;
            btnXuatHoaDon.Click += btnXuatHoaDon_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 553);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1351, 601);
            dataGridView1.TabIndex = 16;
            // 
            // cbHinhThucThanhToan
            // 
            cbHinhThucThanhToan.FormattingEnabled = true;
            cbHinhThucThanhToan.Location = new Point(703, 384);
            cbHinhThucThanhToan.Name = "cbHinhThucThanhToan";
            cbHinhThucThanhToan.Size = new Size(188, 33);
            cbHinhThucThanhToan.TabIndex = 17;
            // 
            // UserThanhToan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbHinhThucThanhToan);
            Controls.Add(dataGridView1);
            Controls.Add(btnXuatHoaDon);
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
            Margin = new Padding(2);
            Name = "UserThanhToan";
            Size = new Size(1828, 1340);
            Load += UserThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btnXuatHoaDon;
        private DataGridView dataGridView1;
        private ComboBox cbHinhThucThanhToan;
    }
}
