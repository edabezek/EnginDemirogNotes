using System;

namespace ReferanceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;//number1 in değerini number2 ye attık
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };//101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Mersin" };//102
            cities2 = cities1;//cities2'nin referansı eşittir cities1'in referansı
            //102=101 oluyor , 102'yi kullanılmaz oldu onu da çöp toplayıcı silecek

            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]); //istanbul yazar 


            //Performans ile ilgili datatable örneği var buna bak


            Console.ReadLine();
        }
    }
}
