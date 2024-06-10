using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerApp
{
    internal class Tournament
    {
        public int Id { get; set; }
        public string DateOfTournament { get; set; }
        public string VenueOfTournament { get; set; }
        [ForeignKey(nameof(SoccerTeam))]
        public int? Team1Id{ get; set; }
        //[ForeignKey(nameof(SoccerTeam))]
       // public int? Team2Id { get; set; } 

        public SoccerTeam SoccerTeam { get; set; } 

        public Tournament() { }

        public Tournament(string dateOfTournament)
        {
            this.DateOfTournament = dateOfTournament;
        }

        public Tournament(string dateOfTournament, string venueOfTournament)
        {
            this.DateOfTournament = dateOfTournament;
            this.VenueOfTournament = venueOfTournament;
        }

       // public Tournament(string dateOfTournament, string venueOfTournament, int team1Id, int team2Id) : this(dateOfTournament, venueOfTournament)
        //{
         //   this.Team1Id = team1Id;
           // this.Team2Id = team2Id;
        //}
    }
}
