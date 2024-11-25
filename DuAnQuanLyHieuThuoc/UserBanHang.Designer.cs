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
            bntTaoHoaDon = new Button();
            label8 = new Label();
            txtSoLuong = new TextBox();
            txtSDT = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtTenKH = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Arial", 10.875F);
            txtTimKiem.Location = new Point(2, 151);
            txtTimKiem.Margin = new Padding(2);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(348, 33);
            txtTimKiem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 114);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // lbThuoc
            // 
            lbThuoc.FormattingEnabled = true;
            lbThuoc.ItemHeight = 25;
            lbThuoc.Location = new Point(0, 201);
            lbThuoc.Margin = new Padding(2);
            lbThuoc.Name = "lbThuoc";
            lbThuoc.Size = new Size(350, 1029);
            lbThuoc.TabIndex = 2;
            lbThuoc.SelectedIndexChanged += lbThuoc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(875, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 3;
            label2.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 114);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Id thuốc";
            // 
            // txtTenThuoc
            // 
            txtTenThuoc.Font = new Font("Arial", 10.875F);
            txtTenThuoc.Location = new Point(381, 271);
            txtTenThuoc.Margin = new Padding(2);
            txtTenThuoc.Name = "txtTenThuoc";
            txtTenThuoc.Size = new Size(400, 33);
            txtTenThuoc.TabIndex = 5;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Arial", 10.875F);
            txtDonGia.Location = new Point(875, 151);
            txtDonGia.Margin = new Padding(2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(380, 33);
            txtDonGia.TabIndex = 6;
            // 
            // txtIdThuoc
            // 
            txtIdThuoc.Font = new Font("Arial", 10.875F);
            txtIdThuoc.Location = new Point(381, 151);
            txtIdThuoc.Margin = new Padding(2);
            txtIdThuoc.Name = "txtIdThuoc";
            txtIdThuoc.Size = new Size(400, 33);
            txtIdThuoc.TabIndex = 7;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Arial", 10.875F);
            txtDonViTinh.Location = new Point(875, 271);
            txtDonViTinh.Margin = new Padding(2);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.ReadOnly = true;
            txtDonViTinh.Size = new Size(380, 33);
            txtDonViTinh.TabIndex = 8;
            // 
            // dtpHanSuDung
            // 
            dtpHanSuDung.Font = new Font("Arial", 10.875F);
            dtpHanSuDung.Location = new Point(381, 369);
            dtpHanSuDung.Margin = new Padding(2);
            dtpHanSuDung.Name = "dtpHanSuDung";
            dtpHanSuDung.Size = new Size(400, 33);
            dtpHanSuDung.TabIndex = 9;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Arial", 10.875F);
            txtTongTien.Location = new Point(1344, 369);
            txtTongTien.Margin = new Padding(2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(365, 33);
            txtTongTien.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(875, 341);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 11;
            label4.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 332);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 12;
            label5.Text = "Hạn sử dụng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(875, 236);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 13;
            label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 236);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 14;
            label7.Text = "Tên thuốc";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 486);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1389, 674);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold);
            button1.Location = new Point(1576, 428);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(194, 49);
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
            btnXoa.Location = new Point(381, 1180);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(194, 51);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // bntTaoHoaDon
            // 
            bntTaoHoaDon.BackColor = Color.DodgerBlue;
            bntTaoHoaDon.FlatStyle = FlatStyle.Popup;
            bntTaoHoaDon.Font = new Font("Arial", 9F, FontStyle.Bold);
            bntTaoHoaDon.Location = new Point(1576, 1180);
            bntTaoHoaDon.Margin = new Padding(2);
            bntTaoHoaDon.Name = "bntTaoHoaDon";
            bntTaoHoaDon.Size = new Size(194, 51);
            bntTaoHoaDon.TabIndex = 18;
            bntTaoHoaDon.Text = "Thanh toán";
            bntTaoHoaDon.UseVisualStyleBackColor = false;
            bntTaoHoaDon.Click += bntTaoHoaDon_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1344, 341);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 19;
            label8.Text = "Tổng tiền giỏ hàng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Arial", 10.875F);
            txtSoLuong.Location = new Point(875, 369);
            txtSoLuong.Margin = new Padding(2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(380, 33);
            txtSoLuong.TabIndex = 20;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Arial", 10.875F);
            txtSDT.Location = new Point(1344, 151);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(365, 33);
            txtSDT.TabIndex = 21;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1344, 114);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(145, 25);
            label9.TabIndex = 22;
            label9.Text = "Số điện thoại KH";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1344, 234);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(134, 25);
            label10.TabIndex = 24;
            label10.Text = "Tên khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.AcceptsReturn = true;
            txtTenKH.Font = new Font("Arial", 10.875F);
            txtTenKH.Location = new Point(1344, 271);
            txtTenKH.Margin = new Padding(2);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(365, 33);
            txtTenKH.TabIndex = 23;
            // 
            // UserBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label10);
            Controls.Add(txtTenKH);
            Controls.Add(label9);
            Controls.Add(txtSDT);
            Controls.Add(txtSoLuong);
            Controls.Add(label8);
            Controls.Add(bntTaoHoaDon);
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
            Margin = new Padding(2);
            Name = "UserBanHang";
            Size = new Size(1828, 1340);
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
        private Button bntTaoHoaDon;
        private Label label8;
        private TextBox txtSoLuong;
        private TextBox txtSDT;
        private Label label9;
        private Label label10;
        private TextBox txtTenKH;
    }
}
