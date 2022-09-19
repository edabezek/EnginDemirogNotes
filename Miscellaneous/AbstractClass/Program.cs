using System;

namespace AbstractClass//interface ve virtual metotların birleşimi diyebiliriz.İnheritance için kullanılır.
{//hem tamamlannmış hem tamamlanmamış metotlar yapılabilir.
    //abstract içi dolu olmayan virtual metottur.
    //interfaceler gibi abstract  classlar instance ı oluşturulamaz 
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()//tamamlanmış metotlar
        {
            Console.WriteLine("Added by default");

        }
        public abstract void Delete();//tamamlanmamış metotlar
        //Ekleme işlemi bütün veritabanlarında aynı fakat silme işlemi farklı.
    }
    class SqlServer : Database //iimplement ettiğimizde sadece abstract gelir ve override edilir.
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }
}
