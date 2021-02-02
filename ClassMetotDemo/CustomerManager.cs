using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {


        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " aramıza hoşgeldiniz :))");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " adlı müşteri silindi.");
        }
        public void List(Customer[] customers)
        {

            foreach (Customer customer in customers)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine("***********************************");


            }

        }
    }
}
