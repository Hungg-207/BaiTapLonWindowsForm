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
    public partial class frmXoaKhachHang : Form
    {
        public frmXoaKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuaKhachHang frm = new frmSuaKhachHang();
            frm.ShowDialog();
        }
    }
}
