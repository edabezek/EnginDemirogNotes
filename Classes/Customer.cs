using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Customer
    {
        public int Id { get; set; }//class da ıd ekleyince set çalışır 
        public string FirstName { get; set; }
        //public FirstName diye  yazabilirdik ama encapsulation olmamış olurdu.
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
