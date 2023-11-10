using DoAnQuanLyNoiThat.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNoiThat
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }
        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void QuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTK frm = new frmQuanLyTK();
            frm.Show();
          
        }

        private void QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            frm.Show();
          
        }

        private void QuanLyKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void QuanLyDonHang_Click(object sender, EventArgs e)
        {
            frmDonHang frm = new frmDonHang();
            frm.Show();
        }

        private void QuanLySanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}
