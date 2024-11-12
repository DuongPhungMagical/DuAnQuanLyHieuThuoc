namespace DuAnQuanLyHieuThuoc
{
    partial class UserBanHang
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
            txtTimKiem = new TextBox();
            label1 = new Label();
            lbThuoc = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtTenThuoc = new TextBox();
            txtDonGia = new TextBox();
            txtIdThuoc = new TextBox();
            txtDonViTinh = new TextBox();
            dtpHanSuDung = new DateTimePicker();
            txtTongTien = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            btnXoa = new Button();
            txtTaoHoaDon = new Button();
            label8 = new Label();
            txtSoLuong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Arial", 10.875F);
            txtTimKiem.Location = new Point(3, 194);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(333, 41);
            txtTimKiem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 145);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // lbThuoc
            // 
            lbThuoc.FormattingEnabled = true;
            lbThuoc.Location = new Point(0, 258);
            lbThuoc.Name = "lbThuoc";
            lbThuoc.Size = new Size(336, 900);
            lbThuoc.TabIndex = 2;
            lbThuoc.SelectedIndexChanged += lbThuoc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(936, 145);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 3;
            label2.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 145);
            label3.Name = "label3";
            label3.Size = new Size(102, 32);
            label3.TabIndex = 4;
            label3.Text = "Id thuốc";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Arial", 10.875F);
            txtTenThuoc.Location = new Point(496, 347);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(333, 41);
            txtTenThuoc.TabIndex = 5;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Arial", 10.875F);
            txtDonGia.Location = new Point(936, 194);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(333, 41);
            txtDonGia.TabIndex = 6;
            // 
            // txtIdThuoc
            // 
            txtIdThuoc.Font = new Font("Arial", 10.875F);
            txtIdThuoc.Location = new Point(496, 194);
            txtIdThuoc.Name = "txtIdThuoc";
            txtIdThuoc.Size = new Size(333, 41);
            txtIdThuoc.TabIndex = 7;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Arial", 10.875F);
            txtDonViTinh.Location = new Point(936, 347);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.ReadOnly = true;
            txtDonViTinh.Size = new Size(333, 41);
            txtDonViTinh.TabIndex = 8;
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Font = new Font("Arial", 10.875F);
            dtpHanSuDung.Location = new Point(496, 472);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(400, 41);
            dtpHanSuDung.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Arial", 10.875F);
            txtTongTien.Location = new Point(496, 565);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(333, 41);
            txtTongTien.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(936, 437);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 11;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 426);
            label5.Name = "label5";
            label5.Size = new Size(151, 32);
            label5.TabIndex = 12;
            label5.Text = "Hạn sử dụng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(936, 303);
            label6.Name = "label6";
            label6.Size = new Size(133, 32);
            label6.TabIndex = 13;
            label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(496, 303);
            label7.Name = "label7";
            label7.Size = new Size(120, 32);
            label7.TabIndex = 14;
            label7.Text = "Tên thuốc";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(364, 623);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(921, 407);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.Location = new Point(1033, 554);
            button1.Name = "button1";
            button1.Size = new Size(252, 63);
            button1.TabIndex = 16;
            button1.Text = "Thêm vào giỏ hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.DodgerBlue;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnXoa.Location = new Point(364, 1047);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(252, 65);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTaoHoaDon
            // 
            txtTaoHoaDon.BackColor = Color.DodgerBlue;
            txtTaoHoaDon.FlatStyle = FlatStyle.Popup;
            txtTaoHoaDon.Font = new Font("Arial", 9F, FontStyle.Bold);
            txtTaoHoaDon.Location = new Point(1033, 1047);
            txtTaoHoaDon.Name = "txtTaoHoaDon";
            txtTaoHoaDon.Size = new Size(252, 65);
            txtTaoHoaDon.TabIndex = 18;
            txtTaoHoaDon.Text = "Tạo hóa đơn";
            txtTaoHoaDon.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(496, 530);
            label8.Name = "label8";
            label8.Size = new Size(219, 32);
            label8.TabIndex = 19;
            label8.Text = "Tổng tiền giỏ hàng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Arial", 10.875F);
            txtSoLuong.Location = new Point(936, 472);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(333, 41);
            txtSoLuong.TabIndex = 20;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // UserBanHang
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSoLuong);
            Controls.Add(label8);
            Controls.Add(txtTaoHoaDon);
            Controls.Add(btnXoa);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTongTien);
            Controls.Add(dtpHanSuDung);
            Controls.Add(txtDonViTinh);
            Controls.Add(txtIdThuoc);
            Controls.Add(txtDonGia);
            Controls.Add(txtTenThuoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbThuoc);
            Controls.Add(label1);
            Controls.Add(txtTimKiem);
            Name = "UserBanHang";
            Size = new Size(1308, 1135);
            Load += UserBanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimKiem;
        private Label label1;
        private ListBox lbThuoc;
        private Label label2;
        private Label label3;
        private TextBox txtTenThuoc;
        private TextBox txtDonGia;
        private TextBox txtIdThuoc;
        private TextBox txtDonViTinh;
        private DateTimePicker dtpHanSuDung;
        private TextBox txtTongTien;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btnXoa;
        private Button txtTaoHoaDon;
        private Label label8;
        private TextBox txtSoLuong;
    }
}
