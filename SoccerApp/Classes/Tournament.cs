using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    internal class Tournament
    {
        public string dateOfTournament { get; set; }
        public string venueOfTournament { get; set; }

        public Tournament() { }

        public Tournament(string dateOftournament)
        {
            this.dateOfTournament = dateOftournament;
        }

        public Tournament(string dateOfTournament, string venueOfTournament)
        {
            this.dateOfTournament = dateOfTournament;
            this.venueOfTournament = venueOfTournament;
        }
    }
}
