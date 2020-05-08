using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB6
{
    class Program
    {
        static void Them()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap MSHH: ");
            string mshh = Console.ReadLine();
            Console.Write("Nhap Ten Hang: ");
            string tenHang = Console.ReadLine();
            Console.Write("Nhap Gia: ");
            int gia = int.Parse(Console.ReadLine());
            Console.Write("Nhap Tinh Trang: ");
            int tinhTrang = int.Parse(Console.ReadLine());
            Data.ThemSanPham(mshh, tenHang, gia, tinhTrang);
            Data.ListSanPham();
        }
        static void Xoa()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap MSHH Can Xoa: ");
            string mshh = Console.ReadLine();
            Data.XoaSanPham(mshh);
            Data.ListSanPham();
        }
        static void Sua()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap MSHH Can Sua: ");
            string mshh = Console.ReadLine();
            Data.SuaSanPham(mshh);
            Data.ListSanPham();
        }

        static void ThemHoaDon()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap MS Hoa Don: ");
            string msdh = Console.ReadLine();
            Data.TaoHoaDon(msdh, "08/05/2020");
            Data.ListHoaDon();
        }
        static void Main(string[] args)
        {
            DataProvider Data = new DataProvider();
            Console.WriteLine("Danh Sach Cac Thuc Uong");
            Data.ListSanPham();
            Console.Write("Nhap MS Hoa Don: ");
            string msdh = Console.ReadLine();
            Console.Write("Vui Long Ma So Thuc Uong Ban Muon Dat: ");
            string mshh = Console.ReadLine();
            Console.Write("Vui Long So Luong Ban Muon Dat: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Vui Long Ti Le Giam: ");
            int tiLeGiam = int.Parse(Console.ReadLine());

            Data.TaoHDChiTiet(msdh, mshh, soLuong, tiLeGiam);
            Data.LietKeChiTiet();
        }
    }
}
