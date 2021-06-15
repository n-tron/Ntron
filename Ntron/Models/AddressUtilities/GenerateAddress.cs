﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.AddressUtilities
{
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
}
