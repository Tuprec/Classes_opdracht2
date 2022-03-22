using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_opdracht2
{
    class Breuk
    {
        private int intTeler;
        private int intNoemer;

        public int INTTELLER
        {
            get { return intTeler; }
            set { intTeler = value; }
        }
        public int INTNOEMER
        {
            get { return intNoemer; }
            set { intNoemer = value; }
        }

        public Breuk()
        {
            intTeler = 4;
            intNoemer = 2;            
        }

        /*public Breuk(Breuk NBreuk)
        {
            Console.Write("Geef de Teller: ");
            NBreuk.INTTELLER = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de Noemer: ");
            NBreuk.INTNOEMER = Convert.ToInt32(Console.ReadLine());
        }*/
        public void Get(Breuk NBreuk)
        {
            Console.WriteLine($"De Teller is: {NBreuk.INTTELLER}");
            Console.WriteLine($"De Noemer is: {NBreuk.INTNOEMER}");
        }
        public void Aanpassen(Breuk NBreuk)
        {
            Console.Write("Geef de Teller: ");
            NBreuk.INTTELLER = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef de Noemer: ");
            NBreuk.INTNOEMER = Convert.ToInt32(Console.ReadLine());
        }
        public double quotiënt(Breuk NBreuk)
        {
            double dblQuotiënt;
            dblQuotiënt = Convert.ToDouble(NBreuk.INTTELLER / NBreuk.INTNOEMER);
            return dblQuotiënt;
        }
    }
}
