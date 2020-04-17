using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_LAB2
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
        }

        public Point VectorI()
        {
            double x, y;
            x = (this.B.getX() - this.A.getX()) / 2;
            y = (this.B.getY() - this.A.getY()) / 2;
            Point I = new Point(x, y);
            return I;
        }

        public static Point VectorITinh(Point A, Point B)
        {
            double x, y;
            x = (B.getX() - A.getX()) / 2;
            y = (B.getY() - A.getY()) / 2;
            Point I = new Point(x, y);
            return I;
        }
    }
}
