using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCshape
{
    class Program
    {
        static List<SanPham> ProList = new List<SanPham> { };
        static List<HoaDon> BillList = new List<HoaDon> { };
        static List<KhachHang> CustomerList = new List<KhachHang> { };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var flag = false;
            do
            {
                ShowMenu();
                Console.WriteLine("Ban muon thoat chuong trinh ?(y/n)");
                var userChoice = Console.ReadLine();
                if (userChoice == "y")
                {
                    flag = true;
                }
            } while (!flag);
        }
        private static void ShowMenu()
        {
            Console.WriteLine("Console quản lí kho hàng");
            Console.WriteLine("(1)Nhập xuất thông tin do người dùng nhập");
            Console.WriteLine("(2)Xuất thông tin có sẵn dữ liệu");
            Console.WriteLine("(3)Tổng tiền các hóa đơn mà khách hàng đã mua");
            Console.WriteLine("(4)liệt kê thông tin các hóa đơn bán trong tháng đó và hiển thị tổng tiền của từng hóa đơn");
            Console.WriteLine("(5)Tìm sản phẩm có giá tiền lớn nhất trong mỗi một hóa đơn.");
            Console.WriteLine("(6)Liệt kê thông tin các sản phẩm có tên chứa từ khóa tìm kiếm vừa nhập.");
            Console.WriteLine("(7)Liệt kê tất cả hàng hóa mà chưa bán lần nào.");
            Console.WriteLine("(8)Liệt kê tên tất cả sản phẩm đã được bán cho mỗi một khách hàng đã mua.");
            Console.WriteLine("Tính tổng tiền cho tất cả sản phẩm:");
            Console.Write("Vui lòng chọn chức năng:");
            var FuncionalChoice = Console.ReadLine();
            Console.WriteLine("-------------------------------------");
            switch (FuncionalChoice)
            {
                case "1":
                    Console.WriteLine("Bạn đang chọn chức năng 1");
                    Func1();
                    break;
                case "2":
                    Console.WriteLine("Bạn đang chọn chức năng 2");
                    Func2();
                    break;
                case "3":
                    Console.WriteLine("Bạn đang chọn chức năng 3");
                    Func3();
                    break;
                case "4":
                    Console.WriteLine("Bạn đang chọn chức năng 4");
                    Func4();
                    break;
                case "5":
                    Console.WriteLine("Bạn đang chọn chức năng 5");
                    Func5();
                    break;
                case "6":
                    Console.WriteLine("Bạn đang chọn chức năng 6");
                    Func6();
                    break;
                case "7":
                    Console.WriteLine("Bạn đang chọn chức năng 7");
                    Func7();
                    break;
                case "8":
                    Console.WriteLine("Bạn đang chọn chức năng 8");
                    Func8();
                    break;
                default:
                    break;
            }
        }
        private static void Func1()
        {
            SanPham Product = new SanPham("cf01", "ca phe so 1", 75, 5);
            SanPham Product1 = new SanPham("cf02", "ca phe so 2", 65, 15);
            SanPham Product2 = new SanPham("ip01", "Iphone 8", 100, 20);
            SanPham Product3 = new SanPham("ip02", "Iphone 7", 150, 6);
            SanPham Product4 = new SanPham("xd01", "Xe dap strongman xanh", 70, 4);
            SanPham Product5 = new SanPham("xd02", "Xe martin", 70, 3);
            var flagFC1 = false;

            ProList.AddRange(new SanPham[] { Product, Product1, Product2, Product3, Product4, Product5 });
            Console.WriteLine("Danh sách các sản phẩm đang kinh doanh tại cửa hàng:");
            for (int i = 0; i < ProList.Count; i++)
            {
                Console.WriteLine("Mã sp: " + ProList[i].Masp);
                Console.WriteLine("Tên sp: " + ProList[i].Tensp);
                Console.WriteLine("Giá sp: " + ProList[i].Giasp);
                Console.WriteLine("Số lượng còn trong kho: " + ProList[i].Soluong);
                Console.WriteLine("");
            }
            do
            {
                Console.WriteLine("Vui lòng chọn mã sản phẩm bạn muốn mua: ");
                var chosenProId = ValidationCustom<string>.CheckValid();
                Console.WriteLine("Nhập số lượng: ");
                var QuantityPro = ValidationCustom<int>.CheckValid();
                Console.WriteLine("Nhập thông tin KH:");
                KhachHang cus = new KhachHang();
                Console.WriteLine("Tên khách hàng: ");
                cus.HoTen = ValidationCustom<string>.CheckValid();
                Console.WriteLine("Mã khách hàng:");
                cus.MaKh = ValidationCustom<string>.CheckValid();
                Console.WriteLine("Nhập thông tin HĐ:");
                HoaDon bll = new HoaDon();
                Console.WriteLine("Tên hóa đơn: ");
                bll.TenHd = ValidationCustom<string>.CheckValid();
                Console.WriteLine("Ngày lập hóa đơn: ");
                bll.NgayLapHd = ValidationCustom<DateTime>.CheckValid();
                foreach (var product in ProList)
                {
                    if (product.Masp == chosenProId)
                    {
                        bll.AddPro(product);
                    }
                }
                Console.WriteLine("ahjhj");
                BillList.Add(bll);
                cus.AddBill(bll);
                CustomerList.Add(cus);
                Console.WriteLine("Mua tiếp?(y/n)");
                var result = Console.ReadLine();
                if (result == "k")
                {
                    flagFC1 = true;
                }
            } while (!flagFC1);
        }
        private static void Func2()
        {

        }
        private static void Func3()
        {

        }
        private static void Func4()
        {

        }
        private static void Func5()
        {

        }
        private static void Func6()
        {

        }
        private static void Func7()
        {

        }
        private static void Func8()
        {

        }
    }
}