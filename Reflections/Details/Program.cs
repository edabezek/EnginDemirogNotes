using System;
using System.Reflection;

namespace Details//reflection'ı sınıfın özelliklerine ulaşmak için kullanacağız
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(DortIslem);

            var metodlar = type.GetMethods();

            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı : {0}",info.Name);
                //çıktı
                //Metod adı : Topla
                //Metod adı : Carp
                //Metod adı: Topla2
                //Metod adı: Carp2
                //Metod adı: GetType
                //Metod adı: ToString
                //Metod adı: Equals
                //Metod adı: GetHashCode
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre adı : {0}", parameterInfo.Name);
                    //çıktı
                    //Metod adı : Topla
                    //Parametre adı: sayi1
                    //Parametre adı: sayi2
                    //Metod adı: Carp
                    //Parametre adı: sayi1
                    //Parametre adı: sayi2
                    //Metod adı: Topla2
                    //Metod adı: Carp2
                    //Metod adı: GetType
                    //Metod adı: ToString
                    //Metod adı: Equals
                    //Parametre adı: obj
                    //Metod adı: GetHashCode
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute adı : {0}", attribute.GetType().Name);
                    //attribute ekledik çıktı:
                    //Metod adı : Topla
                    //Parametre adı: sayi1
                    //Parametre adı: sayi2
                    //Metod adı: Carp
                    //Parametre adı: sayi1
                    //Parametre adı: sayi2
                    //Metod adı: Topla2
                    //Metod adı: Carp2
                    //Attribute adı: MethodNameAttribute
                    //Metod adı: GetType
                    //Attribute adı: NullableContextAttribute
                    //Metod adı: ToString
                    //Metod adı: Equals
                    //Parametre adı: obj
                    //Metod adı: GetHashCode


                }
            }

        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)//kullanıcıdan aldığımız yer burası
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;//kullanıcıdan girilmesini ister.
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;//constructordan gelen değişkenleri set eder
        }
        [MethodName("Carpma")]//apide görünen ismi için 
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}


