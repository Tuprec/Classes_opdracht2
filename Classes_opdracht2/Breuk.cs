using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_opdracht2
{
    class Breuk
    {
        public int intTeler;
        public int intNoemer;
        
        public Breuk()
        {
            intTeler = 4;
            intNoemer = 2;            
        }

        public Breuk(Breuk NBreuk)
        {
            Console.Write("Geef de Teller: ");
            intTeler = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de Noemer: ");
            intNoemer = Convert.ToInt32(Console.ReadLine());
        }
        public void Get(Breuk NBreuk)
        {
            Console.WriteLine($"De Teller is: {intTeler}");
            Console.WriteLine($"De Noemer is: {intNoemer}");
        }
        public void Aanpassen(Breuk NBreuk)
        {
            Console.WriteLine("Geef de Teller: ");
            NBreuk.intTeler = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geef de Noemer: ");
            NBreuk.intNoemer = Convert.ToInt32(Console.ReadLine());
        }
        public double quotiënt(Breuk NBreuk)
        {
            double dblQuotiënt;
            dblQuotiënt = Convert.ToDouble(NBreuk.intTeler / NBreuk.intNoemer);
            return dblQuotiënt;
        }
    }
}
