using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_24._1
{
    abstract class Dier
    {

        public Dier() { }
        public int Gewicht { get; set; }
        public abstract string Zegt();

        /*public override string ToString()
        {
            return this.GetType().Name + ": weegt " + Gewicht + "kg en zegt " + Zegt();
        }*/

        public override string ToString()
        {
            return ": weegt " + Gewicht + "kg en zegt " + Zegt();
        }

    }
}
