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
    public partial class frmSanPham : Form
    {
        SanPhamController sanPhamController;
        List<SanPham> dsSanPham;
        SanPham currentSanPham;
        string MaSP;
        public frmSanPham()
        {
            InitializeComponent();
            sanPhamController = new SanPhamController();

            dsSanPham = new List<SanPham>();
           
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Mã Sản Phẩm";
            dataGridView1.Columns[1].Name = "Tên Sản Phẩm";
          
            dataGridView1.Columns[2].Name = "Mô tả";
            dataGridView1.Columns[3].Name = "Loại Sản Phẩm";

            dataGridView1.Columns[1].Width = 170;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 165;
           
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dsSanPham.Clear();
            dsSanPham = sanPhamController.load();
            dataGridView1.Rows.Clear();
            foreach (SanPham sanPham in dsSanPham)
            {
                string[] row = {sanPham.getidsanpham().ToString(), sanPham.gettensanpham(),
                sanPham.getmota(), sanPham.getloaisanpham()};
                dataGridView1.Rows.Add(row);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            currentSanPham = new SanPham(txtTenSP.Text, txtMoTa.Text, txtLoaiSanPham.Text);
            sanPhamController.insert(currentSanPham);
            btnload_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dsSanPham.Clear();
            currentSanPham = new SanPham(int.Parse(MaSP),txtTenSP.Text, txtMoTa.Text, txtLoaiSanPham.Text);
            sanPhamController.update(currentSanPham);
            btnload_Click(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSanPham = MaSP;
            if (sanPhamController.delete(maSanPham))
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSanPham)
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
                txtTenSP.Text = selectedRow.Cells[1].Value.ToString();              
                txtMoTa.Text = selectedRow.Cells[2].Value.ToString();
                txtLoaiSanPham.Text = selectedRow.Cells[3].Value.ToString();               
                MaSP = selectedRow.Cells[0].Value.ToString();
            }
        }
    }
}
