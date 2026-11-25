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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
            }
        }
        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeBaoCao frm = new frmThongKeBaoCao();
            frm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.ShowDialog();
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void chiNhánhHàNộiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyOto frm = new frmQuanLyOto();
            frm.ShowDialog();
        }

        private void chiNhánhTPHCMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLyOto frm = new frmQuanLyOto();
            frm.ShowDialog();
        }

        private void sửaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSua frm = new frmSua();
            frm.ShowDialog();
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuaXoa frm = new frmSuaXoa();
            frm.ShowDialog();
        }
    }
}
