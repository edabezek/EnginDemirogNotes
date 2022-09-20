using System;

namespace InvokeInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(DortIslem);

            var instance = Activator.CreateInstance(type,6,7);

            Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));//bir tipin herhangi bir methoduna get method ile ulaşıp ınvoke ile instance'ı çalıştırabiliyoruz.instance verdiğimiz değerler olacak.

            Console.ReadLine();
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
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
}

