using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    internal class Admin
    {
        int id {  get; set; }
        string login {  get; set; }
        string password { get; set; }
        string name;
        string surname;

        public Admin() {}

        public Admin(int id, string login, string password)
        {
            this.id = id;
            this.login = login;
            this.password = password;
        }
        public Admin(int id, string login, string password, string name, string surname)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.name = name;
            this.surname = surname;
        }
    }
}
