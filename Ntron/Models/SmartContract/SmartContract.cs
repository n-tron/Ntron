using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.SmartContract
{
    public class GetContract
    {
        public class Request
        {
            public string Value { get; set; }
            public string Visible { get; set; }

        }

        public class Response
        {

        }
    }

    public class TriggerSmartContract
    {
        public class Request
        {
            public string Owner_Address { get; set; }
            public string Contract_Address { get; set; }
            public string Function_Selector { get; set; }
            public string Parameter { get; set; }
            public int Fee_Limit { get; set; }
            public int Call_Value { get; set; }
            public int Permission_Id { get; set; }
            public bool Visible { get; set; }
        }

        public class Response
        {

        }
    }

    public class DeployContract
    {
        public class Request
        {
            public string Abi { get; set; }
            public string Bytecode { get; set; }
            public int Fee_Limit { get; set; }
            public string Parameter { get; set; }
            public int Origin_Energy_Limit { get; set; }
            public string Owner_Address { get; set; }
            public string Name { get; set; }
            public int Call_Value { get; set; }
            public int Consume_User_Resource_Percent { get; set; }
            public int Permission_Id { get; set; }
            public bool Visible { get; set; }

        }

        public class Response
        {

        }
    }

}
