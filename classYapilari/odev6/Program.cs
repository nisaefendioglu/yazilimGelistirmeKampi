using System;

namespace classYapilari
{
    class Program
    {
        //13 Ocak Dersi
        static void Main(string[] args)
        {
                Console.WriteLine("Class Yapısı");

                Product product1 = new Product();
                product1.Name = "Ev";
                product1.Fiyat = 30000;

                Product product2 = new Product
                {
                    Name = "Telefon",
                    Fiyat = 1289

                };
                Product product3 = new Product();
                product3.Name = "Araba";
                product3.Fiyat = 28000;

                Product[] products = new Product[] { product1, product2, product3 };

                Console.WriteLine("FOR DÖNGÜ ÇIKTISI");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine(products[i].Name + " " + "Fiyatı:" + products[i].Fiyat);
                }

                Console.WriteLine("FOREACH DÖNGÜ ÇIKTISI");
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name + " " + "Fiyatı: " + product.Fiyat);
                }

                Console.WriteLine("WHİLE DÖNGÜSÜ ÇIKTISI");

                int a = 0;
                while (a < products.Length)
                {
                    Console.WriteLine(products[a].Name + " " + "Fiyatı:" + products[a].Fiyat);
                    a++;
                }




            }
        }
        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Fiyat { get; set; }

        }
    }
    