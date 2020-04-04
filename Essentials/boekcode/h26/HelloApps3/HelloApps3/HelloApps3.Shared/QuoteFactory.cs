using System;
using System.Collections.Generic;
using System.Text;

namespace HelloApps3
{
    public class QuoteFactory
    {
        /// <summary>
        /// Creates a new Quote based on the platform the app is currentlty running on
        /// </summary>
        /// <returns>a new Quote object</returns>
        /// <remarks>Reference: http://stackoverflow.com/questions/23267992/detecting-current-device-in-windows-universal-app</remarks>
        public static IQuote Create()
        {
            IQuote quote = null;
#if WINDOWS_PHONE_APP
            // do when this is compiled as Windows Phone App
            quote = new PhoneQuote();
#else
            quote = new TabletQuote();
#endif
            return quote;
        }
    }
}
