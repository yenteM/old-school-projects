using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbal
{
    public enum SpelersFunctie
    {
        Doelman = 'D',
        Verdediger = 'V',
        Middenvelder = 'M',
        Aanvaller = 'A'
    }

    public class Speler
    {
        private string naam;
        private string voornaam;
        private int rugnummer;
        private SpelersFunctie functie;

        public Speler(string naam, string voornaam, int rugnummer, SpelersFunctie functie)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.rugnummer = rugnummer;
            this.functie = functie;
        }
    }
}
