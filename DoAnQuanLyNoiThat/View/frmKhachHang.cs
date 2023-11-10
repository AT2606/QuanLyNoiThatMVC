using DoAnQuanLyNoiThat.Controller;
using DoAnQuanLyNoiThat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNoiThat.View
{
    public partial class frmKhachHang : Form
    {
        KhachHangController khachHangController;
        List<KhachHang> dsKhachHang;
        KhachHang currentKhachHang;
        string MaKH;
        public frmKhachHang()
        {
            InitializeComponent();
            khachHangController = new KhachHangController();

            dsKhachHang = new List<KhachHang>();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Mã Khách Hàng";
            dataGridView1.Columns[1].Name = "Tên Khách Hàng";
            dataGridView1.Columns[2].Name = "Địa Chỉ";
            dataGridView1.Columns[3].Name = "Điện Thoại";
            dataGridView1.Columns[4].Name = "Ngày Sinh";
            dataGridView1.Columns[5].Name = "Giới tính";
            
           
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 170;
            dataGridView1.Columns[4].Width = 151;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dsKhachHang.Clear();
            dsKhachHang = khachHangController.load();
            dataGridView1.Rows.Clear();
            foreach (KhachHang khachhang in dsKhachHang)
            {
                string[] row = {khachhang.getid().ToString(), khachhang.gethoten(),
                khachhang.getdiachi().ToString(), khachhang.getdienthoai(),khachhang.getngaysinh().ToString(), khachhang.getgioitinh()};
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            currentKhachHang = new KhachHang(txtTen.Text, txtDiaChi.Text, txtSDT.Text,dateTimePickerNdayDatHang.Value,txtGioiTinh.Text);
            khachHangController.insert(currentKhachHang);
            btnload_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dsKhachHang.Clear();
            currentKhachHang = new KhachHang(int.Parse(MaKH), txtTen.Text,txtDiaChi.Text, txtSDT.Text, dateTimePickerNdayDatHang.Value,txtGioiTinh.Text);
            khachHangController.update(currentKhachHang);
            btnload_Click(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKh = MaKH;
            if (khachHangController.delete(maKh))
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maKh)
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
                txtTen.Text = selectedRow.Cells[1].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells[2].Value.ToString();
                txtSDT.Text = selectedRow.Cells[3].Value.ToString();
                dateTimePickerNdayDatHang.Text = selectedRow.Cells[4].Value.ToString();
                txtGioiTinh.Text = selectedRow.Cells[5].Value.ToString();
                MaKH = selectedRow.Cells[0].Value.ToString();
            }
        }
    }
}
