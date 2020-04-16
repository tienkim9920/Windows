using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB1
{
    class Program
    {
        static int TinhLuyThua(int x, int y)
        {
            int reSult = 1;
            for (int i = 1; i <= y; i++)
            {
                reSult *= x;
            }
            return reSult;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap So Nguyen X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhap Luy Thua Y: ");
            int y = int.Parse(Console.ReadLine());

            int reSult = TinhLuyThua(x, y);
            Console.WriteLine("\nKet Qua La: " + reSult);
            Console.ReadKey();
        }
    }
}
