using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            kurs kurs1 = new kurs();
            kurs1.Egitmen = "Rıdvan";
            kurs1.KursAdi = "C#";
            kurs1.izlenmeOranı = 80 ;

            kurs kurs2 = new kurs();
            kurs2.Egitmen = "Ahmet";
            kurs2.KursAdi = "Java";
            kurs2.izlenmeOranı = 58 ;

            kurs kurs3 = new kurs();
            kurs3.Egitmen = "Mehmet";
            kurs3.KursAdi = "C++";
            kurs3.izlenmeOranı = 65 ;

            Console.WriteLine( " % " + kurs1.izlenmeOranı );
        }
    }

    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }
    }
}
