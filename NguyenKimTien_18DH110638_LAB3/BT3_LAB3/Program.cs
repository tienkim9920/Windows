using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            DayPhanSo dayPhanSo = new DayPhanSo(3);

            dayPhanSo.KhoiTaoPhanSo();
            dayPhanSo.PrintPhanSo();
            Console.Write("Tong cua day so nay la: ");
            dayPhanSo.TongDayPhanSo().prettyPrint();
            Console.WriteLine();
        }
    }
}
