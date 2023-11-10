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
    internal class SanPhamController
    {
        List<SanPham> SanPhamList;
        public SanPhamController()
        {
            SanPhamList = new List<SanPham>();
        }

        public List<SanPham> load()
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from SanPham", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   
                    int id = (int)reader["IdSanPham"];                   
                    String tensp = reader["TenSanPham"].ToString();              
                    String mota = reader["MoTa"].ToString();
                    String loaisp = reader["LoaiSanPham"].ToString();
                    SanPham sanpham = new SanPham(id, tensp, mota, loaisp);
                    SanPhamList.Add(sanpham);

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return SanPhamList;
        }
        public SanPham get(string id)
        {
           
                return SanPhamList.FirstOrDefault(h => h.getidsanpham() == int.Parse(id));
            
            
        }
        public bool insert(SanPham sanpham)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {               
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SanPham (TenSanPham,MoTa,LoaiSanPham) VALUES (@TenSanPham,@MoTa,@LoaiSanPham)", conn);                
                cmd.Parameters.AddWithValue("@TenSanPham", sanpham.gettensanpham());              
                cmd.Parameters.AddWithValue("@MoTa", sanpham.getmota());
                cmd.Parameters.AddWithValue("@LoaiSanPham", sanpham.getloaisanpham());
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
        public bool update(SanPham sanpham)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE SanPham SET TenSanPham=@TenSanPham,MoTa=@MoTa,LoaiSanPham=@LoaiSanPham where IdSanPham = @IdSanPham", conn);
                cmd.Parameters.AddWithValue("@IdSanPham", sanpham.getidsanpham());
                cmd.Parameters.AddWithValue("@TenSanPham", sanpham.gettensanpham());               
                cmd.Parameters.AddWithValue("@MoTa", sanpham.getmota());
                cmd.Parameters.AddWithValue("@LoaiSanPham", sanpham.getloaisanpham());
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

        public bool delete(string IDSanPham)
        {
            SqlConnection conn = DatabaseHelper.getConnection();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM SanPham WHERE IdSanPham = @IdSanPham", conn);
                cmd.Parameters.AddWithValue("@IdSanPham", IDSanPham);
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
