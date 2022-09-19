using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Console.WriteLine(Add2(10,20));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Adedd!");
        }

        static  int Add2(int number1,int number2)
        {
            var result= number1 + number2;
            return result;
        }
    }
}
