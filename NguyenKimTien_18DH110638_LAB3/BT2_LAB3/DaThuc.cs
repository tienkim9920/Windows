using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB3
{
    class DaThuc
    {
        public DonThuc[] dathuc;

        public int soLuongDonThuc;

        public DaThuc()
        {
            dathuc = new DonThuc[1];
            dathuc[0] = new DonThuc();
        }

        public DaThuc(int soLuongDonThuc)
        {
            dathuc = new DonThuc[soLuongDonThuc];
            this.soLuongDonThuc = soLuongDonThuc;

            for (int i = 0; i < soLuongDonThuc; i++)
            {
                this[i] = new DonThuc();
            }
        }

        public DonThuc this[int i]
        {
            get { return dathuc[i]; }
            set
            {
                dathuc[i] = value;
            }
        }

        public void khoiTaoDaThuc()
        {
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                DonThuc nDonThuc = this[i];
                nDonThuc.soMu = i;
                Console.Write("Nhap He So A cho Don Thuc: ");
                nDonThuc.heSoA = double.Parse(Console.ReadLine());
            }
        }

        public void printDaThuc()
        {
            Console.WriteLine("#####In Da Thuc#####");
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                DonThuc nDonThuc = this[i];
                Console.Write(nDonThuc.heSoA + "*" + "x^" + nDonThuc.soMu);
                if (i != this.soLuongDonThuc - 1)
                {
                    Console.Write(" + ");
                }
            }
        }

        public void XuLyGiaTri(int x)
        {
            double reSult = 0;
            for (int i = 0; i < this.soLuongDonThuc; i++)
            {
                DonThuc nDonThuc = this[i];
                reSult += nDonThuc.heSoA * Math.Pow(x, nDonThuc.soMu);
            }
            Console.WriteLine("Gia Tri Cua Da Thuc La: " + reSult);
        }
    }
}
