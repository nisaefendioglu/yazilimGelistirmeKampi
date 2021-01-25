using System;
using System.Collections.Generic;
using System.Text;

namespace gameProject
{
    class kullaniciManager : IManager
    {
        private string kullaniciAdi;
        public kullaniciManager(Kullanici kullanici)
        {
            kullaniciAdi = kullanici.KullaniciAdi;
        }

        public void Add()
        {
            Console.WriteLine("Kullanıcı eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
