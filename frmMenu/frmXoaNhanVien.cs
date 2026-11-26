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
    public partial class frmXoaNhanVien : Form
    {
        public frmXoaNhanVien()
        {
            InitializeComponent();
        }

        private void grbQuanLy_Enter(object sender, EventArgs e)
        {

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
            frmSuaNhanVien frm = new frmSuaNhanVien();
            frm.ShowDialog();
        }
    }
}
