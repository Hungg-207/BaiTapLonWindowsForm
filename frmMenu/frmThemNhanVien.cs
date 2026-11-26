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
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void cbbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChucvu.SelectedIndex == 0)
            {
                txtTienluong.Text = "25.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 1)
            {
                txtTienluong.Text = "12.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 2)
            {
                txtTienluong.Text = "11.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 3)
            {
                txtTienluong.Text = "9.500.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 4)
            {
                txtTienluong.Text = "7.500.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 5)
            {
                txtTienluong.Text = "18.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 6)
            {
                txtTienluong.Text = "17.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 7)
            {
                txtTienluong.Text = "13.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 8)
            {
                txtTienluong.Text = "9.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 9)
            {
                txtTienluong.Text = "10.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 10)
            {
                txtTienluong.Text = "7.000.000đ";
            }
            else if (cbbChucvu.SelectedIndex == 11)
            {
                txtTienluong.Text = "6.500.000đ";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void grbDsNV_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataDsnv.Rows.Add(txtMaNV.Text, txtHoten.Text, cbbGioitinh.Text, dateNgaysinh.Value.ToString("dd/MM/yyyy"), txtDiachi.Text, txtSodt.Text, dateNgaylam.Value.ToString("dd/MM/yyyy"), cbbChucvu.Text, txtTienluong.Text, txtUser.Text, txtPass.Text, cbbPer.Text);
        }

        private void grbQuanLy_Enter(object sender, EventArgs e)
        {

        }

        private void txtTienluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbPer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateNgaylam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbbGioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSodt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPer_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLuong_Click(object sender, EventArgs e)
        {

        }

        private void lblChucvu_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaylam_Click(object sender, EventArgs e)
        {

        }

        private void lblDt_Click(object sender, EventArgs e)
        {

        }

        private void lblDiachi_Click(object sender, EventArgs e)
        {

        }

        private void lblNgaysinh_Click(object sender, EventArgs e)
        {

        }

        private void lblGioitinh_Click(object sender, EventArgs e)
        {

        }

        private void lblHoten_Click(object sender, EventArgs e)
        {

        }

        private void lblMaNv_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
