
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB3
{
    class Mang1Chieu
    {
        private int[] arr = new int[100];

        public Mang1Chieu() { }

        public Mang1Chieu(int soPhanTu)
        {
            this.arr = new int[soPhanTu];
        }

        public int this[int i]
        {
            get { return arr[i]; }
            set
            {
                arr[i] = value;
            }
        }

        public int length
        {
            get { return arr.Length; }
        }

        public void printArray()
        {
            for (int i = 0; i < this.length; i++)
            {
                Console.Write(this[i] + " ");
            }
            Console.WriteLine();
        }

        public void printSoChan()
        {
            for (int i = 0; i < this.length; i++)
            {
                if (this[i] % 2 == 0)
                {
                    Console.Write(this[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
