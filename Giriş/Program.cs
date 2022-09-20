using System;

namespace Giriş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla(2, 2);//kendi verdiğimiz değer ile çalışacak
            //dortIslem.Topla2();//değer yazmayız constructordaki değerleden çalışır.(2,3) ile

            //bunu runtime ile yapmak istersek -reflection kullanmak 
            var type= typeof(DortIslem);//burada bizim çalışacağımız bir tip var o da 4 işlem -bu instance alma değil tipini alıyoruz- 

            DortIslem dortIslem =(DortIslem)Activator.CreateInstance(type);//bununla instance almak aynı şey-burada gelen tipe göre almış oluyoruz. (Activator obje döner-bu yüzden cast yaptık.)
            dortIslem.Topla(2, 2);

            DortIslem dortIslem2 = (DortIslem)Activator.CreateInstance(type,6,7); 
            dortIslem2.Topla2(); 
        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1,int sayi2)//kullanıcıdan aldığımız yer burası
        {
            _sayi1=sayi1;   
            _sayi2=sayi2;   
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
//reflectionda çalışma anında-runtime bilgi toplanabilir
//runtime-çalışma anında nesnelerimiz hakkında bilgi almak ve bu nesneleri çalıştırabilmek için kullanılır.