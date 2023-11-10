using DoAnQuanLyNoiThat.Controller;
using DoAnQuanLyNoiThat.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnQuanLyNoiThat.View
{
    public partial class frmDonHang : Form
    {
        DonHangController donHangController;
        ChiTietDonHangController chiTietDonHangController;

        NhanVienController nhanVienController;
        KhachHangController khachHangController;
        SanPhamController sanPhamController;


        List<NhanVien> dsnhanVien = new List<NhanVien>();
        List<KhachHang> dskhachHang = new List<KhachHang>();
        List<SanPham> dssanpham = new List<SanPham>();
        DonHang currentDonhang;
        ChiTietDonHang currentChiTietDonHang;

        public frmDonHang()
        {
            InitializeComponent();

            donHangController = new DonHangController();
            currentDonhang = new DonHang();

            chiTietDonHangController = new ChiTietDonHangController();
            currentChiTietDonHang = new ChiTietDonHang();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Xử lý dữ liệu đơn hàng
            currentDonhang = new DonHang(int.Parse(txtIdDonHang.Text), int.Parse(comboBoxIdKH.Text), int.Parse(comboBoxIdNV.Text), dateTimePickerNgayDatHang.Value, int.Parse(txtTongTien.Text), txtTrangThai.Text);
            donHangController.insertdonhang(currentDonhang);
            // Chi tiết đơn hàng
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu dòng không phải là dòng header và dòng không rỗng
                if (!row.IsNewRow && !row.Cells[0].Value.Equals(string.Empty))
                {
                    int idDonHang = int.Parse(txtIdDonHang.Text);
                    int idSanPham = int.Parse(row.Cells[0].Value.ToString().Trim());
                    int soluong = int.Parse(row.Cells[4].Value.ToString().Trim());
                    decimal dongia = decimal.Parse(row.Cells[5].Value.ToString().Trim());

                    currentChiTietDonHang = new ChiTietDonHang(idDonHang, idSanPham, soluong, dongia);
                    chiTietDonHangController.insertChiTietDonhang(currentChiTietDonHang);

                }
            }
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            nhanVienController = new NhanVienController();
            dsnhanVien = nhanVienController.load();

            khachHangController = new KhachHangController();
            dskhachHang = khachHangController.load();

            sanPhamController = new SanPhamController();
            dssanpham = sanPhamController.load();

            foreach (NhanVien nhanvien in dsnhanVien)
            {
                comboBoxIdNV.Items.Add(nhanvien.getid());
            }
            foreach (KhachHang khachhang in dskhachHang)
            {
                comboBoxIdKH.Items.Add(khachhang.getid());
            }
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "IdSanPham";
            comboboxColumn.HeaderText = "Mã Sản Phẩm";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 150;
            comboboxColumn.MaxDropDownItems = 3;
            comboboxColumn.FlatStyle = FlatStyle.Flat;

            foreach (SanPham sanpham in dssanpham)
            {
                comboboxColumn.Items.Add(sanpham.getidsanpham().ToString());
            }
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(comboboxColumn);
            // Tên sản Phẩm                                          
            DataGridViewTextBoxColumn coltenSanPham = new DataGridViewTextBoxColumn();
            coltenSanPham.DataPropertyName = "TenSanPham";
            coltenSanPham.HeaderText = "Tên Sản Phẩm";
            coltenSanPham.Width = 250;
            dataGridView1.Columns.Add(coltenSanPham);
            // Mô tả
            DataGridViewTextBoxColumn colMota = new DataGridViewTextBoxColumn();
            colMota.DataPropertyName = "MoTa";
            colMota.HeaderText = "Mô Tả";
            colMota.Width = 150;
            dataGridView1.Columns.Add(colMota);
            //Loại Sản Phẩm
            DataGridViewTextBoxColumn colLoaiSanPham = new DataGridViewTextBoxColumn();
            colLoaiSanPham.DataPropertyName = "LoaiSanPham";
            colLoaiSanPham.HeaderText = "Loại Sản Phẩm";
            colLoaiSanPham.Width = 150;
            dataGridView1.Columns.Add(colLoaiSanPham);
            //Số Lượng
            DataGridViewTextBoxColumn colsoluong = new DataGridViewTextBoxColumn();
            colsoluong.DataPropertyName = "SoLuong";
            colsoluong.HeaderText = "Số Lượng";
            colsoluong.Width = 180;
            dataGridView1.Columns.Add(colsoluong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "DonGia";
            colDongia.HeaderText = "Đơn giá";
            colDongia.Width = 180;
            dataGridView1.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.Width = 180;
            dataGridView1.Columns.Add(colThanhTien);

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = sanPhamController.get(id).gettensanpham();
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = sanPhamController.get(id).getmota();
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = sanPhamController.get(id).getloaisanpham();
            }
            if (e.ColumnIndex == 5)
            {
                int sl = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                int dg = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString().Trim());
                dataGridView1.Rows[e.RowIndex].Cells[6].Value = sl * dg;

                int tien = dataGridView1.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < tien - 1; i++)
                {
                    thanhtien += float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
                }
                textBox1.Text = thanhtien.ToString();
            }
        }
    }
}
