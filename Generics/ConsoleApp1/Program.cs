using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics//bütün interfacelerime aynı yapıyı yazmak yeriine genelleştirme yapıp yazarız.Yani sıklıkla yaptığımız operasyonları nesne bazlı değiştireceğimiz yapıları oluştururuz
    //interface'ler,metotlar,classlar generiolabilir.
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Product
    {

    }
    class Customer
    {

    }
    //interface IProductDal
    //{
    //    List<Product> GetAll();
    //    Product Get(int id);
    //    void Add(Product product);
    //    void Delete(Product product);
    //    void Update(Product product);
    //}
    //interface ICustomerDal
    //{
    //List<Customer> GetAll();
    //Customer Get(int id);
    //void Add(Customer customer);
    //void Delete(Customer customer);
    //void Update(Customer customer);
    //}
    interface IProductDal : IRepository<Product>//sen repositorysin ve çalışman Product
    {

    }
    interface ICustomerDal : IRepository<Customer>//Repository'i customer olarak içine al çalıştır
    {

    }
    //generic repository interface 
    interface IRepository<T>//T : Type //Repository'e çalışacağım tipte nesne ver
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
