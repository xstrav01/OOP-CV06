using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_CV06
{
    class Elipsa : GrObject2D, GrObject2D.IFACE2D, GrObject2D.IFACE
    {
        private double hlPoloosa;
        private double vedlPoloosa;
        

        public Elipsa(double hlPoloosa, double vedlPoloosa)
        {
            this.hlPoloosa = hlPoloosa;
            this.vedlPoloosa = vedlPoloosa;
            
        }

        public void Kresli()
        {
            Console.WriteLine("Elipsa: hlavní poloosa=" + hlPoloosa + ", vedlejší poloosa=" + vedlPoloosa);
        }

        public double SpoctiPlochu()
        {
            return hlPoloosa * vedlPoloosa * Math.PI;
        }
    }
}
