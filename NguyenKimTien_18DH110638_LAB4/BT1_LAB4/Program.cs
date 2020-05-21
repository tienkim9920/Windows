using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanVien;
            Console.WriteLine("###Vui Long Nhap Thong Tin Nhan Vien###");
            Console.Write("Nhap Ma Nhan Vien: ");
            string maNV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            string hoTen = Console.ReadLine();

            NhapLai:
            Console.WriteLine("Vui Long Nhap Loai Nhan Vien");
            Console.WriteLine("(1) La Nhan Vien Kinh Doanh");
            Console.WriteLine("(2) La Nhan Vien San Xuat");
            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 1:
                    nhanVien = new NhanVienKinhDoanh(maNV, hoTen);
                    Console.Write("Nhap Luong Co Ban: ");
                    int luongCoBan = int.Parse(Console.ReadLine());
                    Console.Write("Nhap So Luong Hop Dong: ");
                    int soLuongHopDong = int.Parse(Console.ReadLine());

                    (nhanVien as NhanVienKinhDoanh).LuongCoBan = luongCoBan;
                    (nhanVien as NhanVienKinhDoanh).SoLuongHopDong = soLuongHopDong;
                    break;
                case 2:
                    nhanVien = new NhanVienSanXuat(maNV, hoTen);
                    Console.Write("Nhap Luong Co Ban: ");
                    int luongCoBanSX = int.Parse(Console.ReadLine());
                    Console.Write("Nhap Luong San Pham: ");
                    int soLuongSanPham = int.Parse(Console.ReadLine());

                    (nhanVien as NhanVienSanXuat).SoLuongSanPham = soLuongSanPham;
                    break;
                default:
                    Console.WriteLine("Vui Long Nhap (1) va (2)");
                    goto NhapLai;
            }

            int luong = nhanVien.TinhLuong();
            Console.WriteLine("Luong Cua Nhan Vien La: " + luong);
        }
    }
}
