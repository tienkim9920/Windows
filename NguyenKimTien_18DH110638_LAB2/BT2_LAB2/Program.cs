using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB2
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

            Vector AB = new Vector(diemA, diemB);
            Point I = AB.VectorI();

            Console.WriteLine("#######OutPut#######\n");
            Console.WriteLine("----Phuong Thuc Thanh Vien----");
            Console.WriteLine("Trung diem cua AB = ({0}, {1}) ", I.getX() , I.getY());

            Point ITinh = Vector.VectorITinh(diemA, diemB);
            Console.WriteLine("\n----Phuong Thuc Tinh----");
            Console.WriteLine("Trung diem cua AB = ({0}, {1}) ", ITinh.getX(), ITinh.getY());
            Console.ReadKey();
        }
    }
}
