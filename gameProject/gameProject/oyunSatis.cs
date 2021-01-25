using System;
using System.Collections.Generic;
using System.Text;

namespace gameProject
{
    class oyunSatis
    {
        private string kullaniciAdi;
        private float kullaniciOdeme;

        private string oyunAdi; 
        private float oyunUcreti;

        private string kampanyalar;
        private float kampanyaOrani;

        public oyunSatis(Kullanici kullanici, Oyunlar oyun, Kampanyalar kampanya)
        {
            kullaniciAdi = kullanici.KullaniciAdi;
            kullaniciOdeme = kullanici.Odeme;
            oyunAdi = oyun.oyunAdi;
            oyunUcreti = oyun.oyunUcreti;
            kampanyalar = kampanya.Kampanya;
            kampanyaOrani = kampanya.KampanyaOrani;

        }
        public void satis()
        {
            float fiyat = oyunUcreti - 100;
            if (kullaniciOdeme >= fiyat)
            {
                Console.WriteLine($"Sevgili oyunsever {kullaniciAdi}; {oyunAdi} oyununu {oyunUcreti} TL yerine {fiyat} TL karşılığında satın aldınız. İyi eğlenceler dileriz.");
            }
            else
            {
                Console.WriteLine("Yeterli Bakiyeniz Bulunmamaktadır.");
            }
        }
    }
}
