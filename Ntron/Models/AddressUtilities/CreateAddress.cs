using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.AddressUtilities
{
    public class CreateAddress
    {
        public class Request
        {
            public string Value { get; set; }
        }
        public class Response 
        {
            public string Base58CheckAddress { get; set; }
            public string Value { get; set; }
        }
    }
}
