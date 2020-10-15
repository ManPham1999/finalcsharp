using System;
namespace FinalCshape
{
    public class SanPham
    {
        public string Masp { get; set; }
        public string Tensp { get; set; }
        public double Giasp { get; set; }
        public int Soluong { get; set; }

        public SanPham(string masp, string tensp, double giasp, int soluong)
        {
            Masp = masp;
            Tensp = tensp;
            Giasp = giasp;
            Soluong = soluong;
        }
        public SanPham()
        {
        }
        
        public double ToMoney()
        {
            var giatien = Giasp * Soluong;
            return giatien;
        }
    } 
}
