using System;

namespace Exceptions//exceptionları loglarız ki bakıp çözebilelim.
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };

                students[3] = "Ahmet";//out of range hatası verir.
            }
            catch (IndexOutOfRangeException exception)//alınan hatanın türü buysa bunu yap
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)//alınan hata İndex out değilse diğer bütün hatalar için burası çalışacak  f12 ile içine girebilirsin.
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("   ");
                Console.WriteLine(exception.InnerException);//detay bilgi verir
            }


            Console.ReadLine();
        }
    }
}
