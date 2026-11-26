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
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
            }
        }
        private void thốngKêBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            frmSuaNhanVien frm = new frmSuaNhanVien();
            frm.ShowDialog();
        }

        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien frm = new frmXoaNhanVien();
            frm.ShowDialog();
        }

        private void sửaThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang frm = new frmSuaKhachHang();
            frm.ShowDialog();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            frm.ShowDialog();
        }

        private void xóaThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXoaKhachHang frm = new frmXoaKhachHang();
            frm.ShowDialog();
        }
    }
}
