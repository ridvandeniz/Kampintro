using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            Console.WriteLine(kategoriEtiketi);
            double FaizOranı = 1.45;
            long ogrenciSayısı = 320000000000000;
            bool KayıtlıMı = true;
            double dolarDun = 7.40;
            double dolarBugun = 7.43;

           
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else
            {
                Console.WriteLine("Değişmedi");              
            }



            if (KayıtlıMı == true)
            {
                Console.WriteLine("KullanıcıAdı");
            }
            else
            {
                Console.WriteLine("Kayıt Ol!");
            }
        }
    }
}
