namespace WindowsFormsApp_B8
{
    partial class Form1
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
            this.groupBoxNhapTT = new System.Windows.Forms.GroupBox();
            this.btnThemSinhVien = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvDanhSachSV = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.MaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxNhapTT.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNhapTT
            // 
            this.groupBoxNhapTT.Controls.Add(this.btnThemSinhVien);
            this.groupBoxNhapTT.Controls.Add(this.dtpNgaySinh);
            this.groupBoxNhapTT.Controls.Add(this.txtQueQuan);
            this.groupBoxNhapTT.Controls.Add(this.cbGioiTinh);
            this.groupBoxNhapTT.Controls.Add(this.txtMaLop);
            this.groupBoxNhapTT.Controls.Add(this.txtTenSV);
            this.groupBoxNhapTT.Controls.Add(this.label5);
            this.groupBoxNhapTT.Controls.Add(this.label4);
            this.groupBoxNhapTT.Controls.Add(this.label3);
            this.groupBoxNhapTT.Controls.Add(this.label2);
            this.groupBoxNhapTT.Controls.Add(this.label1);
            this.groupBoxNhapTT.Controls.Add(this.txtMaSV);
            this.groupBoxNhapTT.Controls.Add(this.lbMaSV);
            this.groupBoxNhapTT.Location = new System.Drawing.Point(0, 43);
            this.groupBoxNhapTT.Name = "groupBoxNhapTT";
            this.groupBoxNhapTT.Size = new System.Drawing.Size(306, 395);
            this.groupBoxNhapTT.TabIndex = 0;
            this.groupBoxNhapTT.TabStop = false;
            this.groupBoxNhapTT.Text = "Nhập thông tin";
            // 
            // btnThemSinhVien
            // 
            this.btnThemSinhVien.Location = new System.Drawing.Point(22, 354);
            this.btnThemSinhVien.Name = "btnThemSinhVien";
            this.btnThemSinhVien.Size = new System.Drawing.Size(253, 25);
            this.btnThemSinhVien.TabIndex = 14;
            this.btnThemSinhVien.Text = "Thêm sinh viên";
            this.btnThemSinhVien.UseVisualStyleBackColor = true;
            this.btnThemSinhVien.Click += new System.EventHandler(this.btnThemSinhVien_Click_1);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(117, 199);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(158, 26);
            this.dtpNgaySinh.TabIndex = 13;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(117, 254);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(158, 26);
            this.txtQueQuan.TabIndex = 8;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(117, 144);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(158, 28);
            this.cbGioiTinh.TabIndex = 12;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(117, 309);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(158, 26);
            this.txtMaLop.TabIndex = 11;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(117, 87);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(158, 26);
            this.txtTenSV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giới tính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(117, 35);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(158, 26);
            this.txtMaSV.TabIndex = 1;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(9, 38);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(96, 20);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "Mã sinh viên";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.lsvDanhSachSV);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(312, 42);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(486, 386);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách sinh viên";
            // 
            // lsvDanhSachSV
            // 
            this.lsvDanhSachSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.NgaySinh,
            this.QueQuan,
            this.MaLop});
            this.lsvDanhSachSV.HideSelection = false;
            this.lsvDanhSachSV.Location = new System.Drawing.Point(15, 25);
            this.lsvDanhSachSV.Name = "lsvDanhSachSV";
            this.lsvDanhSachSV.Size = new System.Drawing.Size(461, 355);
            this.lsvDanhSachSV.TabIndex = 1;
            this.lsvDanhSachSV.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSachSV.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thêm dữ liệu không dùng Paramater";
            // 
            // MaSV
            // 
            this.MaSV.Text = "MaSV";
            this.MaSV.Width = 67;
            // 
            // TenSV
            // 
            this.TenSV.Text = "TenSV";
            this.TenSV.Width = 79;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Text = "GioiTinh";
            this.GioiTinh.Width = 84;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Text = "NgaySinh";
            this.NgaySinh.Width = 70;
            // 
            // QueQuan
            // 
            this.QueQuan.Text = "QueQuan";
            this.QueQuan.Width = 76;
            // 
            // MaLop
            // 
            this.MaLop.Text = "MaLop";
            this.MaLop.Width = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxNhapTT);
            this.Name = "Form1";
            this.Text = "Thêm dữ liệu không dùng Parameter";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBoxNhapTT.ResumeLayout(false);
            this.groupBoxNhapTT.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNhapTT;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.Button btnThemSinhVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lsvDanhSachSV;
        private System.Windows.Forms.ColumnHeader MaSV;
        private System.Windows.Forms.ColumnHeader TenSV;
        private System.Windows.Forms.ColumnHeader GioiTinh;
        private System.Windows.Forms.ColumnHeader NgaySinh;
        private System.Windows.Forms.ColumnHeader QueQuan;
        private System.Windows.Forms.ColumnHeader MaLop;
    }
}

