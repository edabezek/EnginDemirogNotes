using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            //bana string bir liste oluştur diyoruz
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");//burada hangi tipte data verirsem methodun içindeki değerleri alıp onun listesi haline getirecek

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //müşteri listesi oluşturursak
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer {FirstName="Engin" }, new Customer { FirstName = "Derin" });

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)//params ne kadar gelirse o kadar girecek
        {
            return new List<T>(items);
        }
    }
    class Customer
    {
        public string FirstName { get; set; }
    }
}
