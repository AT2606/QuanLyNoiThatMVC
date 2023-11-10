using DoAnQuanLyNoiThat.Model;
using DoAnQuanLyNoiThat.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNoiThat.Controller
{
    internal class DonHangController
    {
        List<DonHang> DonHangList;
        public DonHangController()
        {
            DonHangList = new List<DonHang>();
        }
        public bool insertdonhang(DonHang donHang)
        {
            SqlConnection conn = DatabaseHelper.getConnection();

            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DonHang(IdDonHang,IdKhachHang,IdNhanVien,NgayDatHang,TongTien,TrangThai) " +
                    "VALUES (@IdDonHang,@IdKhachHang,@IdNhanVien,@NgayDatHang,@TongTien,@TrangThai)", conn);
                cmd.Parameters.AddWithValue("@IdDonHang", donHang.getiddonhang());
                cmd.Parameters.AddWithValue("@IdKhachHang", donHang.getidkhachhang());
                cmd.Parameters.AddWithValue("@IdNhanVien", donHang.getidnhanvien());
                cmd.Parameters.AddWithValue("@NgayDatHang", donHang.getngaydathang());
                cmd.Parameters.AddWithValue("@TongTien", donHang.gettongtien());
                cmd.Parameters.AddWithValue("@TrangThai", donHang.gettrangthai());


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm Thành Công");
                    return true;
                }
                else
                {
                    // Thêm không thành công
                    MessageBox.Show("Thêm không Thành Công");
                    return false;
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }
    }
}
