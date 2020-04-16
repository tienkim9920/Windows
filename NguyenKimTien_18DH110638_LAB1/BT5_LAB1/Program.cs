using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Ho Ten Nhan Vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap Muc Luong: ");
            double mucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap So Ngay Vang: ");
            int soNgayVang = int.Parse(Console.ReadLine());

            NhanVien nhanVien = new NhanVien(hoTen, mucLuong, soNgayVang);

            nhanVien.Luong();
            Console.WriteLine(nhanVien.OutPut());
            Console.ReadLine();
            
        }
    }
}
