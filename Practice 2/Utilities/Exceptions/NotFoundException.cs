using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2.Utilities.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
