using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNoiThat.Model
{
    internal class TaiKhoan
    {
        private int id;
        private int idnhanvien;
        private string hoten;
        private string tendangnhap;
        private string matkhau;
        private string vaitro;
        public TaiKhoan() { }
       
        public TaiKhoan(int id,int idnhanvien, string hoten, string tendangnhap, string matkhau, string vaitro)
        {
            this.id = id;
            this.idnhanvien = idnhanvien;
            this.hoten = hoten;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.vaitro = vaitro;
        }
        public TaiKhoan(int idnhanvien, string hoten, string tendangnhap, string matkhau, string vaitro)
        {

            this.idnhanvien = idnhanvien;
            this.hoten = hoten;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            this.vaitro = vaitro;
        }

        public int getid() { return id; }
        public int getidnhanvien() { return idnhanvien; }
        public String gethoten() { return hoten; }
        public String gettendangnhap() { return tendangnhap; }
        public String getmatkhau() { return matkhau; }
        public String getvaitro() { return vaitro; }
        
        public void setid(int id) { this.id = id; }
        public void setidnhanvien(int idnhanvien) { this.idnhanvien = idnhanvien; }
        public void sethoten(String hoten) { this.hoten = hoten; }

        public void settendangnhap(String tendangnhap) { this.tendangnhap = tendangnhap; }
        public void setmatkhau(String matkhau) { this.matkhau = matkhau; }
        public void setvaitro(String vaitro) { this.vaitro = vaitro; }
        public String toString()
        {
            return id + idnhanvien + hoten + tendangnhap + matkhau + vaitro;
        }
    }
}
