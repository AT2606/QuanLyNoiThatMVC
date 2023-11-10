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

    internal class NhanVienController
    {
        List<NhanVien> NhanVienList;

        public NhanVienController()
        {
            NhanVienList = new List<NhanVien>();
        }

        public List<NhanVien> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NhanVien", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int idnhanvien = (int)reader["IdNhanVien"];
                    String hoten = reader["HoTen"].ToString();
                    String sdt = reader["DienThoai"].ToString();
                    DateTime ngaysinh = (DateTime)reader["NgaySinh"];
                    String chucvu = reader["ChucVu"].ToString();
                    Decimal luong = (Decimal)reader["Luong"];

                    NhanVien nhanvien = new NhanVien(idnhanvien, hoten, sdt, ngaysinh, chucvu, luong);
                    NhanVienList.Add(nhanvien);

                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return NhanVienList;
        }
        public TaiKhoan get(string id)
        {
            return null;
        }
        public bool insert(NhanVien nhanVien)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien (HoTen,DienThoai,NgaySinh,ChucVu,Luong) VALUES (@HoTen,@DienThoai,@NgaySinh,@ChucVu,@Luong)", conn);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.gethoten());
                cmd.Parameters.AddWithValue("@DienThoai", nhanVien.getdienthoai());
                cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.getngaysinh());
                cmd.Parameters.AddWithValue("@ChucVu", nhanVien.getchucvu());
                cmd.Parameters.AddWithValue("@Luong", nhanVien.getluong());
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
        public bool update(NhanVien nhanVien)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET HoTen=@HoTen,DienThoai=@DienThoai,NgaySinh=@NgaySinh,ChucVu=@ChucVu,Luong=@Luong where IdNhanVien = @IdNhanVien", conn);
                cmd.Parameters.AddWithValue("@IdNhanVien", nhanVien.getid());
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.gethoten());
                cmd.Parameters.AddWithValue("@DienThoai", nhanVien.getdienthoai());
                cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.getngaysinh());
                cmd.Parameters.AddWithValue("@ChucVu", nhanVien.getchucvu());
                cmd.Parameters.AddWithValue("@Luong", nhanVien.getluong());
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
                SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE IdNhanVien = @IdNhanVien", conn);
                cmd.Parameters.AddWithValue("@IdNhanVien", IdNhanVien);
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
