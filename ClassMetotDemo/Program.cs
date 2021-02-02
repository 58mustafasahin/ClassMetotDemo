using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Mustafa";
            customer1.Surname = "ŞAHİN";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ali";
            customer2.Surname = "YILMAZ";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.List(customers);
            customerManager.Delete(customer2);
        }
    }
}
