using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions2
{
    public class RecordNotFoundException1 : Exception
    {
        public RecordNotFoundException1(string message) : base(message)
        {

        }
    }
}
