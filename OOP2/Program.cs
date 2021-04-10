using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "00001";
            customer1.TcNo = "444444444444";
            customer1.CustomerName = "Ahmet";
            customer1.CustomerSurname = "Tanrıkulu";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "00002";
            customer2.TaxNo = "1234567890";
            customer2.CompanyName = "Tannet";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            
        }
    }
}
