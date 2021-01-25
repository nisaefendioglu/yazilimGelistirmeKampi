using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace musteriTakip
{
    class MusteriManager
    {
        public static List<Musteri> musteriList = new List<Musteri>();
        public void AddCustomer(Musteri musteri)
        {
            musteriList.Add(musteri);
            bool AddCheck = musteriList.Contains(musteri);
            if (AddCheck)
            {
                Console.WriteLine(musteri.Id + " no'lu" + musteri.ad + " " + musteri.soyad + " müşteri eklendi!");
            }
            else
            {
                Console.WriteLine("Hay aksi bir hata oluştu! Müşteri eklenemedi.");
            }
        }
        public static void musteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.ad + " " + musteri.soyad + " " + "sisteme eklendi.");
        }

        public static void musteriSil (string musteriAd)
        {
            Musteri musteri = new Musteri();
            musteri.ad = musteriAd;
            musteri = musteriList.Find(x => x.ad.Contains(musteri.ad));
            if (musteriList.RemoveAll(x => x.ad.Contains(musteri.ad)) > 0)
            {
                Console.WriteLine(musteri.Id + " no'lu  " + musteri.ad + " " + musteri.soyad + " müşteri silindi.");
            }
            else
            {
                Console.WriteLine("Hay aksi bir hata oluştu! Lütfen daha sonra tekrar deneyiniz.");
            }
        
    }

        public static void musteriListe()
        {

            if (!musteriList.Any())
            {
                Console.WriteLine("Sisteme kayıtlı müşteri bulunamadı. \n");
            }
            else
            {
                foreach (var musteri in musteriList)
                {
                    Console.WriteLine("Müşteri ID No : " + musteri.Id);
                    Console.WriteLine("Müşteri Adı : " + musteri.ad);
                    Console.WriteLine("Müşteri Soyadı : " + musteri.soyad);
                    Console.WriteLine("Müşteri Doğum Yeri : " + musteri.dogumYeri);
                    Console.WriteLine("Müşteri İletişim Bilgisi : " + musteri.telNo);
                }
            }
        }
    }
    }

