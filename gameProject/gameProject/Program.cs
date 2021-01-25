using System;

namespace gameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici1 = new Kullanici();
            kullanici1.Id = 1;
            kullanici1.KullaniciAdi = "Nisa";
            kullanici1.Sifre = "10212";
            kullanici1.Odeme = 1010;

            Kullanici kullanici2 = new Kullanici();
            kullanici2.Id = 2;
            kullanici2.KullaniciAdi = "Ali";
            kullanici2.Sifre = "1235";
            kullanici2.Odeme = 7777;

            Oyunlar oyun1 = new Oyunlar();
            oyun1.oyunId = 1;
            oyun1.oyunAdi = "COD 5";
            oyun1.oyunUcreti = 189;

            Kampanyalar kampanya = new Kampanyalar();
            kampanya.Kampanya = "Tüm Oyunlar İndirime Girdi!";
            kampanya.KampanyaOrani = 100;

            oyunSatis oyunsatis = new oyunSatis(kullanici2, oyun1, kampanya);
            oyunsatis.satis();
        }
    }
}
