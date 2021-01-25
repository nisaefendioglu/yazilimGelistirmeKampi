using System;

namespace musteriTakip
{
    //16 ocak dersi
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz! Yapmak İstediğin İşlem Nedir?");
            Console.WriteLine("1- Müşteri Ekle");
            Console.WriteLine("2- Müşteri Sil");
            Console.WriteLine("3- Müşterileri Listele");
            string secim = Console.ReadLine();
            MusteriManager add = new MusteriManager();
            switch (secim)
            {
                case "1":
                    Musteri musteri = new Musteri();
                    Console.Write(" Müşteri numarasını giriniz:");
                    musteri.Id = Console.ReadLine();
                    Console.Write(" \nLütfen müşteri adını giriniz:");
                    musteri.ad = Console.ReadLine();
                    Console.Write("\nLütfen müşteri soyadını giriniz:");
                    musteri.soyad = Console.ReadLine();
                    Console.Write("\nLütfen müşteri doğum yerini giriniz:");
                    musteri.dogumYeri = Console.ReadLine();
                    Console.Write("\nLütfen müşteri iletişim bilgisini giriniz:");
                    musteri.telNo = Console.ReadLine();
                    MusteriManager.musteriEkle(musteri);
                    break;
                case "2":
                    Console.WriteLine(" \n Lütfen müşteri adını giriniz..");
                    string musteriDelete = Console.ReadLine();
                    MusteriManager.musteriSil(musteriDelete);
                    break;
                case "3":
                    MusteriManager.musteriListe();
                    break;
                default:
                    break;
            }


        }
    }
}