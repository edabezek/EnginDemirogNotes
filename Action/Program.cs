using Exceptions2;
using System;
using System.Collections.Generic;

namespace Action1//Exception, Transaction vs  yönetimi için kullanılıyor.
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


            
            HandleException(() => { Find(); }); 

            Console.ReadLine();
        }

        private static void HandleException(Action action)//Burada action bir methoda karşılık gelir --Find methodunu HandleExceptiona gönderelim ve invoke ile çalıştıralım-yani her seferinde yazmamak için 
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Egin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
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
