using System;
using System.Collections.Generic;

namespace FinalCshape
{
    public class HoaDon
    {
        public string MaHd { get; set; }
        public string TenHd { get; set; }
        public DateTime NgayLapHd{get; set;}
        public List<SanPham> Dssp { get; set; }
        public HoaDon() { }
        public HoaDon(string maHd, string tenHd, DateTime ngayLapHd, List<SanPham> dssp)
        {
            MaHd = maHd;
            TenHd = tenHd;
            NgayLapHd = ngayLapHd;
            Dssp = dssp;
        }
        public double TongTien()
        {
            double tong = 0.0;

            foreach (var item in Dssp)
            {
                tong += item.ToMoney();
            }
            return tong;
        }
        public void AddPro(SanPham pro)
        {
            Dssp.Add(pro);
        }
    }
}
