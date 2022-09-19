using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer1 = new Customer
            {
                Id = 2, FirstName = "Derin", LastName = "Demiroğ", City = "İstanbul"
            };
            Console.WriteLine(customer1.FirstName);

            Console.ReadLine();
        }
        
        class ProductManager
        {
            public void Add()
            {
                Console.WriteLine("Product Added!");
            }
            public void Update()
            {
                Console.WriteLine("Product Updated!");
            }
        }
    }
}
