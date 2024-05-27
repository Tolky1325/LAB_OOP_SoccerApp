using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    
        sealed class Player : SoccerTeam
        {
            public string playerFirstName;
            public string playerSecondName;
            public int playerId;
            public string playerAge;

            public Player() { }

            public Player(int playerId)
            {
                this.playerId = playerId;
            }
            public Player(string playerFirstName, string playerSecondName)
            {
                this.playerFirstName = playerFirstName;
                this.playerSecondName = playerSecondName;
            }

            public Player(string playerFirstName, string playerSecondName, int playerId, string playerAge)
            {
                this.playerFirstName = playerFirstName;
                this.playerSecondName = playerSecondName;
                this.playerId = playerId;
                this.playerAge = playerAge;
            }
        }
    
}
