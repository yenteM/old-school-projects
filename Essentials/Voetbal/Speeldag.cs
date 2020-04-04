using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbal
{
    public class Speeldag
    {
        private int Dagnummer;
        private List<Ploeg> PloegenReeks1;
        private List<Ploeg> PloegenReeks2;
        private List<int> ScoreReeks1;
        private List<int> ScoreReeks2;
        private DateTime Datum;

        public Speeldag(int Dagnummer, List<Ploeg> PloegenReeks1, List<Ploeg> PloegenReeks2, List<int> ScoreReeks1, List<int> ScoreReeks2, DateTime Datum)
        {
            this.Dagnummer = Dagnummer;
            this.PloegenReeks1 = PloegenReeks1;
            this.PloegenReeks2 = PloegenReeks2;
            this.ScoreReeks1 = ScoreReeks1;
            this.ScoreReeks2 = ScoreReeks2;
            this.Datum = Datum;
        }

        
    }
}
