namespace QUANLYCUAHANG
{
    partial class frmFormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatlieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHanghoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuAdmin,
            this.mnuKhachhang,
            this.mnuChatlieu,
            this.mnuHanghoa,
            this.mnuHoadon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1060, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuHeThong.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(134, 34);
            this.mnuHeThong.Text = "HỆ THỐNG";
            this.mnuHeThong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(206, 34);
            this.mnuDangXuat.Text = "ĐĂNG XUẤT";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(206, 34);
            this.mnuThoat.Text = "THOÁT";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaikhoan,
            this.mnuNhanvien});
            this.mnuAdmin.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(96, 34);
            this.mnuAdmin.Text = "ADMIN";
            // 
            // mnuTaikhoan
            // 
            this.mnuTaikhoan.Name = "mnuTaikhoan";
            this.mnuTaikhoan.Size = new System.Drawing.Size(201, 34);
            this.mnuTaikhoan.Text = "TÀI KHOẢN";
            this.mnuTaikhoan.Click += new System.EventHandler(this.mnuTaikhoan_Click);
            // 
            // mnuNhanvien
            // 
            this.mnuNhanvien.Name = "mnuNhanvien";
            this.mnuNhanvien.Size = new System.Drawing.Size(201, 34);
            this.mnuNhanvien.Text = "NHÂN VIÊN";
            this.mnuNhanvien.Click += new System.EventHandler(this.mnuNhanvien_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuKhachhang.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(165, 34);
            this.mnuKhachhang.Text = "KHÁCH HÀNG";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuChatlieu
            // 
            this.mnuChatlieu.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuChatlieu.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuChatlieu.Name = "mnuChatlieu";
            this.mnuChatlieu.Size = new System.Drawing.Size(129, 34);
            this.mnuChatlieu.Text = "CHẤT LIỆU";
            this.mnuChatlieu.Click += new System.EventHandler(this.mnuChatlieu_Click);
            // 
            // mnuHanghoa
            // 
            this.mnuHanghoa.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuHanghoa.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuHanghoa.Name = "mnuHanghoa";
            this.mnuHanghoa.Size = new System.Drawing.Size(138, 34);
            this.mnuHanghoa.Text = "HÀNG HÓA";
            this.mnuHanghoa.Click += new System.EventHandler(this.mnuHanghoa_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.BackColor = System.Drawing.Color.Gainsboro;
            this.mnuHoadon.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(125, 34);
            this.mnuHoadon.Text = "HÓA ĐƠN";
            this.mnuHoadon.Click += new System.EventHandler(this.mnuHoadon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 504);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 439);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CỬA HÀNG VẬT LIỆU XÂY DỰNG THANH HẰNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý cửa hàng vật liệu xây dựng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFormMain_FormClosed);
            this.Load += new System.EventHandler(this.frmFormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuChatlieu;
        private System.Windows.Forms.ToolStripMenuItem mnuHanghoa;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}