using System;
using System.Collections.Generic;

namespace CollectionsTypeSafety//yani generic collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //neden nesnelerle çalışıyoruz? çünkü veritabanındaki tabloların karşılığını nesne halinde tutarız. Burada veeri tabanından veriyi çektiğimiz zaman onu bir listeye attık
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Eda" });
            customers.Add(new Customer { Id = 2, FirstName = "Derin" });

            //başka bir yazma şekli:
            List<Customer> customers2 = new List<Customer> 
            {
                new Customer { Id = 1, FirstName = "XX" },
                new Customer { Id = 2, FirstName = "YY" }
            };



            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);//sadece customer da CollectionsTypeSafety.Customer yazacak
            }

            Console.ReadLine();

        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
