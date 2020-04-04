using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApps3
{
    public class TabletQuote : IQuote
    {
        public string SayHello()
        {
            return "Hello there, running on tablet!";
        }
    }
}
