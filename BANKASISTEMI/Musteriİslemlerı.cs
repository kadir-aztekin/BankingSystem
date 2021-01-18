using System;
using System.Collections.Generic;
using System.Text;

namespace BANKASISTEMI
{
    class Musteriİslemlerı
    {
        public void MusteriEkle(MusteriBilgileri yenımusteri )
        {
            Console.WriteLine("Musteri Eklendi:" + yenımusteri.AdSoyad);
        }
        public void MusteriSilme(MusteriBilgileri sılınenmusteri)
        {
            Console.WriteLine("Musteri Bilgileri Silindi" + sılınenmusteri.AdSoyad);
        }
        public void MusteriListeleme(MusteriBilgileri musteriBilgileri)
        {
            Console.WriteLine("Musteri Bilgileri:" + musteriBilgileri.AdSoyad + musteriBilgileri.AnneAdı + musteriBilgileri.BabaAdu + musteriBilgileri.ID);
        }
    }
}
