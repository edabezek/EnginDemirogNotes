using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._2_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }

    }

    [ToTable("Customers")]
    //[ToTable("Products")]

    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    class CustomerDal
    {
        [Obsolete("Don't use Add,instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]//all hepsinde kullanılabilir. Class sadece clas üstü kullanılabilir.Property dersek sadece property için kullanılır.
    // [AttributeUsage(AttributeTargets.All | AttributeTargets.Field)] gibi de yazılabilir.
    //AllowMultiple birden fazla yerde  kullanım için,mesela last name e iki defa uygulanabilir.yada to table üstüne yazılan gibi çoğaltmak için [ToTable("Products")] böylece iki tablo için geçerli olur.
    class RequiredPropertyAttribute : Attribute
    {

    }
    class ToTable : Attribute
    {
        private string v;

        public ToTable(string v)
        {
            this.v = v;
        }
    }




}
