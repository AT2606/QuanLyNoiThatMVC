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
    public partial class frmQuanLyNhanVien : Form
    {
        NhanVienController nhanVienController;
        List<NhanVien> dsNhanVien;
        NhanVien currentNhanVien;
        string MaNV;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
            nhanVienController = new NhanVienController();

            dsNhanVien = new List<NhanVien>();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Mã Nhân Viên";
            dataGridView1.Columns[1].Name = "Tên Nhân Viên";
            dataGridView1.Columns[2].Name = "Điện Thoại";
            dataGridView1.Columns[3].Name = "Ngày Sinh";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[4].Name = "Chức Vụ";
            dataGridView1.Columns[5].Name = "Lương";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 151;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dsNhanVien.Clear();
            dsNhanVien = nhanVienController.load();
            dataGridView1.Rows.Clear();
            foreach (NhanVien NhanVien in dsNhanVien)
            {
                string[] row = {NhanVien.getid().ToString(), NhanVien.gethoten(),
                NhanVien.getdienthoai(), NhanVien.getngaysinh().ToString(), NhanVien.getchucvu(),NhanVien.getluong().ToString()};
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            currentNhanVien = new NhanVien(txtTen.Text,txtSDT.Text, dateTimePickerNgaySinh.Value, txtChucVu.Text, decimal.Parse(txtLuong.Text));
            nhanVienController.insert(currentNhanVien);
            btnload_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dsNhanVien.Clear();
            currentNhanVien = new NhanVien(int.Parse(MaNV),txtTen.Text, txtSDT.Text, dateTimePickerNgaySinh.Value, txtChucVu.Text, decimal.Parse(txtLuong.Text));
            nhanVienController.update(currentNhanVien);
            btnload_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = MaNV;
            if (nhanVienController.delete(maNV))
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maNV)
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
                txtSDT.Text = selectedRow.Cells[2].Value.ToString();
                dateTimePickerNgaySinh.Text = selectedRow.Cells[3].Value.ToString();
                txtChucVu.Text = selectedRow.Cells[4].Value.ToString();
                txtLuong.Text = selectedRow.Cells[5].Value.ToString();
                MaNV = selectedRow.Cells[0].Value.ToString();
            }
        }
    }
}
