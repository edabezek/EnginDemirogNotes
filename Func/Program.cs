using System;
using System.Threading;

namespace Func //Action ve Func build in delegete dir.
    //Action'da void olan-özel bir tip döndürmeyen kod blogları için kullanılır. -sadece çalıştır
    //Func ise actiona ek olarak , dönüş tipi olan kodlar için kullanılır.-değer de döndür
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(2,3));
            //func
            Func<int, int, int> add = Topla;

            Console.WriteLine(add(2,5));


            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);   
            };
            Console.WriteLine(getRandomNumber());
            //thread ile randomu bekletebiliriz 
            Thread.Sleep(1000);
            //farklı yazım -parametresiz metoda delegasyon yapacak -bu da lambda
            Func<int> getRandomNumber2=()=>new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber2);

        }
        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
