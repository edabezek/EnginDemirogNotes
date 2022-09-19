using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add3(ref number1, number2);

            Console.WriteLine(result);
            Console.WriteLine(number1);

            Console.ReadLine();
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 30;//number 1 metot içinde değişirse o zaman ref keyword ünü kullanıp 
            //yani number1 metot içindeki değeri alsın istersek ref yazarız,yani number1'in referansını kullan demek oluyor.Değer tiplerin referans tip gibi kullanılmasını sağlar,Değişkenin metotta değşeceğini öngörüyorsak kullanılır.
            //tam tersi de out kullanılır.out da değişkene değer atamadan gönderebilirsin.

            return number1 + number2;
        }
    }
}
