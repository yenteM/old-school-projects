using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_13._8
{
    class Persoon
    {
        private string naam;
        private string voornaam;
        private string geslacht;
        private string adres;
        private string telefoon;
        private DateTime geboortedatum;

        public Persoon(string naam, string voornaam, string geslacht, string adres, string telefoon, DateTime geboortedatum)
        {
            Naam = naam;
            Voornaam = voornaam;
            Geslacht = geslacht;
            Adres = adres;
            Telefoon = telefoon;
            Geboortedatum = geboortedatum;
        }

        private string Naam { get { return naam; } set { naam = value; } }

        private string Voornaam { get { return voornaam; } set { voornaam = value; } }

        private string Geslacht { get { return geslacht; } set { geslacht = value; } }

        private string Adres { get { return adres; } set { adres = value; } }

        private string Telefoon { get { return telefoon; } set { telefoon = value; } }

        private DateTime Geboortedatum { get { return geboortedatum; } set { geboortedatum = value; } }

    }
}
