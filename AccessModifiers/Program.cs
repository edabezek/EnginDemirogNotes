using System;

namespace AccessModifiers //private>protected>internal>public
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Customer
    {
        private int Id;// sadece tanımlandığı blok veya sınıf içerisinde geçerlidir.

        protected int IDD;//class seviyesinde tanımlanır,private in tüm özelliklerini kapsar, ayrıca kalıtımla da kullanılır.


        public void Save()
        {

        }
        public void Delete()
        {

        }
    }
    class Student : Customer
    {
        public void Save2()
        {

        }
    }
    internal class Course // class ların default u internal,değişkenlerin private
                          //internal tanımlandıkları proje(assamble) içinde referans ihtiyacı  olmadan kullanılabilir.
                          //yani aynı proje içinde heryerden çağırılabilir.
    {
        public string Name { get; set; }
    }
}
//Class lar private,protected tanımlanamaz , çünkü kullanamayız. fakat iç içe class(nested) de  kullanılabilir.

//Course sınıfını farklı bir projden de kullanmak  istersek onu  public yapmalıyız.

//Ayrıca referans vererek yada projeyi using olarak ekleyerek de kullanbiliriz.----Bu cümleden emin değilim.----