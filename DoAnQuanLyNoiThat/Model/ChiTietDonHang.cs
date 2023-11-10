using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNoiThat.Model
{
    internal class ChiTietDonHang
    {   
        
        private int iddonhang;
        private int idsanpham;
        private int soluong;
        private decimal dongia;

        public ChiTietDonHang() { }

        public ChiTietDonHang(int iddonhang, int idsanpham, int soluong, decimal dongia)
        {
             
            this.iddonhang = iddonhang;
            this.idsanpham = idsanpham;
            this.soluong = soluong;
            this.dongia = dongia;
        }
     
        public int getiddonhang() {  return iddonhang; }
        public int getidsanpham() {  return idsanpham; }
        public int getsoluong() {  return soluong; }
        public decimal getgia() {  return dongia; }

        public void setiddonhang(int iddonhang) {  this.iddonhang = iddonhang;}
        public void setidsanpham(int idsanpham) { this.idsanpham= idsanpham; }
        public void setsoluong(int soluong) {  this.soluong = soluong;}
        public void setgia(decimal gia) {  this.dongia = gia;}

        public String toString()    
        {
            return iddonhang + idsanpham + soluong+""+ dongia;
        }
    }
}
