using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Aslı";
            //array'e sonradan eleman eklemesi yaparsak out of range hatası alırız, referans 
            string[] students2 = { "Egin","Aslı","Osman"};

            //iki boyutlu array
            string[,] cities = new string[7,3];//değer eklenecek

            for (int i = 0; i <= cities.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cities.GetLowerBound(1); j++)
                {
                    Console.WriteLine(cities[i, j]);
                }
            }
            //GetUpperBound(0) metodu ise size üst sınırı verir. Mesela 4 elemanlı bir diziniz var diyelim. Size 3 değerini verir.



            foreach (var student in students)
            {
                Console.WriteLine(student);

            }

            //Derleme zamanı hatası : kodun derlenemediğini verir
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
