using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Kruh : GrObject2D, GrObject2D.IFACE2D, GrObject2D.IFACE
    {
        private int polomer;

        public Kruh(int polomer)
        {
            this.polomer = polomer;
        }

        public void Kresli()
        {
            Console.WriteLine("Kruh: polomer="+polomer);
        }

        public double SpoctiPlochu()
        {
            return Math.PI * Math.Pow(polomer, 2);
        }
    }
}
