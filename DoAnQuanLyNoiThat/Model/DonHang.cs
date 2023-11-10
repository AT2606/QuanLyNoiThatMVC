using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNoiThat.Model
{
    internal class DonHang
    {
        private int iddonhang;
        private int idkhachhang;
        private int idnhanvien;
        private DateTime ngaydathang;
        private decimal tongtien;
        private string trangthai;

        public DonHang() { }

        public DonHang(int iddonhang, int idkhachhang, int idnhanvien, DateTime ngaydathang, decimal tongtien, string trangthai)
        {
            this.iddonhang = iddonhang;
            this.idkhachhang = idkhachhang;
            this.idnhanvien = idnhanvien;
            this.ngaydathang = ngaydathang;
            this.tongtien = tongtien;
            this.trangthai = trangthai;
        }
        public int getiddonhang() { return iddonhang; }
        public int getidkhachhang() {  return idkhachhang; }
        public int getidnhanvien() {  return idnhanvien; }
        public DateTime getngaydathang() {  return ngaydathang; }
        public decimal gettongtien() { return tongtien; }
        public string gettrangthai() {  return trangthai; }

        public void setiddonhang(int iddonhang) {  this.iddonhang = iddonhang;}
        public void setidkhachhang(int idkhachhang) { this.idkhachhang= idkhachhang;}

        public void setidnhanvien(int idnhanvien) { this.idnhanvien= idnhanvien;}
        public void setngaydathang(DateTime ngaydathang) { this.ngaydathang= ngaydathang;}
        public void settongtien(decimal tongtien) { this.tongtien= tongtien;}

        public void settrangthai (string trangthai) {  this.trangthai= trangthai;}

        public String toString()
        {
            return iddonhang  + idkhachhang+ idnhanvien+ tongtien+ trangthai + ngaydathang;
        }
    }
}
