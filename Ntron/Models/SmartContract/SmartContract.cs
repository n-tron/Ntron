using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.SmartContract
{
    public class GetContract
    {
        public class Request
        {
            public string value { get; set; }
            public string visible { get; set; }

        }

        public class Response
        {

        }
    }

    public class TriggerSmartContract
    {
        public class Request
        {
            public string owner_address { get; set; }
            public string contract_address { get; set; }
            public string function_selector { get; set; }
            public string parameter { get; set; }
            public int fee_limit { get; set; }
            public int call_value { get; set; }
            public int permission_id { get; set; }
            public bool visible { get; set; }
        }

        public class Response
        {

        }
    }

    public class DeployContract
    {
        public class Request
        {
            public string abi { get; set; }
            public string bytecode { get; set; }
            //public int fee_limit { get; set; }
            //public string parameter { get; set; }
            //public int origin_energy_limit { get; set; }
            public string owner_address { get; set; }
            public string name { get; set; }
            //public int call_value { get; set; }
            //public int consume_user_resource_percent { get; set; }
            //public int permission_id { get; set; }
            //public bool visible { get; set; }

        }

        public class Response
        {

        }
    }

}
