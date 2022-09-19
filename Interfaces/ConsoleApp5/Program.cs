using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, FirstName = "Eda", LastName = "Bez", Adress = "Ataşhir" });//yada 
            //Customer customer  = new Customer {
            //Id = 1, FirstName = "Eda", LastName = "Bez", Adress = "Ataşhir"
            //}
            //personManager.Add(customer);

            personManager.Add(new Student { Id = 1, FirstName = "Eda", LastName = "Bez", Departmant = "Ataşhir" });
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)//parametre olarak bize nesne ver 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
