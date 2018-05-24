using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYCUAHANG.CLASS;

namespace QUANLYCUAHANG
{
    public partial class frmFormMain : Form
    {
        public frmFormMain()
        {
            InitializeComponent();
        }
        public string quyen;
        public string TK
        {
            get { return quyen; }
            set { quyen = value; }
        }
        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien nv = new frmDMNhanVien();
            nv.ShowDialog();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang khach = new frmDMKhachHang();
            khach.ShowDialog();
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmChatlieu = new frmDMChatLieu(); 
            frmChatlieu.ShowDialog(); 
        }

        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa hang = new frmDMHangHoa();
            hang.ShowDialog();
        }

        private void mnuHoadon_Click(object sender, EventArgs e)
        {
            frmHoaDonBan hoadon = new frmHoaDonBan();
            hoadon.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { Application.Exit(); }
        }

        private void frmFormMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            if (quyen != "admin")
            {
                mnuAdmin.Visible = false;
            }
        }

        private void frmFormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dang = new frmDangNhap();
            dang.Show();
            this.Hide();

        }

        private void mnuTaikhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tai = new frmTaiKhoan();
            tai.ShowDialog();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      
    }
}
