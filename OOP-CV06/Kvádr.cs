using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Kvádr : GrObject3D, GrObject3D.IFACE3D, GrObject3D.IFACE
    {
        private double a;
        private double b;
        private double c;

        public Kvádr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Kresli()
        {
            Console.WriteLine("Kvádr: a="  + a+ ", b=" + b+", c="+c);
        }

        public double SpoctiObjem()
        {
            return a * b * c;
        }

        public double SpoctiPovrch()
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
}
