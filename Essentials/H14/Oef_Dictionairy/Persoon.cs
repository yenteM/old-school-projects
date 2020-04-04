using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Dictionairy
{
    class Persoon
    {
        public Persoon(string naam, int nummer)
        {
            Naam = naam;
            Nummer = nummer;
        }

        public string Naam { get; set; }
        public int Nummer { get; set; }

    }
}
