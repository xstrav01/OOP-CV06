using System;

namespace OOP_CV06
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObject[] gr = { new Kruh(5), new Obdélník(5, 8), new Elipsa(4, 6), new Trojúhelník(5, 10), new Kvádr(5, 8, 10), new Valec(3,8), new Koule(8), new Jehlan(6, 10) };

            double plocha = 0;
            double povrch = 0;
            double objem = 0;

            foreach (GrObject.IFACE item in gr)
            {
                item.Kresli();

                if (item is GrObject2D)
                {
                    GrObject2D.IFACE2D gr2d = (GrObject2D.IFACE2D)item;
                    plocha += gr2d.SpoctiPlochu();
                    povrch += gr2d.SpoctiPlochu();
                }
                else if (item is GrObject3D)
                {
                    GrObject3D.IFACE3D gr3d = (GrObject3D.IFACE3D)item;
                    objem += gr3d.SpoctiObjem();
                    povrch += gr3d.SpoctiPovrch();
                }

                
            }
            Console.WriteLine();
            Console.WriteLine("Celková plocha 2D objektů: " + plocha);
            Console.WriteLine("Celkový objem 3D objektů: " + objem);
            Console.WriteLine("Celkový povrch všech objektů: " + povrch);
        }
    }
}
