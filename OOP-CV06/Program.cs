using System;

namespace OOP_CV06
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObject[] gr = { new Kruh(5), new Obdélník(5, 8), new Elipsa(4, 6), new Trojúhelník(5, 10), new Kvádr(5, 8, 10), new Valec(3,8), new Koule(8), new Jehlan(6, 10) };
            
            foreach (GrObject.IFACE item in gr)
            {
                item.Kresli();
            }
        }
    }
}
