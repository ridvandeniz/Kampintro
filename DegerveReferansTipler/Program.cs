using System;

namespace DegerveReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;

            Console.WriteLine(sayi1);
            //sayi1 Kaçtır?
            //Cevap: say1=sayi2 dediğimiz andan itibaren sayi1 sayı2'nin değerini alır.Artık onun değeri 30'dur

            int[] sayilar1 = new int[] {1,2,3 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;

          //sayilar1[0]= kaçtır?
          //Cevap: sayilar1= sayilar2 dediğimiz andan itibaren sayilar1 in ev adresi artık sayilar2 nin ev adresi olmuştur.sayilar1[0]= 100 olacağı gibi
          // sayilar1[1]=200'dür.




        
        }
    }
}
