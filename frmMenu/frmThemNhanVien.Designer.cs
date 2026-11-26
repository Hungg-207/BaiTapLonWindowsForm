namespace frmMenu
{
    partial class frmThemNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbQuanLy = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTienluong = new System.Windows.Forms.TextBox();
            this.cbbPer = new System.Windows.Forms.ComboBox();
            this.cbbChucvu = new System.Windows.Forms.ComboBox();
            this.dateNgaylam = new System.Windows.Forms.DateTimePicker();
            this.dateNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblChucvu = new System.Windows.Forms.Label();
            this.lblNgaylam = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.grbDsNV = new System.Windows.Forms.GroupBox();
            this.dataDsnv = new System.Windows.Forms.DataGridView();
            this.colManv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbQuanLy.SuspendLayout();
            this.grbDsNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDsnv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1193, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // grbQuanLy
            // 
            this.grbQuanLy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbQuanLy.Controls.Add(this.btnThoat);
            this.grbQuanLy.Controls.Add(this.btnAdd);
            this.grbQuanLy.Controls.Add(this.txtTienluong);
            this.grbQuanLy.Controls.Add(this.cbbPer);
            this.grbQuanLy.Controls.Add(this.cbbChucvu);
            this.grbQuanLy.Controls.Add(this.dateNgaylam);
            this.grbQuanLy.Controls.Add(this.dateNgaysinh);
            this.grbQuanLy.Controls.Add(this.cbbGioitinh);
            this.grbQuanLy.Controls.Add(this.txtHoten);
            this.grbQuanLy.Controls.Add(this.txtDiachi);
            this.grbQuanLy.Controls.Add(this.txtSodt);
            this.grbQuanLy.Controls.Add(this.txtPass);
            this.grbQuanLy.Controls.Add(this.txtUser);
            this.grbQuanLy.Controls.Add(this.txtMaNV);
            this.grbQuanLy.Controls.Add(this.lblPer);
            this.grbQuanLy.Controls.Add(this.lblPass);
            this.grbQuanLy.Controls.Add(this.lblUser);
            this.grbQuanLy.Controls.Add(this.lblLuong);
            this.grbQuanLy.Controls.Add(this.lblChucvu);
            this.grbQuanLy.Controls.Add(this.lblNgaylam);
            this.grbQuanLy.Controls.Add(this.lblDt);
            this.grbQuanLy.Controls.Add(this.lblDiachi);
            this.grbQuanLy.Controls.Add(this.lblNgaysinh);
            this.grbQuanLy.Controls.Add(this.lblGioitinh);
            this.grbQuanLy.Controls.Add(this.lblHoten);
            this.grbQuanLy.Controls.Add(this.lblMaNv);
            this.grbQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuanLy.Location = new System.Drawing.Point(0, 54);
            this.grbQuanLy.Name = "grbQuanLy";
            this.grbQuanLy.Size = new System.Drawing.Size(1193, 330);
            this.grbQuanLy.TabIndex = 1;
            this.grbQuanLy.TabStop = false;
            this.grbQuanLy.Text = "Thông Tin Nhân Viên";
            this.grbQuanLy.Enter += new System.EventHandler(this.grbQuanLy_Enter);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(961, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 30);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(847, 285);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 30);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTienluong
            // 
            this.txtTienluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienluong.Location = new System.Drawing.Point(777, 133);
            this.txtTienluong.Name = "txtTienluong";
            this.txtTienluong.Size = new System.Drawing.Size(293, 28);
            this.txtTienluong.TabIndex = 30;
            this.txtTienluong.TextChanged += new System.EventHandler(this.txtTienluong_TextChanged);
            // 
            // cbbPer
            // 
            this.cbbPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPer.FormattingEnabled = true;
            this.cbbPer.Items.AddRange(new object[] {
            "Quản Lý",
            "Nhân Viên"});
            this.cbbPer.Location = new System.Drawing.Point(777, 235);
            this.cbbPer.Name = "cbbPer";
            this.cbbPer.Size = new System.Drawing.Size(293, 30);
            this.cbbPer.TabIndex = 29;
            this.cbbPer.SelectedIndexChanged += new System.EventHandler(this.cbbPer_SelectedIndexChanged);
            // 
            // cbbChucvu
            // 
            this.cbbChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucvu.FormattingEnabled = true;
            this.cbbChucvu.Items.AddRange(new object[] {
            "Quản lý (Admin)",
            "Nhân viên bán hàng (Sales)",
            "Kế toán (Accountant)",
            "Nhân viên kho (Warehouse)",
            "Kỹ thuật viên (Technician)",
            "Trưởng phòng kinh doanh",
            "Trưởng phòng kỹ thuật",
            "Cố vấn dịch vụ",
            "Chăm sóc khách hàng",
            "Nhân viên Marketing",
            "Nhân viên rửa xe",
            "Bảo vệ"});
            this.cbbChucvu.Location = new System.Drawing.Point(777, 97);
            this.cbbChucvu.Name = "cbbChucvu";
            this.cbbChucvu.Size = new System.Drawing.Size(293, 30);
            this.cbbChucvu.TabIndex = 27;
            this.cbbChucvu.SelectedIndexChanged += new System.EventHandler(this.cbbChucvu_SelectedIndexChanged);
            // 
            // dateNgaylam
            // 
            this.dateNgaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaylam.Location = new System.Drawing.Point(777, 63);
            this.dateNgaylam.Name = "dateNgaylam";
            this.dateNgaylam.Size = new System.Drawing.Size(293, 28);
            this.dateNgaylam.TabIndex = 26;
            this.dateNgaylam.ValueChanged += new System.EventHandler(this.dateNgaylam_ValueChanged);
            // 
            // dateNgaysinh
            // 
            this.dateNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaysinh.Location = new System.Drawing.Point(256, 165);
            this.dateNgaysinh.Name = "dateNgaysinh";
            this.dateNgaysinh.Size = new System.Drawing.Size(293, 28);
            this.dateNgaysinh.TabIndex = 25;
            this.dateNgaysinh.ValueChanged += new System.EventHandler(this.dateNgaysinh_ValueChanged);
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioitinh.Location = new System.Drawing.Point(256, 130);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(293, 30);
            this.cbbGioitinh.TabIndex = 24;
            this.cbbGioitinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioitinh_SelectedIndexChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(256, 97);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(293, 28);
            this.txtHoten.TabIndex = 23;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(256, 201);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(293, 28);
            this.txtDiachi.TabIndex = 20;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // txtSodt
            // 
            this.txtSodt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSodt.Location = new System.Drawing.Point(256, 237);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(293, 28);
            this.txtSodt.TabIndex = 19;
            this.txtSodt.TextChanged += new System.EventHandler(this.txtSodt_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(777, 201);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(293, 28);
            this.txtPass.TabIndex = 18;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(777, 167);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(293, 28);
            this.txtUser.TabIndex = 17;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(256, 63);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(293, 28);
            this.txtMaNV.TabIndex = 12;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(668, 237);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(109, 24);
            this.lblPer.TabIndex = 11;
            this.lblPer.Text = "Quyền hạn:";
            this.lblPer.Click += new System.EventHandler(this.lblPer_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(683, 204);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(91, 24);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Mật khẩu:";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(634, 167);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(146, 24);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Tên đăng nhập:";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.Location = new System.Drawing.Point(671, 133);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(106, 24);
            this.lblLuong.TabIndex = 8;
            this.lblLuong.Text = "Tiền lương:";
            this.lblLuong.Click += new System.EventHandler(this.lblLuong_Click);
            // 
            // lblChucvu
            // 
            this.lblChucvu.AutoSize = true;
            this.lblChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucvu.Location = new System.Drawing.Point(690, 96);
            this.lblChucvu.Name = "lblChucvu";
            this.lblChucvu.Size = new System.Drawing.Size(85, 24);
            this.lblChucvu.TabIndex = 7;
            this.lblChucvu.Text = "Chức vụ:";
            this.lblChucvu.Click += new System.EventHandler(this.lblChucvu_Click);
            // 
            // lblNgaylam
            // 
            this.lblNgaylam.AutoSize = true;
            this.lblNgaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaylam.Location = new System.Drawing.Point(647, 63);
            this.lblNgaylam.Name = "lblNgaylam";
            this.lblNgaylam.Size = new System.Drawing.Size(129, 24);
            this.lblNgaylam.TabIndex = 6;
            this.lblNgaylam.Text = "Ngày vào làm:";
            this.lblNgaylam.Click += new System.EventHandler(this.lblNgaylam_Click);
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.Location = new System.Drawing.Point(150, 237);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(99, 24);
            this.lblDt.TabIndex = 5;
            this.lblDt.Text = "Điện thoại:";
            this.lblDt.Click += new System.EventHandler(this.lblDt_Click);
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(176, 204);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(72, 24);
            this.lblDiachi.TabIndex = 4;
            this.lblDiachi.Text = "Địa chỉ:";
            this.lblDiachi.Click += new System.EventHandler(this.lblDiachi_Click);
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(151, 167);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(99, 24);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh:";
            this.lblNgaysinh.Click += new System.EventHandler(this.lblNgaysinh_Click);
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(165, 133);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(83, 24);
            this.lblGioitinh.TabIndex = 2;
            this.lblGioitinh.Text = "Giới tính:";
            this.lblGioitinh.Click += new System.EventHandler(this.lblGioitinh_Click);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(178, 96);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(71, 24);
            this.lblHoten.TabIndex = 1;
            this.lblHoten.Text = "Họ tên:";
            this.lblHoten.Click += new System.EventHandler(this.lblHoten_Click);
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNv.Location = new System.Drawing.Point(124, 63);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(129, 24);
            this.lblMaNv.TabIndex = 0;
            this.lblMaNv.Text = "Mã nhân viên:";
            this.lblMaNv.Click += new System.EventHandler(this.lblMaNv_Click);
            // 
            // grbDsNV
            // 
            this.grbDsNV.Controls.Add(this.dataDsnv);
            this.grbDsNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDsNV.Location = new System.Drawing.Point(12, 390);
            this.grbDsNV.Name = "grbDsNV";
            this.grbDsNV.Size = new System.Drawing.Size(1179, 507);
            this.grbDsNV.TabIndex = 2;
            this.grbDsNV.TabStop = false;
            this.grbDsNV.Text = "Danh Sách Nhân Viên";
            this.grbDsNV.Enter += new System.EventHandler(this.grbDsNV_Enter);
            // 
            // dataDsnv
            // 
            this.dataDsnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDsnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDsnv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colManv,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataDsnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDsnv.Location = new System.Drawing.Point(3, 20);
            this.dataDsnv.Name = "dataDsnv";
            this.dataDsnv.RowHeadersWidth = 45;
            this.dataDsnv.Size = new System.Drawing.Size(1173, 484);
            this.dataDsnv.TabIndex = 0;
            this.dataDsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colManv
            // 
            this.colManv.HeaderText = "Mã Nhân Viên";
            this.colManv.MinimumWidth = 6;
            this.colManv.Name = "colManv";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Họ Tên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giới Tính";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điện Thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày Vào Làm";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Chức Vụ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tiền Lương";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên Đăng Nhập";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mật Khẩu";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Quyền Hạn";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 891);
            this.Controls.Add(this.grbDsNV);
            this.Controls.Add(this.grbQuanLy);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhân Viên";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.grbQuanLy.ResumeLayout(false);
            this.grbQuanLy.PerformLayout();
            this.grbDsNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDsnv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbQuanLy;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblChucvu;
        private System.Windows.Forms.Label lblNgaylam;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbbPer;
        private System.Windows.Forms.ComboBox cbbChucvu;
        private System.Windows.Forms.DateTimePicker dateNgaylam;
        private System.Windows.Forms.DateTimePicker dateNgaysinh;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.TextBox txtTienluong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbDsNV;
        private System.Windows.Forms.DataGridView dataDsnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnAdd;
    }
}