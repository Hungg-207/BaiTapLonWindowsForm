using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frmMenu
{
    public partial class frmQuanLyOto : Form
    {
        private DataTable dtOto = new DataTable();
        private string duongDanAnh = "";
        private DataRow dongDangChon = null;

        public frmQuanLyOto()
        {
            InitializeComponent();
        }

        private void frmQuanLyOto_Load(object sender, EventArgs e)
        {
            KhoiTaoComboBox();
            KhoiTaoBang();
            LamMoi();

        }

        // Khởi tạo ComboBox
        private void KhoiTaoComboBox()
        {
            cboLoaiOto.Items.Clear();
            cboLoaiOto.Items.AddRange(new string[]
            {
                "Sedan",
                "SUV",
                "Hatchback",
                "MPV",
                "Crossover",
                "Pickup",
                "Coupe",
                "Convertible"
            });

            cboHangSX.Items.Clear();
            cboHangSX.Items.AddRange(new string[]
            {
                "Toyota",
                "Honda",
                "Ford",
                "Hyundai",
                "Kia",
                "Mazda",
                "Mitsubishi",
                "Mercedes-Benz",
                "BMW",
                "Audi",
                "VinFast",
                "Nissan"
            });

            cboMauSac.Items.Clear();
            cboMauSac.Items.AddRange(new string[]
            {
                "Trắng",
                "Đen",
                "Xám",
                "Bạc",
                "Đỏ",
                "Xanh dương",
                "Xanh lá",
                "Nâu",
                "Vàng"
            });

            cboNhaCungCap.Items.Clear();
            cboNhaCungCap.Items.AddRange(new string[]
            {
                "Toyota Việt Nam",
                "Honda Việt Nam",
                "Ford Việt Nam",
                "Hyundai Thành Công",
                "THACO Auto",
                "VinFast"
            });

            cboTimKiem.Items.Clear();
            cboTimKiem.Items.AddRange(new string[]
            {
                "Mã ô tô",
                "Tên ô tô",
                "Loại ô tô",
                "Hãng sản xuất",
                "Màu sắc",
                "Nhà cung cấp"
            });

            cboTimKiem.SelectedIndex = 0;

            nudNamSX.Minimum = 1900;
            nudNamSX.Maximum = DateTime.Now.Year + 1;
            nudNamSX.Value = DateTime.Now.Year;

            nudSoLuong.Minimum = 0;
            nudSoLuong.Maximum = 10000;

            picOto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Khởi tạo bảng dữ liệu
        private void KhoiTaoBang()
        {
            dtOto.Columns.Add("MaOto", typeof(string));
            dtOto.Columns.Add("TenOto", typeof(string));
            dtOto.Columns.Add("LoaiOto", typeof(string));
            dtOto.Columns.Add("HangSX", typeof(string));
            dtOto.Columns.Add("NamSX", typeof(int));
            dtOto.Columns.Add("XuatXu", typeof(string));
            dtOto.Columns.Add("MauSac", typeof(string));
            dtOto.Columns.Add("GiaNhap", typeof(decimal));
            dtOto.Columns.Add("GiaBan", typeof(decimal));
            dtOto.Columns.Add("SoLuong", typeof(int));
            dtOto.Columns.Add("NhaCungCap", typeof(string));
            dtOto.Columns.Add("MoTa", typeof(string));
            dtOto.Columns.Add("HinhAnh", typeof(string));

            dtOto.PrimaryKey = new DataColumn[]
            {
                dtOto.Columns["MaOto"]
            };

            dgvOto.AutoGenerateColumns = false;

            dgvOto.Columns["colMaOto"].DataPropertyName = "MaOto";
            dgvOto.Columns["colTenOto"].DataPropertyName = "TenOto";
            dgvOto.Columns["colLoaiOto"].DataPropertyName = "LoaiOto";
            dgvOto.Columns["colHangSX"].DataPropertyName = "HangSX";
            dgvOto.Columns["colNamSX"].DataPropertyName = "NamSX";
            dgvOto.Columns["colXuatXu"].DataPropertyName = "XuatXu";
            dgvOto.Columns["colMauSac"].DataPropertyName = "MauSac";
            dgvOto.Columns["colGiaNhap"].DataPropertyName = "GiaNhap";
            dgvOto.Columns["colGiaBan"].DataPropertyName = "GiaBan";
            dgvOto.Columns["colSoLuong"].DataPropertyName = "SoLuong";
            dgvOto.Columns["colNhaCungCap"].DataPropertyName = "NhaCungCap";
            dgvOto.Columns["colMoTa"].DataPropertyName = "MoTa";

            dgvOto.Columns["colGiaNhap"].DefaultCellStyle.Format = "N0";
            dgvOto.Columns["colGiaBan"].DefaultCellStyle.Format = "N0";

            dgvOto.DataSource = dtOto;

            dgvOto.ReadOnly = true;
            dgvOto.AllowUserToAddRows = false;
            dgvOto.AllowUserToDeleteRows = false;
            dgvOto.MultiSelect = false;

            dgvOto.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        // Kiểm tra dữ liệu
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaOto.Text))
            {
                MessageBox.Show("Vui lòng nhập mã ô tô!");
                txtMaOto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenOto.Text))
            {
                MessageBox.Show("Vui lòng nhập tên ô tô!");
                txtTenOto.Focus();
                return false;
            }

            if (cboLoaiOto.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại ô tô!");
                cboLoaiOto.Focus();
                return false;
            }

            if (cboHangSX.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất!");
                cboHangSX.Focus();
                return false;
            }

            if (cboMauSac.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn màu sắc!");
                cboMauSac.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaNhap.Text,
                out decimal giaNhap) || giaNhap <= 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ!");
                txtGiaNhap.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaBan.Text,
                out decimal giaBan) || giaBan <= 0)
            {
                MessageBox.Show("Giá bán không hợp lệ!");
                txtGiaBan.Focus();
                return false;
            }

            if (cboNhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");
                cboNhaCungCap.Focus();
                return false;
            }

            return true;
        }

        // Thêm ô tô
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            string maOto = txtMaOto.Text.Trim();

            if (dtOto.Rows.Find(maOto) != null)
            {
                MessageBox.Show("Mã ô tô đã tồn tại!");
                txtMaOto.Focus();
                return;
            }

            dtOto.Rows.Add(
                maOto,
                txtTenOto.Text.Trim(),
                cboLoaiOto.Text,
                cboHangSX.Text,
                (int)nudNamSX.Value,
                txtXuatXu.Text.Trim(),
                cboMauSac.Text,
                decimal.Parse(txtGiaNhap.Text),
                decimal.Parse(txtGiaBan.Text),
                (int)nudSoLuong.Value,
                cboNhaCungCap.Text,
                rtbMoTa.Text.Trim(),
                duongDanAnh
            );

            MessageBox.Show(
                "Thêm ô tô thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LamMoi();
        }

        // Sửa thông tin ô tô
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dongDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn ô tô cần sửa!");
                return;
            }

            if (!KiemTraDuLieu())
                return;

            dongDangChon["TenOto"] = txtTenOto.Text.Trim();
            dongDangChon["LoaiOto"] = cboLoaiOto.Text;
            dongDangChon["HangSX"] = cboHangSX.Text;
            dongDangChon["NamSX"] = (int)nudNamSX.Value;
            dongDangChon["XuatXu"] = txtXuatXu.Text.Trim();
            dongDangChon["MauSac"] = cboMauSac.Text;
            dongDangChon["GiaNhap"] = decimal.Parse(txtGiaNhap.Text);
            dongDangChon["GiaBan"] = decimal.Parse(txtGiaBan.Text);
            dongDangChon["SoLuong"] = (int)nudSoLuong.Value;
            dongDangChon["NhaCungCap"] = cboNhaCungCap.Text;
            dongDangChon["MoTa"] = rtbMoTa.Text.Trim();
            dongDangChon["HinhAnh"] = duongDanAnh;

            MessageBox.Show("Sửa thông tin ô tô thành công!");

            LamMoi();
        }

        // Xóa ô tô
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dongDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn ô tô cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa ô tô này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (ketQua == DialogResult.Yes)
            {
                dtOto.Rows.Remove(dongDangChon);

                MessageBox.Show("Xóa ô tô thành công!");

                LamMoi();
            }
        }

        // Tìm kiếm ô tô
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            string tenCot = "";

            switch (cboTimKiem.SelectedIndex)
            {
                case 0:
                    tenCot = "MaOto";
                    break;

                case 1:
                    tenCot = "TenOto";
                    break;

                case 2:
                    tenCot = "LoaiOto";
                    break;

                case 3:
                    tenCot = "HangSX";
                    break;

                case 4:
                    tenCot = "MauSac";
                    break;

                case 5:
                    tenCot = "NhaCungCap";
                    break;

                default:
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!");
                    return;
            }

            LamMoiNhapLieu();

            if (tuKhoa == "")
            {
                dtOto.DefaultView.RowFilter = "";
                dgvOto.ClearSelection();
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (char c in tuKhoa)
            {
                switch (c)
                {
                    case '\'':
                        sb.Append("''");
                        break;

                    case '[':
                        sb.Append("[[]");
                        break;

                    case ']':
                        sb.Append("[]]");
                        break;

                    case '%':
                        sb.Append("[%]");
                        break;

                    case '*':
                        sb.Append("[*]");
                        break;

                    default:
                        sb.Append(c);
                        break;
                }
            }

            dtOto.DefaultView.RowFilter =
                tenCot + " LIKE '%" + sb.ToString() + "%'";

            dgvOto.ClearSelection();

            if (dgvOto.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy ô tô phù hợp!");
            }
        }

        // Lấy thông tin từ dòng được chọn
        private void dgvOto_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataRowView rowView =
                dgvOto.Rows[e.RowIndex].DataBoundItem as DataRowView;

            if (rowView == null)
                return;

            dongDangChon = rowView.Row;

            txtMaOto.Text = dongDangChon["MaOto"].ToString();
            txtTenOto.Text = dongDangChon["TenOto"].ToString();
            cboLoaiOto.Text = dongDangChon["LoaiOto"].ToString();
            cboHangSX.Text = dongDangChon["HangSX"].ToString();

            nudNamSX.Value =
                Convert.ToDecimal(dongDangChon["NamSX"]);

            txtXuatXu.Text = dongDangChon["XuatXu"].ToString();
            cboMauSac.Text = dongDangChon["MauSac"].ToString();

            txtGiaNhap.Text = dongDangChon["GiaNhap"].ToString();
            txtGiaBan.Text = dongDangChon["GiaBan"].ToString();

            nudSoLuong.Value =
                Convert.ToDecimal(dongDangChon["SoLuong"]);

            cboNhaCungCap.Text =
                dongDangChon["NhaCungCap"].ToString();

            rtbMoTa.Text = dongDangChon["MoTa"].ToString();

            duongDanAnh = dongDangChon["HinhAnh"].ToString();

            HienThiAnh(duongDanAnh);

            txtMaOto.ReadOnly = true;
        }

        // Chọn hình ảnh
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn hình ảnh ô tô";

                ofd.Filter =
                    "Hình ảnh|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (HienThiAnh(ofd.FileName))
                    {
                        duongDanAnh = ofd.FileName;
                    }
                }
            }
        }

        private bool HienThiAnh(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                XoaAnh();
                return true;
            }

            if (!File.Exists(path))
            {
                XoaAnh();
                MessageBox.Show("Không tìm thấy hình ảnh!");
                return false;
            }

            try
            {
                using (Image anh = Image.FromFile(path))
                {
                    Bitmap anhMoi = new Bitmap(anh);

                    XoaAnh();

                    picOto.Image = anhMoi;
                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể mở hình ảnh!");
                return false;
            }
        }

        private void XoaAnh()
        {
            if (picOto.Image != null)
            {
                Image anhCu = picOto.Image;
                picOto.Image = null;
                anhCu.Dispose();
            }
        }

        // Làm mới thông tin nhập liệu
        private void LamMoiNhapLieu()
        {
            txtMaOto.Clear();
            txtTenOto.Clear();
            txtXuatXu.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            rtbMoTa.Clear();

            cboLoaiOto.SelectedIndex = -1;
            cboHangSX.SelectedIndex = -1;
            cboMauSac.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;

            nudNamSX.Value = DateTime.Now.Year;
            nudSoLuong.Value = 0;

            duongDanAnh = "";

            XoaAnh();

            dongDangChon = null;

            txtMaOto.ReadOnly = false;

            dgvOto.ClearSelection();
        }

        private void LamMoi()
        {
            LamMoiNhapLieu();

            txtTimKiem.Clear();

            dtOto.DefaultView.RowFilter = "";

            dgvOto.ClearSelection();

            txtMaOto.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        // Thoát Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn thoát khỏi Form quản lý ô tô không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Các sự kiện đã được Designer tạo trước đó

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMaOto_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void cboLoaiOto_SelectedIndexChanged(
            object sender, EventArgs e)
        {

        }

        private void dgvOto_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void CanGiuaGiaoDien()
        {
            if (pnlMain == null)
                return;

            pnlMain.Left = Math.Max(0,
                (this.ClientSize.Width - pnlMain.Width) / 2);

            pnlMain.Top = Math.Max(0,
                (this.ClientSize.Height - pnlMain.Height) / 2);
        }

        private void pnlMain_Resize(object sender, EventArgs e)
        {
            CanGiuaGiaoDien();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTimTheo_Click(object sender, EventArgs e)
        {

        }
    }
}