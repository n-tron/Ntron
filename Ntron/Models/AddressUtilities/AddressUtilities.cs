using Ntron.Models.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.AddressUtilities
{
    public class CreateAddress
    {
        public class Request
        {
            public string value { get; set; }
        }
        public class Response : GeneralResponse.ErrorResponse
        {
            public string Base58CheckAddress { get; set; }
            public string Value { get; set; }
        }
    }

    public class GenerateAddress
    {
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
            public string address { get; set; }
        }

        public class Response : GeneralResponse.ErrorResponse
        {
            public bool Result { get; set; }
            public string Message { get; set; }
        }
    }
}
