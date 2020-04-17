using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap toa do diem x cua A: ");
            double xA = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem y cua A: ");
            double yA = double.Parse(Console.ReadLine());
            Point diemA = new Point(xA, yA);

            Console.Write("Nhap toa do diem x cua B: ");
            double xB = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem y cua B: ");
            double yB = double.Parse(Console.ReadLine());
            Point diemB = new Point(xB, yB);

            Console.WriteLine("Toa do cua diem A = ({0}, {1})", diemA.getX(), diemA.getY());
            Console.WriteLine("Toa do cua diem B = ({0}, {1})", diemB.getX(), diemB.getY());

            Vector vectorAB = new Vector(diemA, diemB);

            Console.WriteLine("Toa do cua Vector AB = ({0}, {1})", vectorAB.getX(), vectorAB.getY());
            Console.WriteLine("#######OutPut#######\n");
            Console.WriteLine("----Phuong Thuc Thanh Vien----");
            Console.WriteLine("Do dai cua Vector AB la: " + vectorAB.DoDai());

            Console.WriteLine("\n----Phuong Thuc Tinh----");
            Console.WriteLine("Do dai cua Vector AB la: " + Vector.DoDaiTinh(diemA, diemB));
            Console.ReadKey();
        }
    }
}
