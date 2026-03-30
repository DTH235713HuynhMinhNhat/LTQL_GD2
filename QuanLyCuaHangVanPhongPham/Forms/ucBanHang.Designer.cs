namespace QuanLyCuaHangVanPhongPham.Forms
{
    partial class ucBanHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();

            pnlLeft = new Panel();
            dgvSanPham = new DataGridView();
            pnlLeftTop = new Panel();
            txtTimKiem = new TextBox();
            lblTitleLeft = new Label();

            pnlRight = new Panel();
            dgvGioHang = new DataGridView();
            colMaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();

            pnlRightBottom = new Panel();
            btnXoaKhaiGio = new Button();
            btnThanhToan = new Button();
            lblTongTienValue = new Label();
            lblTongTienText = new Label();

            pnlRightTop = new Panel();
            cboKhachHang = new ComboBox();
            label1 = new Label();
            lblTitleRight = new Label();

            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            pnlLeftTop.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            pnlRightBottom.SuspendLayout();
            pnlRightTop.SuspendLayout();
            SuspendLayout();

            // 
            // pnlLeft (Khu vực danh sách sản phẩm)
            // 
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(dgvSanPham);
            pnlLeft.Controls.Add(pnlLeftTop);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new System.Drawing.Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new System.Drawing.Size(450, 580);
            pnlLeft.TabIndex = 0;

            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            dgvSanPham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.ColumnHeadersHeight = 40;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new System.Drawing.Point(0, 60);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(226, 234, 253);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.RowTemplate.Height = 35;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new System.Drawing.Size(448, 518);
            dgvSanPham.TabIndex = 1;

            // 
            // pnlLeftTop
            // 
            pnlLeftTop.BackColor = System.Drawing.Color.White;
            pnlLeftTop.Controls.Add(txtTimKiem);
            pnlLeftTop.Controls.Add(lblTitleLeft);
            pnlLeftTop.Dock = DockStyle.Top;
            pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            pnlLeftTop.Name = "pnlLeftTop";
            pnlLeftTop.Size = new System.Drawing.Size(448, 60);
            pnlLeftTop.TabIndex = 0;

            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new System.Drawing.Point(170, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(260, 30);
            txtTimKiem.TabIndex = 1;

            // 
            // lblTitleLeft
            // 
            lblTitleLeft.AutoSize = true;
            lblTitleLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitleLeft.Location = new System.Drawing.Point(10, 16);
            lblTitleLeft.Name = "lblTitleLeft";
            lblTitleLeft.Size = new System.Drawing.Size(121, 28);
            lblTitleLeft.Text = "SẢN PHẨM";

            // 
            // pnlRight (Khu vực giỏ hàng và thanh toán)
            // 
            pnlRight.Controls.Add(dgvGioHang);
            pnlRight.Controls.Add(pnlRightBottom);
            pnlRight.Controls.Add(pnlRightTop);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new System.Drawing.Point(450, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(460, 580);
            pnlRight.TabIndex = 1;

            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            dgvGioHang.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvGioHang.ColumnHeadersHeight = 40;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { colMaSP, colTenSP, colSoLuong, colDonGia, colThanhTien });
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.EnableHeadersVisualStyles = false;
            dgvGioHang.Location = new System.Drawing.Point(0, 60);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(226, 234, 253);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dgvGioHang.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvGioHang.RowTemplate.Height = 35;
            dgvGioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGioHang.Size = new System.Drawing.Size(460, 370);
            dgvGioHang.TabIndex = 1;

            // Columns for dgvGioHang
            colMaSP.HeaderText = "Mã SP";
            colMaSP.Name = "colMaSP";
            colMaSP.ReadOnly = true;
            colMaSP.Visible = false;

            colTenSP.HeaderText = "Tên SP";
            colTenSP.Name = "colTenSP";
            colTenSP.ReadOnly = true;

            colSoLuong.HeaderText = "SL";
            colSoLuong.Name = "colSoLuong";
            colSoLuong.Width = 60;

            colDonGia.HeaderText = "Đơn giá";
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;

            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;

            // 
            // pnlRightBottom
            // 
            pnlRightBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            pnlRightBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlRightBottom.Controls.Add(btnXoaKhaiGio);
            pnlRightBottom.Controls.Add(btnThanhToan);
            pnlRightBottom.Controls.Add(lblTongTienValue);
            pnlRightBottom.Controls.Add(lblTongTienText);
            pnlRightBottom.Dock = DockStyle.Bottom;
            pnlRightBottom.Location = new System.Drawing.Point(0, 430);
            pnlRightBottom.Name = "pnlRightBottom";
            pnlRightBottom.Size = new System.Drawing.Size(460, 150);
            pnlRightBottom.TabIndex = 2;

            // 
            // lblTongTienText
            // 
            lblTongTienText.AutoSize = true;
            lblTongTienText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTongTienText.Location = new System.Drawing.Point(20, 20);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new System.Drawing.Size(126, 28);
            lblTongTienText.Text = "TỔNG TIỀN:";

            // 
            // lblTongTienValue
            // 
            lblTongTienValue.AutoSize = true;
            lblTongTienValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTongTienValue.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            lblTongTienValue.Location = new System.Drawing.Point(160, 10);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new System.Drawing.Size(104, 41);
            lblTongTienValue.Text = "0 VNĐ";

            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThanhToan.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnThanhToan.ForeColor = System.Drawing.Color.White;
            btnThanhToan.Location = new System.Drawing.Point(260, 80);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new System.Drawing.Size(180, 50);
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = false;

            // 
            // btnXoaKhaiGio
            // 
            btnXoaKhaiGio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnXoaKhaiGio.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            btnXoaKhaiGio.FlatStyle = FlatStyle.Flat;
            btnXoaKhaiGio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnXoaKhaiGio.ForeColor = System.Drawing.Color.White;
            btnXoaKhaiGio.Location = new System.Drawing.Point(20, 90);
            btnXoaKhaiGio.Name = "btnXoaKhaiGio";
            btnXoaKhaiGio.Size = new System.Drawing.Size(120, 40);
            btnXoaKhaiGio.Text = "Bỏ SP";
            btnXoaKhaiGio.UseVisualStyleBackColor = false;

            // 
            // pnlRightTop
            // 
            pnlRightTop.BackColor = System.Drawing.Color.White;
            pnlRightTop.BorderStyle = BorderStyle.FixedSingle;
            pnlRightTop.Controls.Add(cboKhachHang);
            pnlRightTop.Controls.Add(label1);
            pnlRightTop.Controls.Add(lblTitleRight);
            pnlRightTop.Dock = DockStyle.Top;
            pnlRightTop.Location = new System.Drawing.Point(0, 0);
            pnlRightTop.Name = "pnlRightTop";
            pnlRightTop.Size = new System.Drawing.Size(460, 60);
            pnlRightTop.TabIndex = 0;

            // 
            // cboKhachHang
            // 
            cboKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new System.Drawing.Point(250, 15);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new System.Drawing.Size(190, 31);
            cboKhachHang.TabIndex = 2;

            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(140, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 23);
            label1.Text = "Khách hàng:";

            // 
            // lblTitleRight
            // 
            lblTitleRight.AutoSize = true;
            lblTitleRight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitleRight.Location = new System.Drawing.Point(10, 16);
            lblTitleRight.Name = "lblTitleRight";
            lblTitleRight.Size = new System.Drawing.Size(113, 28);
            lblTitleRight.Text = "GIỎ HÀNG";

            // 
            // ucBanHang
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Font = new System.Drawing.Font("Segoe UI", 10.2F);
            Name = "ucBanHang";
            Size = new System.Drawing.Size(910, 580);

            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            pnlLeftTop.ResumeLayout(false);
            pnlLeftTop.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            pnlRightBottom.ResumeLayout(false);
            pnlRightBottom.PerformLayout();
            pnlRightTop.ResumeLayout(false);
            pnlRightTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private Panel pnlLeftTop;
        private Label lblTitleLeft;
        private TextBox txtTimKiem;
        private DataGridView dgvSanPham;

        private Panel pnlRight;
        private Panel pnlRightTop;
        private Label lblTitleRight;
        private ComboBox cboKhachHang;
        private Label label1;
        private DataGridView dgvGioHang;

        private Panel pnlRightBottom;
        private Label lblTongTienText;
        private Label lblTongTienValue;
        private Button btnThanhToan;
        private Button btnXoaKhaiGio;

        // Các cột của giỏ hàng
        private DataGridViewTextBoxColumn colMaSP;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}
