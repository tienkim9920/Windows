using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Ma Sinh Vien: ");
            string maSV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap Dia Chi: ");
            string diaChi = Console.ReadLine();
            Console.Write("Nhap Nam Sinh Vien: ");
            int namSinhVien = int.Parse(Console.ReadLine());

            SinhVien sinhVien = new SinhVien(maSV, hoTen, diaChi, namSinhVien);

            Console.WriteLine(sinhVien.OutPut());
            Console.ReadKey();
        }
    }
}
