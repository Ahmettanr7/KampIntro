using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.CustomerNo + " Numaralı Müşteri Eklendi..");
        }
    }
}
