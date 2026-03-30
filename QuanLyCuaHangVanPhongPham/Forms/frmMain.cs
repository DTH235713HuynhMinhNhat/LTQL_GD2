using System;
using System.Windows.Forms;

namespace QuanLyVanPhongPham.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            // Gắn sự kiện click cho nút Sản phẩm
            btnSanPham.Click += BtnSanPham_Click;
        }

        // Hàm xử lý nhúng UserControl
        private void AddUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
            uc.BringToFront();
        }

        // Sự kiện khi bấm nút Sản phẩm
        private void BtnSanPham_Click(object ?sender, EventArgs e)
        {
            ucSanPham uc = new ucSanPham();
            AddUserControl(uc);
        }
    }
}