using System;
using System.Collections.Generic;

namespace FinalCshape
{
    public class KhachHang
    {
        public string MaKh { get; set; }
        public string HoTen { get; set; }
        public List<HoaDon> DsHd { get; set; }
        public KhachHang()
        {
        }

        public KhachHang(string maKh, string hoTen, List<HoaDon> dsHd)
        {
            MaKh = maKh;
            HoTen = hoTen;
            DsHd = dsHd;
        }
        public void AddBill(HoaDon bll)
        {
            DsHd.Add(bll);
        }
    }
}
