using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Samsung M51 Cep Telefonu";
            product1.UnitPrice = 3600;
            product1.UnitsInStock = 150000;

            Product product2 = new Product();
            product1.Id = 2;
            product1.CategoryId = 32;
            product1.ProductName = "Koton Jean Kot Pantolon";
            product1.UnitPrice = 160;
            product1.UnitsInStock = 500;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
