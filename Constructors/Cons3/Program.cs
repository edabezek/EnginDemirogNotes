using System;

namespace Constructor3//Base sınıfa parametre göndermek
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager("product");
            personManager.Add();

            Console.ReadLine();
        }
    }
    class Base
    {
        private string _entity;
        public Base(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }
    class PersonManager : Base//person manager , message ı new leyip  çağıracak ama bişey göndermemizi isteyecek
    {
        public PersonManager(string entity):base(entity)//
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");

            Message();
        }
    }
}
