using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB3
{
    class DayPhanSo
    {
        PhanSo[] dayPhanSo;

        public int soLuongPhanTu;

        public DayPhanSo()
        {
            dayPhanSo = new PhanSo[0];
        }

        public DayPhanSo(int soLuongPhanTu)
        {
            dayPhanSo = new PhanSo[soLuongPhanTu];
            this.soLuongPhanTu = soLuongPhanTu;

            for (int i = 0; i < this.soLuongPhanTu; i++)
            {
                this[i] = new PhanSo();
            }
        }

        public PhanSo this[int i]
        {
            get { return dayPhanSo[i]; }
            set
            {
                dayPhanSo[i] = value;
            }
        }

        public void KhoiTaoPhanSo()
        {
            Console.WriteLine("#####Vui Long Nhap Day Phan So#####");
            for (int i = 0; i < this.soLuongPhanTu; i++)
            {
                PhanSo nPhanSo = this[i];
                Console.WriteLine("###Phan So Thu {0}###", i + 1);
                Console.Write("Hay Nhap Tu So: ");
                nPhanSo.tuSo = int.Parse(Console.ReadLine());
                Console.Write("Hay Nhap Mau So: ");
                nPhanSo.mauSo = int.Parse(Console.ReadLine());
            }
        }

        public void PrintPhanSo()
        {
            Console.WriteLine("#####In Day Phan So#####");
            for (int i = 0; i < this.soLuongPhanTu; i++)
            {
                PhanSo nPhanSo = this[i];
                Console.Write(nPhanSo.tuSo + "/" + nPhanSo.mauSo);
                if (i != this.soLuongPhanTu - 1)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine();
        }

        public PhanSo TongDayPhanSo()
        {
            PhanSo kq = new PhanSo();
            for (int i = 0; i < this.soLuongPhanTu; i++)
            {
                kq = kq + this[i];
            }
            return PhanSo.Reduce(kq);
        }
    }
}
