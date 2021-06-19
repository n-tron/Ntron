using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Models.TRC10Token
{       
    public class TransferAsset
    {
        public class Request
        {
            public string Owner_Address { get; set; }
            public string To_Address { get; set; }
            public string Asset_Name { get; set; }
            public int Amount { get; set; }
            public int Permission_Id { get; set; }
            public bool Visible { get; set; }
        }

        public class Response
        {

        }
    }

}
