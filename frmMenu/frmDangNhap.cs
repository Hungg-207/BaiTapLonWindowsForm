using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            errorProvider1.Clear();
            /*
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                errorProvider1.SetError(txtUser, "Vui lòng nhập tài khoản!");
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Vui lòng nhập mật khẩu!");
                txtPass.Focus();
                return;
            }
            */
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
            
        }
    }
}
