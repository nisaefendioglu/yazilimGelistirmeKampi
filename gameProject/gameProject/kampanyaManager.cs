using System;
using System.Collections.Generic;
using System.Text;

namespace gameProject
{
    class kampanyaManager : IManager
    {
        private string kampanyalar1;

        public kampanyaManager(Kampanyalar kampanya)
        {
            kampanyalar1 = kampanya.Kampanya;
        }
        public void Add()
        {
            Console.WriteLine("Kampanya Uygulandı.");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
