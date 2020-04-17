using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_LAB2
{
    class Vector
    {
        Point A;
        Point B;

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

        public Vector(Point A, Point B)
        {
            this.A = A;
            this.B = B;
            x = this.B.getX() - this.A.getX();
            y = this.B.getY() - this.A.getY();
        }

        public double DoDai()
        {
            double doDai = Math.Sqrt(this.x * this.x + this.y * this.y);
            return doDai;
        }

        public static double DoDaiTinh(Point A, Point B)
        {
            double x, y;
            x = B.getX() - A.getX();
            y = B.getY() - A.getY();
            return Math.Sqrt(x * x + y * y);
        }
    }
}
