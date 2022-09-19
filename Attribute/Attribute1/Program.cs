using System;
using System.ComponentModel.DataAnnotations;

namespace _25._1_Attiributes
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

    [ToTable("Customers")]//class a attiribute  eklenebilir
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]//attribute kendimiz oluşturduk
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    class CustomerDal
    {
        [Obsolete("Don't use Add,instead use AddNew Method")]//Bu hazır attrbute ı yazdığımızda, yeni AddNew'i kullan demiş oluyoruz.Obsolote:eski demek
        public void Add(Customer customer)//Sen bana customer gönderdiğinde customer formatını kontrol edeyim.İstedğim formatta değilse , uyarı versin.
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)//yeni yazarsak
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    class RequiredPropertyAttribute : Attribute
    {

    }
    class ToTable : Attribute//to table a parametre yollayabilmemiz için constructor oluşturduk.
    {
        private string _tableName;

        public ToTable(string tableName)
        {
            _tableName = tableName;
        }
    }
    //reflection vs attribute kullanımı araştırabilirsin.

}
