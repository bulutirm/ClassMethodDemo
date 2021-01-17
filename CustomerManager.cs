using System;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        

        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi:" + customer.Name +customer.Surname);
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name, "\n");
            }
            

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi." + customer.Name + customer.Surname);
        }




    }
}
