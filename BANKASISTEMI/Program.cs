using System;

namespace BANKASISTEMI
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriBilgileri musteri1 = new MusteriBilgileri();
            musteri1.AdSoyad = "KADİR AZTEKİN";
            musteri1.AnneAdı = "Senay Aztekini";
            musteri1.BabaAdu = "Yaşar Aztekin";
            musteri1.ID = 10000;

            MusteriBilgileri musteri2 = new MusteriBilgileri();
            musteri2.AdSoyad = "Nısa Berfin Tosun";
            musteri2.AnneAdı = "Gulsen Tosun";
            musteri2.BabaAdu = "Reha Tosun";
            musteri2.ID = 2000;

            MusteriBilgileri musteri3 = new MusteriBilgileri();
            musteri3.AdSoyad = "Bunyamın Keles";
            musteri3.AnneAdı = "TANIMLANAMADI";
            musteri3.BabaAdu = "Yasin Keles";
            musteri3.ID = 3000;

            MusteriBilgileri[] x = new MusteriBilgileri[] { musteri1, musteri2 };
            foreach (MusteriBilgileri musteri in x)
            {
                Console.WriteLine(musteri.AdSoyad);
                Console.WriteLine(musteri.AnneAdı);
                Console.WriteLine(musteri.BabaAdu);
                Console.WriteLine(musteri.ID);
                Console.WriteLine("-----------------------------");

            }
            Musteriİslemlerı Z = new Musteriİslemlerı();
            Z.MusteriEkle(musteri1);
            Z.MusteriEkle(musteri2);
            Z.MusteriEkle(musteri3);

            Console.WriteLine("QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ");


            Z.MusteriListeleme(musteri1);
            Z.MusteriListeleme(musteri2);
            Z.MusteriListeleme(musteri3);

            Z.MusteriSilme(musteri1);

        }
    }
}
