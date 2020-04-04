using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_24._1
{
    class Koe : Dier
    {
        public override string Zegt()
        {
            return "boe";
        }

        public override string ToString()
        {
            return "Koe" + base.ToString();
        }
    }
}
