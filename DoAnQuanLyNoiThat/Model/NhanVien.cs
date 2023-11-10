using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNoiThat.Model
{
    internal class NhanVien
    {
        private int idNV;
        private string hoten;
        private string dienthoai;
        private DateTime ngaysinh;
        private string chucvu;
        private decimal luong;

        public NhanVien() { }

        public NhanVien(int idNV,string hoten, string dienthoai, DateTime ngaysinh, string chucvu, decimal luong)
        { 
            this.idNV = idNV;
            this.hoten = hoten;
            this.dienthoai = dienthoai;
            this.ngaysinh = ngaysinh;
            this.chucvu = chucvu;
            this.luong = luong;
        }
        public NhanVien( string hoten, string dienthoai, DateTime ngaysinh, string chucvu, decimal luong)
        {         
            this.hoten = hoten;
            this.dienthoai = dienthoai;
            this.ngaysinh = ngaysinh;
            this.chucvu = chucvu;
            this.luong = luong;
        }
        public int getid() { return idNV; }
        public string gethoten() { return hoten; }
        public string getdienthoai() { return dienthoai; }
        public DateTime getngaysinh() { return ngaysinh; }
        public String getchucvu() { return chucvu; }
        public decimal getluong() { return luong; }
        public void sethoten(String hoten) { this.hoten = hoten; }
        public void setdienthoai(string dienthoai) { this.dienthoai = dienthoai; }
        public void setngaysinh(DateTime ngaysinh) { this.ngaysinh = ngaysinh; }
        public void setchucvu(string chucvu) {  this.chucvu = chucvu;}
        public void setluong(decimal luong) {  this.luong = luong; }
        public String toString()
        {
            return hoten+dienthoai+ngaysinh+chucvu;
        }
    }
}
