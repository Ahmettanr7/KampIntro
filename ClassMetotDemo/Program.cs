using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "Ahmet Tanrıkulu";
            customer1.CustomerPhone = "(+90)(555)(5555555)";
            customer1.CustomerAdress = "Selçuklu/KONYA";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "XYZ FİRMASI";
            customer2.CustomerPhone = "(+90)(555)(5555556)";
            customer2.CustomerAdress = "MERAM/KONYA";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerName = "ABC FİRMASI";
            customer3.CustomerPhone = "(+90)(555)(5555556)";
            customer3.CustomerAdress = "Beyşehir/KONYA";

            Customer[] customers = new Customer[]
            {customer1, customer2, customer3};

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerPhone);
                Console.WriteLine(customer.CustomerAdress);
                Console.WriteLine("---------------------");
            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer3);
            customerManager.Update(customer2);
            customerManager.Delete(customer1);
        }
    }
}
