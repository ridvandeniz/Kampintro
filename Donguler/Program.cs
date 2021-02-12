using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C";
            string kurs2 = "Java";
            string kurs3 = "C#";

            //arrays-diziler
            string[] kurslar = new string[] { "C", "Java", "C#" ,"C++"};
            


            for (int i = 0; i < kurslar.Length ; i=i+1)
            {
                Console.WriteLine(kurslar[i]) ;

            }
            Console.WriteLine("SON");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }


}
