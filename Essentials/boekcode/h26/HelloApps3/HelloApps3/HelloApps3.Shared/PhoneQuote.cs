using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApps3
{
    public class PhoneQuote : IQuote
    {
        public string SayHello()
        {
            return "Hello there, running on phone!";
        }
    }
}
