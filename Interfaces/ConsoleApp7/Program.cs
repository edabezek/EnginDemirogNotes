using System;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            //veriyi bütün veri tabanlarına atmak amaçlı
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OraceCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
}
