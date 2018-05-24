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
using QUANLYCUAHANG.CLASS;

namespace QUANLYCUAHANG
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        DataTable tblCL;
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM TAIKHOAN";
            tblCL = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            DataGridView.DataSource = tblCL; //Nguồn dữ liệu            
            DataGridView.Columns[0].HeaderText = "Tài khoản";
            DataGridView.Columns[1].HeaderText = "Mật khẩu";
            DataGridView.Columns[2].HeaderText = "Quyền";
            DataGridView.Columns[0].Width = 180;
            DataGridView.Columns[1].Width = 180;
            DataGridView.Columns[2].Width = 180;
            DataGridView.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            LoadDataGridView();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return;
            }
             if (txtPASS.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPASS.Focus();
                return;
            }
             //Kiểm tra đã tồn tại tài khoản
             sql = "SELECT ID FROM TAIKHOAN WHERE ID=N'" + txtID.Text.Trim() + "'";
             if (Functions.CheckKey(sql))
             {
                 MessageBox.Show("Tài khoản này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 txtID.Focus();
                 return;
             }
             //Chèn thêm
             string s = "USER";
             sql = "INSERT INTO TAIKHOAN VALUES (N'" + txtID.Text.Trim() + "',N'" + txtPASS.Text.Trim()+ "','"+s+"')";
             Functions.RunSQL(sql);
             MessageBox.Show("Thêm tài khoản người dùng thành công", "Thông báo");
             txtID.Text = "";
             txtPASS.Text = "";
             LoadDataGridView();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox1.Text = DataGridView.CurrentRow.Cells["ID"].Value.ToString();
            textBox2.Text = DataGridView.CurrentRow.Cells["PASS"].Value.ToString();
            textBox2.Text = DataGridView.CurrentRow.Cells["QUYEN"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox1.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn tài khoản để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE TAIKHOAN WHERE ID=N'" + textBox1.Text + "'";
                Functions.RunSqlDel(sql);
                LoadDataGridView();
                textBox1.Text = "";
                textBox2.Text = "";
            }
           
        }
    }
}
