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
    internal class TaiKhoanController
    {
        List<TaiKhoan> TaiKhoanList;
        public TaiKhoanController()
        {
            TaiKhoanList = new List<TaiKhoan>();
        }
        
        public List<TaiKhoan> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("select * from TaiKhoan", conn);
               
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id         =(int) reader["IdTaiKhoan"];
                    int idnhanvien =(int) reader["IdNhanVien"];
                    String hoten = reader["HoTen"].ToString();
                    String tendangnhap = reader["TenDangNhap"].ToString();
                    String matkhau = reader["MatKhau"].ToString();
                    String vaitro = reader["VaiTro"].ToString();
                    
                    TaiKhoan taikhoan = new TaiKhoan(id,idnhanvien, hoten,tendangnhap,matkhau,vaitro);
                    TaiKhoanList.Add(taikhoan);
                    
                }               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return TaiKhoanList;
        }
        public TaiKhoan get(string id)
        {
            return null;
        }
        public bool KiemtraDN(string taikhoan, string matkhau)
        {
            SqlConnection conn = DatabaseHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau", conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", taikhoan);
                cmd.Parameters.AddWithValue("@MatKhau", matkhau);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
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
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                return false;
            }
            finally
            {
                conn.Close();

            }
        }
        public bool insert(TaiKhoan taikhoan)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO TaiKhoan (IdNhanVien,HoTen,TenDangNhap,MatKhau,VaiTro) VALUES (@IdNhanVien,@HoTen,@TenDangNhap,@MatKhau,@VaiTro)", conn);
                //cmd.Parameters.AddWithValue("@Id", null);
                cmd.Parameters.AddWithValue("@IdNhanVien", taikhoan.getidnhanvien());
                cmd.Parameters.AddWithValue("@HoTen", taikhoan.gethoten());
                cmd.Parameters.AddWithValue("@TenDangNhap", taikhoan.gettendangnhap());
                cmd.Parameters.AddWithValue("@MatKhau", taikhoan.getmatkhau());
                cmd.Parameters.AddWithValue("@VaiTro", taikhoan.getvaitro());
                
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
        public bool update(TaiKhoan taiKhoan)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TaiKhoan SET IdNhanVien = @IdNhanVien,HoTen=@HoTen,TenDangNhap=@TenDangNhap,MatKhau=@MatKhau,VaiTro= @VaiTro where IdTaiKhoan = @IdTaiKhoan", conn);
                cmd.Parameters.AddWithValue("@IdTaiKhoan", taiKhoan.getid());
                cmd.Parameters.AddWithValue("@IdNhanVien", taiKhoan.getidnhanvien());
                cmd.Parameters.AddWithValue("@HoTen", taiKhoan.gethoten());
                cmd.Parameters.AddWithValue("@TenDangNhap", taiKhoan.gettendangnhap());
                cmd.Parameters.AddWithValue("@MatKhau", taiKhoan.getmatkhau());
                cmd.Parameters.AddWithValue("@VaiTro", taiKhoan.getvaitro());
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

        public bool delete(string IdTaiKhoan)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM TaiKhoan WHERE IdTaiKhoan = @IdTaiKhoan", conn);
                cmd.Parameters.AddWithValue("@IdTaiKhoan", IdTaiKhoan);
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
