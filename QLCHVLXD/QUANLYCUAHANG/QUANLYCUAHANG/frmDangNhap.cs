using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYCUAHANG
{
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo");
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo");
                txtMatKhau.Focus();
                return;
            }
            
                string sql = @"Server=DELL-PC\SQLEXPRESS;Database=QLCHVLXD;Trusted_Connection=True;";
                SqlConnection con = new SqlConnection(sql);
                con.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                SqlCommand comm = new SqlCommand("Select * From TAIKHOAN Where  ID = N'" + tk + "'And PASS = N'" + mk + "'", con);
                SqlDataReader read = comm.ExecuteReader();
                while (read.Read())
                {

                    frmFormMain m = new frmFormMain();
                    m.TK = txtTaiKhoan.Text;
                    m.Show();
                    this.Hide();


                }
               
            
            


        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;


        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
