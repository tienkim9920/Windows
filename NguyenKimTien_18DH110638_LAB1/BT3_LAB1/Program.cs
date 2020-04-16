using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap So Nguyen To: ");
            int n = int.Parse(Console.ReadLine());

            SoNguyenTo soNguyenTo = new SoNguyenTo(n);

            if (soNguyenTo.CheckSoNguyenTo())
            {
                Console.WriteLine("\n{0} La So Nguyen To", soNguyenTo.n);
            }
            else
            {
                Console.WriteLine("\n{0} Khong La So Nguyen To", soNguyenTo.n);
            }

            Console.ReadKey();
        }
    }
}
