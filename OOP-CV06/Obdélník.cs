using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Obdélník : GrObject2D, GrObject2D.IFACE2D, GrObject2D.IFACE
    {
        private double a;
        private double b;

        public Obdélník(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Kresli()
        {
            Console.WriteLine("Obdélník: a="+a+", b=" + b);
        }

        public double SpoctiPlochu()
        {
            return a * b;
        }
    }
}
