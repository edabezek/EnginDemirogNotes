using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //çalışan array i oluşturmak istediğimizde
            IWorker[] workers = new IWorker[2]
            { 
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[1] 
            {
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }
    interface IWorker
    {
        void Work();
        
        
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void GetSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            
        }
    }
}
