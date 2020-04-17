using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB2
{
    class Point
    {
        public double x;
        public double y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
