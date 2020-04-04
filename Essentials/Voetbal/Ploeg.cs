using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbal
{
    public class Ploeg
    {
        private int stamnummer;
        private string naam;
        private int punten;
        private List<Speler> spelers;

        public Ploeg(int stamnummer, string naam, int punten, List<Speler> spelers)
        {
            this.stamnummer = stamnummer;
            this.naam = naam;
            this.punten = punten;
            this.spelers = spelers;
        }

        public string Naam()
        {
            return naam;
        }
    }
}
