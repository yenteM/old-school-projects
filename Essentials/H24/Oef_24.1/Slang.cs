using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_24._1
{
    class Slang : Dier
    {
        public override string Zegt()
        {
            return "ssj";
        }

        public override string ToString()
        {
            return "Slang" + base.ToString();
        }
    }
}
