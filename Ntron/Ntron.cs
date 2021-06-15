using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron
{
    public interface INtron
    {
        string Url { get; set; }
        string APIKey { get; set; }
    }
    public class Ntron : INtron
    {
        public string Url { get; set; }
        public string APIKey { get; set; }
    }
}
