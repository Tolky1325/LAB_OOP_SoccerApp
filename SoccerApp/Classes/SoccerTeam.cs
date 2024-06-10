using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoccerApp
{
    internal class SoccerTeam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nameOfTeam { get; set; }
        public int timesWon { get; set; }

        public ICollection<Player> players { get; set; }

        public Tournament Tournament { get; set; }

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
