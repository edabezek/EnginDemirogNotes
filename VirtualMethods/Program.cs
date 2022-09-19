using System;

namespace VirtualMethods//inheritance yaptığımız ortamda genel komutu değiştirmek-ezmek istersek kullanrız.
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();

            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()//virtual kullanırsak ,diyelim sql de daha farklı ekleme,yapı ile  yapacağız. virtual kullandığımızda bunu override edip sql için değiştirebiliriz
        {
            Console.WriteLine("Added by default");
        }public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlServer : Database
    {
        public override void Add()//kısayol override add
        {
            //base.Add();//database in base ini çalıştır.Hem base hem yeni kod  aynı anda çalıştırılabilir.
            Console.WriteLine("Added by sql code");
        }
    }
    class MySql :Database
    {

    }
}
