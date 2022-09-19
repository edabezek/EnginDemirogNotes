using System;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();//logger ın kim olduğu
            customerManager.Add();//ne yapacağı

            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger logger { get; set; }//property injection 

        //normalde constructor  ile yaparız.
        public void Add()
        {

            Console.WriteLine("Customer Added!!");
        }
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
