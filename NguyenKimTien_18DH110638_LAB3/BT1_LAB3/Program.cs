using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang1Chieu array = new Mang1Chieu(4);

            for (int i = 0; i < array.length; i++)
            {
                Console.Write("Nhap Phan Tu Thu {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Day So Mang La: ");
            array.printArray();
            Console.Write("Day So Chan Cua Mang La: ");
            array.printSoChan();
        }
    }
}
