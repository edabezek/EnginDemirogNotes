using System;

namespace Constructor2 //Constructor Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            Console.ReadLine();
        }
    }
    interface ILogger
    {
        void Log();   
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;     
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
}
