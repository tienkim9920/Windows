using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3_LAB1
{
    class SoNguyenTo
    {
        public int n;

        public SoNguyenTo(int n)
        {
            this.n = n;
        }

        public bool CheckSoNguyenTo()
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n == 2 || n == 3)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
