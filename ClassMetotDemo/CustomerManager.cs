using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            //sql Insert into kodları vs vs..
            Console.WriteLine(customer.CustomerName + " Eklendi");
            Console.WriteLine("---------------------");
        }

        public void Update(Customer customer)
        {
            //sql update kodları vs vs..
            Console.WriteLine(customer.CustomerName + " Güncellendi");
            Console.WriteLine("---------------------");
        }

        public void Delete(Customer customer)
        {
            //sql Delete kodları vs vs..
            Console.WriteLine(customer.CustomerName + " Silindi");
            Console.WriteLine("---------------------");
        }
    }
}
