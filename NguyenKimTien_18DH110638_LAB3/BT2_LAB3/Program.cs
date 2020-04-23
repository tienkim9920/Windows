using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            DaThuc newDathuc = new DaThuc(4);
            newDathuc.khoiTaoDaThuc();
            newDathuc.printDaThuc();

            Console.Write("\nNhap Gia Tri X Cua Da Thuc: ");
            int x = int.Parse(Console.ReadLine());
            newDathuc.XuLyGiaTri(x);
        }
    }
}
