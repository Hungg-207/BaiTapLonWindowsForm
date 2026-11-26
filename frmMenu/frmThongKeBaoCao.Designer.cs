namespace frmMenu
{
    partial class frmThongKeBaoCao
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
            this.lblBaoCao = new System.Windows.Forms.Label();
            this.cbbChonTK = new System.Windows.Forms.ComboBox();
            this.lblChonTK = new System.Windows.Forms.Label();
            this.dataBaoCao = new System.Windows.Forms.DataGridView();
            this.btnQuaylai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaoCao
            // 
            this.lblBaoCao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCao.ForeColor = System.Drawing.Color.Red;
            this.lblBaoCao.Location = new System.Drawing.Point(0, 0);
            this.lblBaoCao.Name = "lblBaoCao";
            this.lblBaoCao.Size = new System.Drawing.Size(1297, 74);
            this.lblBaoCao.TabIndex = 0;
            this.lblBaoCao.Text = "THỐNG KÊ BÁO CÁO DOANH THU";
            this.lblBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbChonTK
            // 
            this.cbbChonTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChonTK.FormattingEnabled = true;
            this.cbbChonTK.Items.AddRange(new object[] {
            "1. Báo cáo doanh thu (Ngày, Tháng, Mặt hàng, Nhóm, Nhân viên)",
            "2. Báo cáo hàng hóa (Tồn kho, Sắp hết, Đã hết, Bán chạy/chậm)",
            "3. Báo cáo nhập hàng (SL, Giá trị, Nhà cung cấp, Chi phí)",
            "4. Báo cáo bán hàng (Hóa đơn, SL bán, Trả hàng, Thanh toán)\"",
            "5. Báo cáo lợi nhuận (Doanh thu - Chi phí nhập/vận hành)",
            "6. Báo cáo nhân viên (Doanh thu, Số đơn, Hiệu quả)"});
            this.cbbChonTK.Location = new System.Drawing.Point(319, 107);
            this.cbbChonTK.Name = "cbbChonTK";
            this.cbbChonTK.Size = new System.Drawing.Size(770, 33);
            this.cbbChonTK.TabIndex = 1;
            // 
            // lblChonTK
            // 
            this.lblChonTK.AutoSize = true;
            this.lblChonTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonTK.Location = new System.Drawing.Point(98, 107);
            this.lblChonTK.Name = "lblChonTK";
            this.lblChonTK.Size = new System.Drawing.Size(215, 25);
            this.lblChonTK.TabIndex = 2;
            this.lblChonTK.Text = "Chọn Loại Thống Kê:";
            // 
            // dataBaoCao
            // 
            this.dataBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataBaoCao.Location = new System.Drawing.Point(0, 199);
            this.dataBaoCao.Name = "dataBaoCao";
            this.dataBaoCao.RowHeadersWidth = 45;
            this.dataBaoCao.Size = new System.Drawing.Size(1297, 427);
            this.dataBaoCao.TabIndex = 3;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.Location = new System.Drawing.Point(1122, 107);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(116, 36);
            this.btnQuaylai.TabIndex = 4;
            this.btnQuaylai.Text = "Quay Lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // frmThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1297, 626);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.dataBaoCao);
            this.Controls.Add(this.lblChonTK);
            this.Controls.Add(this.cbbChonTK);
            this.Controls.Add(this.lblBaoCao);
            this.MaximizeBox = false;
            this.Name = "frmThongKeBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.ComboBox cbbChonTK;
        private System.Windows.Forms.Label lblChonTK;
        private System.Windows.Forms.DataGridView dataBaoCao;
        private System.Windows.Forms.Button btnQuaylai;
    }
}