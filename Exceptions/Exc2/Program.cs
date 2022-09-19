using System;
using System.Collections.Generic;

namespace Exceptions1//kendi hata sınıfımızı yazacağız
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
               
            }
            
            

            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Egin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))//students içinde ahmet yoksa
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}
