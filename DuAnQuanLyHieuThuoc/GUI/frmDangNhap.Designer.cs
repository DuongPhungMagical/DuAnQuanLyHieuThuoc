namespace DuAnQuanLyHieuThuoc
{
    partial class frmDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            txtTaiKhoan = new TextBox();
            panel2 = new Panel();
            txtMatKhau = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnDangNhap = new Button();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblQuenMatKhau = new Label();
            lblDangKi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_login_100;
            pictureBox1.Location = new Point(299, 115);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Arial", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(299, 344);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 66);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Location = new Point(202, 495);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 4);
            panel1.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.ForeColor = SystemColors.WindowText;
            txtTaiKhoan.Location = new Point(202, 454);
            txtTaiKhoan.Margin = new Padding(2);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(432, 44);
            txtTaiKhoan.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumAquamarine;
            panel2.Location = new Point(202, 565);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 4);
            panel2.TabIndex = 6;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = SystemColors.WindowText;
            txtMatKhau.Location = new Point(202, 524);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(432, 44);
            txtMatKhau.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_100;
            pictureBox2.Location = new Point(110, 434);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_password_100;
            pictureBox3.Location = new Point(110, 524);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.MediumAquamarine;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Blue;
            btnDangNhap.Location = new Point(245, 610);
            btnDangNhap.Margin = new Padding(2);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(321, 65);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Login";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(691, 900);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 30);
            label2.TabIndex = 9;
            label2.Text = "Exit";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumAquamarine;
            panel3.Location = new Point(92, 739);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 1);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumAquamarine;
            panel4.Location = new Point(368, 739);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 1);
            panel4.TabIndex = 6;
            // 
            // lblQuenMatKhau
            // 
            lblQuenMatKhau.AutoSize = true;
            lblQuenMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuenMatKhau.ForeColor = Color.MediumAquamarine;
            lblQuenMatKhau.Location = new Point(408, 696);
            lblQuenMatKhau.Margin = new Padding(2, 0, 2, 0);
            lblQuenMatKhau.Name = "lblQuenMatKhau";
            lblQuenMatKhau.Size = new Size(153, 25);
            lblQuenMatKhau.TabIndex = 10;
            lblQuenMatKhau.Text = "Forgot password";
            // 
            // lblDangKi
            // 
            lblDangKi.AutoSize = true;
            lblDangKi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDangKi.ForeColor = Color.MediumAquamarine;
            lblDangKi.Location = new Point(245, 696);
            lblDangKi.Margin = new Padding(2, 0, 2, 0);
            lblDangKi.Name = "lblDangKi";
            lblDangKi.Size = new Size(82, 25);
            lblDangKi.TabIndex = 11;
            lblDangKi.Text = "Register";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(761, 942);
            Controls.Add(lblDangKi);
            Controls.Add(lblQuenMatKhau);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(btnDangNhap);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(txtMatKhau);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(txtTaiKhoan);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox txtTaiKhoan;
        private Panel panel2;
        private TextBox txtMatKhau;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnDangNhap;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Label lblQuenMatKhau;
        private Label lblDangKi;
    }
}
