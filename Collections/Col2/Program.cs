using System;
using System.Collections;

namespace Collections//her seferinde new leyip eleman eklemektense koleksiyon ile işimizi görüyoruz.
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();//array list ile çalıştığımız veride özellikle bir tip yoksa(type safe-tip güvenli) tercih edilebilir.
            //Ama genelde type safe olan koleksiyonları kullanırız 
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("İstanbul");
            Console.WriteLine(cities[2]);

            cities.Add(1);//arraylist object value istiyor, object value bütün tiplerin base i dir.Her veri tipini ekleyebiliriz.

            Console.ReadLine();
        }
    }
}
