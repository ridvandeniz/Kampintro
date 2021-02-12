using System;

namespace BankaTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriId = 23;
            musteri1.MusteriSoyadi = "Yılmaz";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Mehmet";
            musteri2.MusteriId = 25;
            musteri2.MusteriSoyadi = "Uysal";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Kamil";
            musteri3.MusteriId = 28;
            musteri3.MusteriSoyadi = "Özer";

           
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Guncelle(musteri3);

            Musteri[] musteriler = new Musteri[] {musteri1 , musteri2 ,musteri3 };

            musteriManager.Listele(musteriler);

        }
    }
}
