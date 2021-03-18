using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Valec : GrObject3D, GrObject3D.IFACE3D, GrObject3D.IFACE
    {
        private double polomer;
        private double vyska;

        public Valec(double polomer, double vyska)
        {
            this.polomer = polomer;
            this.vyska = vyska;
        }

        public void Kresli()
        {
            Console.WriteLine("Válec: polomer=" + polomer +", vyska=" + vyska);
        }

        public double SpoctiObjem()
        {
            return Math.PI * Math.Pow(polomer, 2) * vyska;
        }

        public double SpoctiPovrch()
        {
            return 2 * Math.PI * Math.Pow(polomer, 2) + 2 * Math.PI * polomer * vyska;
        }
    }

}
