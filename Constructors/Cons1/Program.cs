using System;

namespace Constructors1
{
    class Program
    {
        static void Main(string[] args)
        {

            //üçü de aynı
            Product product = new Product { Id = 1, Name = "Laptop" }; 
            Product product1 = new Product(1, "Laptop");
            Product product2 = new Product();
        }
    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;//kullanıcının gönderdiği id yi , yukarıdaki _id ye eşitliyoruz.
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
