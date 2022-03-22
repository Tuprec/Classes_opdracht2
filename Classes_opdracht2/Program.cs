using System;

namespace Classes_opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Breuk SBreuk = new Breuk();
            string strAnswer;
            double dblQuotiënt;
            Console.Write("Wilt u zelf een breuk ingeven of de standaar 4/2? (Z/S) ");
            strAnswer = Console.ReadLine().ToUpper();

            if (strAnswer == "Z")
            {
                Breuk NBreuk = new Breuk();
                NBreuk.Aanpassen(NBreuk);
                SBreuk = NBreuk;
            }
            Console.Clear();
            SBreuk.Get(SBreuk);
            Console.Write("Wilt u iets aanpassen? (Y/N) ");
            strAnswer = Console.ReadLine().ToUpper();

            if (strAnswer == "Y")
            {
                SBreuk.Aanpassen(SBreuk);
            }
            Console.Clear();
            dblQuotiënt = SBreuk.quotiënt(SBreuk);
            Console.WriteLine($"Het quotiënt van {SBreuk.INTTELLER}/{SBreuk.INTNOEMER} is {dblQuotiënt}");
            Console.ReadLine();
        }
    }
}
