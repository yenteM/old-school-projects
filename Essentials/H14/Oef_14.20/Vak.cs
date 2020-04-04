using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_14._20
{
    public class Vak
    {

        public Vak(string naam, string docent, int uren)
        {
            Naam = naam;
            Docent = docent;
            Uren = uren;
        }

        public string Naam { get; set; }
        public string Docent { get; set; }
        public int Uren { get; set; }

    }
}
