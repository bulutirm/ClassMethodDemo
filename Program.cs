using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();

            customer1.Name = "Irem";
            customer1.Surname = "Bulut";
            customer1.Id = "11111111111";

            Customer customer2 = new Customer();
            customer2.Name = "Naşide";
            customer2.Surname = "Bulut";
            customer2.Id = "12222234234";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.List(customers);

            Console.WriteLine("\n");

            customerManager.Add(customer1);
            customerManager.Delete(customer1);



        }
    }
}
