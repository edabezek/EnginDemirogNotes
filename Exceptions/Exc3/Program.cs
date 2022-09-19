using System;
using System.Collections.Generic;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Find();
            }
            catch (RecordNotFoundException1 exception)
            {
                Console.WriteLine(exception.Message);

            }


            //method a method göndermek işini delege dediğimiz yapılarla gönderiyoruz.
            HandleException(() => { Find(); });//burda parantez içinde metot göndericez ve metotun karşılığı(lamda => ) küme parantezindeki kod olacak(metot yerine kod da yazabiliriz)  

            Console.ReadLine();
        }

        private static void HandleException(Action action)//generated method
        {//buradaki aksiyon küme parantezinin içi demek oluyor.
            try
            {
                action.Invoke();//try in içinde find ı çalıştır invoke=çağırmak
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Egin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))//students içinde ahmet yoksa
            {
                throw new RecordNotFoundException1("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}
