using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    
        sealed class Player : SoccerTeam
        {
            public string login {  get; set; }
            public string password { get; set; }
            public string playerFirstName {  get; set; }
            public string playerSecondName {  get; set; }

            public Player() { }

            public Player(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public Player(string login, string password, string playerFirstName, string playerSecondName) : this(login, password)
        {
            this.playerFirstName = playerFirstName;
            this.playerSecondName = playerSecondName;
        }

            public Player(string playerFirstName, string playerSecondName, int playerId, int playerAge)
            {
                this.playerFirstName = playerFirstName;
                this.playerSecondName = playerSecondName;
            }
        }
    
}
