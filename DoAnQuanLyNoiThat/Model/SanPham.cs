using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNoiThat.Model
{
    internal class SanPham
    {
        private int idsanpham;
        private string tensanpham;
        private string mota;
        private string loaisanpham;

        public SanPham() { }

        public SanPham(string tensanPham, string mota, string loaisanpham)
        {

            this.tensanpham = tensanPham;
           
            this.mota = mota;
            this.loaisanpham = loaisanpham;
        }
        public SanPham(int idsanpham, string tensanPham, string mota, string loaisanpham)
        {
            this.idsanpham = idsanpham;
            this.tensanpham = tensanPham;
            
            this.mota = mota;
            this.loaisanpham = loaisanpham;
        }
        public int getidsanpham() { return idsanpham; }
        public string gettensanpham() { return tensanpham; }
       
        public string getmota() { return mota; }
        public string getloaisanpham() { return loaisanpham; }
        public void settensanpham(string tensanpham) { this.tensanpham = tensanpham; }
      
        public void setmota(string mota) { this.mota = mota; }
        public void setloaisanpham(string loaisanpham) { this.loaisanpham = loaisanpham; }

        public string toString()
        {
            return "Tên Sản Phẩm: " + tensanpham+  ",Mô Tả" + mota +",Loại Sản Phẩm"+ loaisanpham;
        }
    }
}
