using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_24._1
{
    class Varken : Dier
    {
        public override string Zegt()
        {
            return "groink";
        }

        public override string ToString()
        {
            return "Varken" + base.ToString();
        }
    }
}
