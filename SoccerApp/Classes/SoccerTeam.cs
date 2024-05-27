using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    internal class SoccerTeam : Tournament
    {
        public string nameOfTeam { get; set; }
        public int timesWon { get; set; }

        public SoccerTeam() { }

        public SoccerTeam(string nameOfTeam)
        {
            this.nameOfTeam = nameOfTeam;
        }

        public SoccerTeam(int timesWon)
        {
            this.timesWon = timesWon;
        }
        public SoccerTeam(string nameOfTeam, int timesWon)
        {
            this.nameOfTeam = nameOfTeam;
            this.timesWon = timesWon;
        }
    }
}
