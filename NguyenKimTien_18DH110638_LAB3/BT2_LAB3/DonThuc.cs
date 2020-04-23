using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB3
{
    public class DonThuc
    {
        public double heSoA;
        public int soMu;

        public DonThuc()
        {
            this.heSoA = 1;
            this.soMu = 0;
        }

        public DonThuc(double heSoA, int soMu)
        {
            this.heSoA = heSoA;
            this.soMu = soMu;
        }
    }
}
