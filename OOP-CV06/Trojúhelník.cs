using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Trojúhelník : GrObject2D, GrObject2D.IFACE2D, GrObject2D.IFACE
    {
        private double a;
        private double v;
       

        public Trojúhelník(double a, double v)
        {
            this.a = a;
            this.v = v;
            
        }

        public void Kresli()
        {
            Console.WriteLine("Trojúhelník: a=" + a + ", v="+v);
        }

        public double SpoctiPlochu()
        {
            return a * v / 2;
        }
    }
}
