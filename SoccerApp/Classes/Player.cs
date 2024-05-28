using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    
        sealed class Player : SoccerTeam
        {
            public string login;
            public string password;
            public string playerFirstName;
            public string playerSecondName;
            public int playerId;
            public int playerAge;

            public Player() { }

            public Player(int playerId)
            {
                this.playerId = playerId;
            }
            public Player(string login, string password, string playerFirstName, string playerSecondName, int playerId, int playerAge) : this(login, password)
        {
            this.playerFirstName = playerFirstName;
            this.playerSecondName = playerSecondName;
            this.playerId = playerId;
            this.playerAge = playerAge;
        }

        public Player(int playerId , string login, string password)
            {
                this.playerId = playerId;
                this.login = login;
                this.password = password;
            }

            public Player(string playerFirstName, string playerSecondName, int playerId, int playerAge)
            {
                this.playerFirstName = playerFirstName;
                this.playerSecondName = playerSecondName;
                this.playerId = playerId;
                this.playerAge = playerAge;
            }
        }
    
}
