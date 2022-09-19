using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OraceCustomerDal());

            customerManager.Add(new SqlServerCustomerDal());
        }
    }
    
    
    
    
}
