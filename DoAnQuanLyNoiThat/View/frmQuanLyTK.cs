using DoAnQuanLyNoiThat.Controller;
using DoAnQuanLyNoiThat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNoiThat.View
{
    public partial class frmQuanLyTK : Form
    {
        TaiKhoanController taiKhoanController;
        NhanVienController nhanVienController;
        List<TaiKhoan> dsTaiKhoan;
        List<NhanVien> dsNhanVien;
        TaiKhoan currentTaiKhoan;
        string MaTK;

        public frmQuanLyTK()
        {
            InitializeComponent();
            taiKhoanController = new TaiKhoanController();
            nhanVienController = new NhanVienController();
            dsTaiKhoan = new List<TaiKhoan>();
            dsNhanVien = new List<NhanVien>();
            dsNhanVien = nhanVienController.load();

            currentTaiKhoan = new TaiKhoan();

            foreach (NhanVien nhanvien in dsNhanVien)
            {
                comboBoxIdNV.Items.Add(nhanvien.getid());
            }
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Mã Tài Khoản";
            dataGridView1.Columns[1].Name = "Mã Nhân Viên";
            dataGridView1.Columns[2].Name = "Họ Tên";
            dataGridView1.Columns[3].Name = "Tài Khoản";
            dataGridView1.Columns[4].Name = "Mật Khẩu";
            dataGridView1.Columns[5].Name = "Vai Trò";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 145;

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dsTaiKhoan.Clear();
            dsTaiKhoan = taiKhoanController.load();
            dataGridView1.Rows.Clear();
            foreach (TaiKhoan taikhoan in dsTaiKhoan)
            {
                string[] row = {taikhoan.getid().ToString(), taikhoan.getidnhanvien().ToString(),
                taikhoan.gethoten(), taikhoan.gettendangnhap(), taikhoan.getmatkhau(), taikhoan.getvaitro() };
                dataGridView1.Rows.Add(row);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            currentTaiKhoan = new TaiKhoan(int.Parse(comboBoxIdNV.Text), txtTen.Text, txtTenDN.Text, txtMatKhau.Text, txtVaiTro.Text);
            taiKhoanController.insert(currentTaiKhoan);
            btnload_Click(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            dsTaiKhoan.Clear();
            currentTaiKhoan = new TaiKhoan(int.Parse( MaTK),int.Parse(comboBoxIdNV.Text), txtTen.Text, txtTenDN.Text, txtMatKhau.Text, txtVaiTro.Text);
            taiKhoanController.update(currentTaiKhoan);
            btnload_Click(sender, e);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {            
            string maTaiKhoan =MaTK;
            if (taiKhoanController.delete(maTaiKhoan))
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maTaiKhoan)
                    {
                        dataGridView1.Rows.Remove(row);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Xóa không thành công.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                comboBoxIdNV.Text = selectedRow.Cells[1].Value.ToString();
                txtTen.Text = selectedRow.Cells[2].Value.ToString();
                txtTenDN.Text = selectedRow.Cells[3].Value.ToString();
                txtMatKhau.Text = selectedRow.Cells[4].Value.ToString();
                txtVaiTro.Text = selectedRow.Cells[5].Value.ToString();
                MaTK = selectedRow.Cells[0].Value.ToString();
            }          
        }
        
    }
}

