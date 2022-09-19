using System;

namespace Constructors//new lendiğinde çalışacak kod bloğudur
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);//burada boş parantez açıp kapatmak o sınıfın(constructorunun) parametresiz bir şekilde çalıştırılması anlamına gelir.
            customerManager.List();

            
            Console.ReadLine();
        }
    }
    class CustomerManager//constructor u bu sınıfın ihtiyaç  duyduğu farklı parmetreler varsa ve kullanıma göre parametreler değişkenlik gösteriyorsa o zaman yararlanırız.
        //10 parametresini constructor ile set ettik
        
    {
        private int _count = 15;//private bir field _ ile başlatılır.
        public CustomerManager(int count)//bize int bir sayı ver
        {
            _count = count;    
        }
        public CustomerManager()//Constructorlar overload da edilebilir.Hiç bişey verilmezse default 15, verilirse de verilen değer çalışır.
        {

        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
}
