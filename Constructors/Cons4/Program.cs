using System;

namespace Constructor4//static nesneler : instance ı oluşturulamaz . Arkaplanda tek bir nesne oluşturuluyor sistem tarafından ve kullanıcılar tarafından tüketiliyor.
    //static nesneler ortak nesnelerdir ve herkes kullanabilir
    //Not:singleton design pattern incele  
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher.Number = 10;

            Utilities.Validate();

            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }
    static class Teacher//static nesnelerin bütün özelliklerinin de static bildirgesine sahip olması gerekiyor.
    {
        public static int Number { get; set; }

    }
    static class Utilities
    {
        static Utilities()//static constructor da kullanılır,burada çalışmasnı istediğimi kod blogu varsa koyabiliriz.
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }
    class Manager//bu şekilde de kullanılır
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done!");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done2!");
        }

    }
}
