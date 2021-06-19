using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.AddressUtilities
{
    public class AddressUtilities
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

    public class GenerateAddress
    {
        public class Request
        {
            public string Value { get; set; }
        }

        public class Response
        {
            public string PrivateKey { get; set; }
            public string Address { get; set; }
            public string HexAddress { get; set; }
        }
    }

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
