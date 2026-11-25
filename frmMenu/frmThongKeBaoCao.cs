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
    public partial class frmThongKeBaoCao : Form
    {
        public frmThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }
    }
}
