using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic_equation
{
    public class parabola
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double x1;
        private double x2;

        public double A { get { return this.a; } set { this.a = value; } }
        public double B { get { return this.b; } set { this.a = value; } }
        public double C { get { return this.c; } set { this.a = value; } }
        public double D { get { return this.d; }}
        public double X1 { get { return this.x1; }}
        public double X2 { get { return this.x2; }}

        public parabola(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void discriminant()
        {
            this.d = b * b - 4 * a * c;
        }

        public void root_one()
        {
            x1 = -b / 2 * a;
        }

        public void root_two()
        {
            x1 = ((-b - Math.Sqrt(d)) / 2 * a);
            x2 = ((-b + Math.Sqrt(d)) / 2 * a);
        }     
    }
}
