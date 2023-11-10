using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNoiThat.Model
{
    internal class KhachHang
    {
        private int id;
        private string hoten;
        private string diachi;
        private string dienthoai;
        private DateTime ngaysinh;
        private string gioitinh;

        public KhachHang() { }

        public KhachHang(string hoten, string diachi, string dienthoai, DateTime ngaysinh, string gioitinh)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
        }
        public KhachHang(int id,string hoten, string diachi, string dienthoai, DateTime ngaysinh, string gioitinh)
        {
            this.id = id;
            this.hoten = hoten;
            this.diachi = diachi;
            this.dienthoai = dienthoai;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
        }
        public int getid() {  return id; }
        public string gethoten( ){ return hoten; }
        public string getdiachi() { return diachi;}
        public string getdienthoai() { return dienthoai; }
        public DateTime getngaysinh() {  return ngaysinh;}
        public string getgioitinh() {  return gioitinh;}

        public void sethoten(String hoten) { this.hoten = hoten; }
        public void setdiachi(string diachi) {  this.diachi = diachi;}
        public void setdienthoai(string dienthoai) { this.dienthoai=dienthoai;}
        public void setngaysinh(DateTime ngaysinh) { this.ngaysinh=ngaysinh;}
        public void setgioitinh(string gioitinh) { this.gioitinh=gioitinh;}
        public String toString()
        {
            return hoten + diachi + dienthoai+ngaysinh+gioitinh;
        }

    }
}
