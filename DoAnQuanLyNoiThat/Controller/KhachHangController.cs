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

    internal class KhachHangController
    {
        List<KhachHang> KhachHangList;

        public KhachHangController()
        {
            KhachHangList = new List<KhachHang>();
        }
        public List<KhachHang> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KhachHang", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    int idkhachhang = (int)reader["IdKhachHang"];
                    String hoten = reader["HoTen"].ToString();
                    String diachi = reader["DiaChi"].ToString();
                    String dienthoai = reader["DienThoai"].ToString();
                    DateTime ngaysinh = (DateTime)reader["NgaySinh"];
                    String gioitinh = reader["GioiTinh"].ToString();

                    KhachHang khachhang = new KhachHang(idkhachhang, hoten, diachi, dienthoai, ngaysinh, gioitinh);
                    KhachHangList.Add(khachhang);

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return KhachHangList;
        }
        public TaiKhoan get(string id)
        {
            return null;
        }
        public bool insert(KhachHang khachHang)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {                        
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang (HoTen,DiaChi,DienThoai,NgaySinh,GioiTinh) VALUES (@HoTen,@DiaChi,@DienThoai,@NgaySinh,@GioiTinh)", conn);
                cmd.Parameters.AddWithValue("@HoTen", khachHang.gethoten());
                cmd.Parameters.AddWithValue("@DiaChi", khachHang.getdiachi());
                cmd.Parameters.AddWithValue("@DienThoai", khachHang.getdienthoai());
                cmd.Parameters.AddWithValue("@NgaySinh", khachHang.getngaysinh());
                cmd.Parameters.AddWithValue("@GioiTinh", khachHang.getgioitinh());
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool update(KhachHang khachHang)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET HoTen=@HoTen,DiaChi=@DiaChi,DienThoai=@DienThoai,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh where IdKhachHang = @IdKhachHang", conn);
                cmd.Parameters.AddWithValue("@IdKhachHang", khachHang.getid());
                cmd.Parameters.AddWithValue("@HoTen", khachHang.gethoten());
                cmd.Parameters.AddWithValue("@DiaChi", khachHang.getdiachi());
                cmd.Parameters.AddWithValue("@DienThoai", khachHang.getdienthoai());
                cmd.Parameters.AddWithValue("@NgaySinh", khachHang.getngaysinh());
                cmd.Parameters.AddWithValue("@GioiTinh", khachHang.getgioitinh());
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool delete(string IdNhanVien)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM KhachHang WHERE IdKhachHang = @IdKhachHang", conn);
                cmd.Parameters.AddWithValue("@IdKhachHang", IdNhanVien);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
