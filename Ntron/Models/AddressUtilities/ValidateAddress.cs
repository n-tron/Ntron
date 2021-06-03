using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.AddressUtilities
{
    public class ValidateAddress
    {
        public class Request
        {
            public string Address { get; set; }
        }

        public class Response
        {
            public bool Result { get; set; }
        }
    }
}
