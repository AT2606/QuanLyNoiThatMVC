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
    internal class ChiTietDonHangController
    {
        List<ChiTietDonHang> chiTietDonHangList;
        public ChiTietDonHangController()
        {
            chiTietDonHangList = new List<ChiTietDonHang>();
        }
        public bool insertChiTietDonhang(ChiTietDonHang chiTietDonHang)
        {
            SqlConnection conn = DatabaseHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ChiTietDonHang(IdDonHang,IdSanPham,SoLuong,DonGia) " +
                    "VALUES (@IdDonHang,@IdSanPham,@SoLuong,@DonGia)", conn);
                //cmd.Parameters.AddWithValue("@IdChiTietDH", chiTietDonHang.getId());
                cmd.Parameters.AddWithValue("@IdDonHang", chiTietDonHang.getiddonhang());
                cmd.Parameters.AddWithValue("@IdSanPham", chiTietDonHang.getidsanpham());
                cmd.Parameters.AddWithValue("@SoLuong", chiTietDonHang.getsoluong());
                cmd.Parameters.AddWithValue("@DonGia", chiTietDonHang.getgia());
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm Thành Công");
                    return true;
                }
                else
                {
                    MessageBox.Show("Thêm không  Thành Công");
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
