using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConstraits//generic kısıtlar , generic olarak verilen T'yi kısıtlayabiliyoruz.Yani T yerine belirli sınıfı yazabilsin
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Product : IEntity//prdocut da veritabanı nesnesi diyoruz.
    {

    }
    class Customer : IEntity
    {

    }
    
    interface IProductDal : IRepository<Product>
    {

    }
    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
    }
    //interface IstudentDal : IRepository<string>//bu şekilde anlış yazabiliyoruz 
    //{

    //}
    class Student : IEntity
    {

    }
    interface IEntity //veritabanı nesnesi olduğunu belitmek için yaptık ,diğer sınıflara da ekliyoruz.
    {

    }
    interface IstudentDal : IRepository<Student>//bu şekilde class olduğu için kızmaz newlenebilir.
    {

    }
    //interface IstudentDal : IRepository<ICustomerDal>//bu şekilde olursa kızacak IEntity isteyecek,çünkü veritabanı nesnesi değil.
    //{

    //}


    //kısıtlama where ile olur.
    //where T : class  T bir class'tır diyoruz.Aslında referans tip olmalı diyoruz.string'e kızmaz ama string değil sınıf istiyoruz.Bu yüzden new ekleyeceğiz newlenebilir olsun diye.
    //sadece veritabanı nesneleri yazılabilsin dersek ,yani tablo olarak gelsin o zaman IEntity ekliyoruz,yani IEntity den implemenete ediliyor olmalı anlamına gelecek
    interface IRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    //eğer sadece değer tipiyle kısıtlamak istersek struct yazmamız yeterli
    //interface IRepository<T> where T : struct
    //{
    //    List<T> GetAll();
    //    T Get(int id);
    //    void Add(T entity);//bana bir T nesnesi ver onu ekleyeyim.
    //    void Delete(T entity);//bana bir T nesnesi ver onu sileyim.
    //    void Update(T entity);
    //}
}
