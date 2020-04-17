using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Ho Ten Sinh Vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap Nam Sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            SinhVien sinhvien = new SinhVien(hoTen, namSinh);

            Console.WriteLine("####OutPut####");
            Console.WriteLine("\n----Phuong Thuc Thanh Vien----");
            Console.WriteLine("Tuoi Cua Sinh Vien La: " + sinhvien.xuLyTuoi());

            Console.WriteLine("\n----Phuong Thuc Tinh----");
            Console.WriteLine("Tuoi Cua Sinh Vien La: " + SinhVien.xuLyTuoiTinh(sinhvien));
            Console.ReadKey();
        }
    }
}
