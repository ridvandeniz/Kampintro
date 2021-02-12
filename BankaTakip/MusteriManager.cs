using System;
using System.Collections.Generic;
using System.Text;

namespace BankaTakip
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "İsimli" + " " + musteri.MusteriId + " " + " Numaralı müşteri Eklendi");
        }
        public void Sil(Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi + " " + "İsimli" + " " + musteri.MusteriId + " " + " Numaralı müşteri Silindi");
        }
        public void Guncelle(Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi + "   " + musteri.MusteriSoyadi + " " + "İsimli" + " " + musteri.MusteriId + " " + " Numaralı müşteri Silindi");
        }

        public void Listele(Musteri[] musteriler) 
        {
            

            Console.WriteLine("---------------Musteri Listesi------------");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Ad : " + musteri.MusteriAdi);
                Console.WriteLine("Müşteri No : " + musteri.MusteriId);
                Console.WriteLine("SoyAd : " + musteri.MusteriSoyadi);
                Console.WriteLine("------------------------------------------");

            }
        }
    }
}
