using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Engin" },
                new Customer { Id = 2, FirstName = "Derin" }
            };

            var count = customers.Count;

            //yeni ekleme yöntemleri
            var customer = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer);
            //
            customers.AddRange(new Customer[2]
            {
                new Customer{Id=4,FirstName="Ali"},
                new Customer{Id=5,FirstName="Ceyda"}
            });

            
            // içinde customer varsa true dönecek
            Console.WriteLine(customers.Contains(customer));
            //customer ın kaçıncı sırada olduğunu bilmek istiyorsak
            var index = customers.IndexOf(customer);
            Console.WriteLine("Index {0}", index);



            Console.ReadLine();
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
