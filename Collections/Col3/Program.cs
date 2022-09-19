using System;
using System.Collections.Generic;

namespace Collections4//dictionary: listeyi tutup ona anahtar ile ulaşmaya yarar.
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();  //anahtar hangi türde,değeri hangi türde
            //id,customer olabilir.
            dictionary.Add("book", "kitap");//anahtar,değer
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);//kitabı arayamayız hata verir.ilk yer değeri verir

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            dictionary.ContainsKey("glass");//false 

            Console.ReadLine();

        }
    }
}
