using System;

namespace Methods
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

            Product product6 = new Product();
            product6.Categorry = "Ev Aletleri";
            product6.ProductName = "Arzum Tost Makinesi";
            product6.Price = 249;
            product6.Stock = 100;

            Product product7 = new Product();
            product7.Categorry = "Spor Giyim";
            product7.ProductName = "Fenerbahçe 2020 Efsane Çubuklu Forma";
            product7.Price = 280;
            product7.Stock = 100;

            Product[] products = new Product[] 
            { product1, product2, product3, product4, product5, product6, product7 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Categorry);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Price);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("-----METHOSTS------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product7);
        }
    }
}
