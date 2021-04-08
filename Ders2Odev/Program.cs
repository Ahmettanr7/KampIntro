using System;

namespace Ders2Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Categorry = "Elektronik";
            product1.ProductName = "Monster Notebook";
            product1.Price = 8350;
            product1.Stock = 100;

            Product product2 = new Product();
            product2.Categorry = "Elektronik";
            product2.ProductName = "Samsung M51";
            product2.Price = 3650;
            product2.Stock = 200;

            Product product3 = new Product();
            product3.Categorry = "Spor Giyim";
            product3.ProductName = "Fenerbahçe 2021 Çubuklu Forma";
            product3.Price = 280;
            product3.Stock = 0;

            Product product4 = new Product();
            product4.Categorry = "Ayakkabı & Çanta";
            product4.ProductName = "Adidas Super B";
            product4.Price = 312;
            product4.Stock = 2;

            Product product5 = new Product();
            product5.Categorry = "Kırtasiye & Ofis";
            product5.ProductName = "Not Defteri";
            product5.Price = 20;
            product5.Stock = 0;

            Product[] products = new Product[] {product1, product2, product3, product4, product5};
            // for döngüsü ile ürünleri listeleme başlangıç
            Console.WriteLine("For Döngüsüyle Ürün Listesi");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Categorry + " -- " + products[i].ProductName + " -- " + products[i].Price);
            }

            Console.WriteLine(" ");
            // for dögüsü ile listeleme sonu

            //forech döngüsü ile ürünleri listeleme başlangıç
            Console.WriteLine("Forech Döngüsüyle Ürün Listesi");
            foreach (var product in products)
            {
                Console.WriteLine(product.Categorry + " -- " + product.ProductName + " -- " + product.Price);
            }

            Console.WriteLine(" ");
            //Forech Dögü sonu

            //Forech While Döngüsü ile Sadece Stokta olan Ürünleri Listeleme
            Console.WriteLine("While Döngüsü ile Ürün Listeleme");
              foreach (var product in products)
                {
                while (product.Stock > 0)
                {
                 Console.WriteLine(product.Categorry + " -- " + 
                                   product.ProductName + " -- " + 
                                   product.Price);  
                 break;
                }
                }

            //Forech While Döngüsü ile Stokta olmayan Ürünleri Listeleme
            Console.WriteLine(" ");
            Console.WriteLine("Stokta Biten Ürünler");
            foreach (var product in products)
            {
                while (product.Stock <= 0)
                {
                    Console.WriteLine(product.Categorry + " -- " + 
                                      product.ProductName + " -- " + 
                                      product.Price);
                    break;
                }
            }

        }


        }
    }

    class Product
    {
        public string Categorry { get; set; }

        public string ProductName { get; set; }

        public float Price { get; set; }
        public int Stock { get; set; }
    }

