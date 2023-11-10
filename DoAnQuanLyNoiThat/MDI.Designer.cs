namespace DoAnQuanLyNoiThat
{
    partial class MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QuanLySanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyDonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuanLySanPham,
            this.QuanLyDonHang,
            this.QuanLyKhachHang,
            this.QuanLyNhanVien,
            this.QuanLyTaiKhoan,
            this.thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QuanLySanPham
            // 
            this.QuanLySanPham.Name = "QuanLySanPham";
            this.QuanLySanPham.Size = new System.Drawing.Size(144, 24);
            this.QuanLySanPham.Text = "Quản Lý Sản Phẩm";
            this.QuanLySanPham.Click += new System.EventHandler(this.QuanLySanPham_Click);
            // 
            // QuanLyDonHang
            // 
            this.QuanLyDonHang.Name = "QuanLyDonHang";
            this.QuanLyDonHang.Size = new System.Drawing.Size(147, 24);
            this.QuanLyDonHang.Text = "Quản Lý Đơn Hàng";
            this.QuanLyDonHang.Click += new System.EventHandler(this.QuanLyDonHang_Click);
            // 
            // QuanLyKhachHang
            // 
            this.QuanLyKhachHang.Name = "QuanLyKhachHang";
            this.QuanLyKhachHang.Size = new System.Drawing.Size(159, 24);
            this.QuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.QuanLyKhachHang.Click += new System.EventHandler(this.QuanLyKhachHang_Click);
            // 
            // QuanLyNhanVien
            // 
            this.QuanLyNhanVien.Name = "QuanLyNhanVien";
            this.QuanLyNhanVien.Size = new System.Drawing.Size(147, 24);
            this.QuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.QuanLyNhanVien.Click += new System.EventHandler(this.QuanLyNhanVien_Click);
            // 
            // QuanLyTaiKhoan
            // 
            this.QuanLyTaiKhoan.Name = "QuanLyTaiKhoan";
            this.QuanLyTaiKhoan.Size = new System.Drawing.Size(143, 24);
            this.QuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.QuanLyTaiKhoan.Click += new System.EventHandler(this.QuanLyTaiKhoan_Click);
            // 
            // thoat
            // 
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(61, 24);
            this.thoat.Text = "Thoát";
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chào Mừng Đến Với Cửa Hàng Nội Thất";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(519, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 323);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnQuanLyNoiThat.Properties.Resources.TrangChu1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 160);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liên Hệ : 18001002";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(893, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.MDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QuanLySanPham;
        private System.Windows.Forms.ToolStripMenuItem QuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem QuanLyDonHang;
        private System.Windows.Forms.ToolStripMenuItem QuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem QuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}