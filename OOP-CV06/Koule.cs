using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Koule : GrObject3D, GrObject3D.IFACE3D, GrObject3D.IFACE
    {
        private double polomer;

        public Koule(double polomer)
        {
            this.polomer = polomer;
        }

        public void Kresli()
        {
            Console.WriteLine("Koule: polomer=" + polomer);
        }

        public double SpoctiObjem()
        {
            return 4 / 3 * Math.PI * Math.Pow(polomer, 3);
        }

        public double SpoctiPovrch()
        {
            return 4 * Math.PI * Math.Pow(polomer, 2);
        }
    }
}
