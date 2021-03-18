using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Jehlan : GrObject3D, GrObject3D.IFACE3D, GrObject3D.IFACE
    {
        private double a;
        private double v;

        public Jehlan(double a, double v)
        {
            this.a = a;
            this.v = v;
        }

        public void Kresli()
        {
            Console.WriteLine("Jehlan: v=" + v+", a=" + a);
        }

        public double SpoctiObjem()
        {
            return (a * a * v) / 3;
        }

        public double SpoctiPovrch()
        {
            return 4 * (Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(v, 2)) * a) / 2 + (a * a);
        }
    }
}
