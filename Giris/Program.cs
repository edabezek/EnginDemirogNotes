using System;

namespace Giris//delege-elçi
{
    internal class Program
    {
        public delegate void MyDelegate();//void olan ve parametre almayan metotlara-operasyonlara elçilik yapacak,customerManager'a yapabilir.

        public delegate void MyDelegate2(string text);

        public delegate int MyDelegate3(int number1,int number2);  


        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            //MyDelegate
            MyDelegate myDelegate = customerManager.SendMessage;//myDelegate customerManager'a delege edilmiş durumda-mesajı verdik diyelim
            myDelegate+=customerManager.ShowAlert;//arka arkaya toplamadaki amaç sırayla işi yaptırmak

            //myDelegate -= customerManager.SendMessage;//silede biliriz 
            myDelegate();//delegeyi çağırdık

            //MyDelegate2
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello");

            //MyDelegate3
            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 =matematik.Topla;
            myDelegate3 += matematik.Carp;//void dışı return type da en son geleni çalıştırır.

            var sonuc = myDelegate3(2,3);
            Console.WriteLine(sonuc);


            Console.ReadLine();
        }
        
    }
    public class CustomerManager
    {
        //MyDelegate
        public void SendMessage()
        {
            Console.WriteLine("hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("be careful");
        }

        //MyDelegate2
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik //MyDelegate3 
    {
        public int Topla(int sayi1,int sayi2) 
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
