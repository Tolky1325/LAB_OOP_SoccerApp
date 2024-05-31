using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    internal class Fan : ISaver
    {
        public int fanId {  get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string fanGender;

        public Fan() { }
        public Fan(int fanId, string login, string password)
        {
            this.fanId = fanId;
            this.login = login;
            this.password = password;
        }
        public Fan(int fanId, string fanGender)
        {
            this.fanId = fanId;
            this.fanGender = fanGender;
        }

        public override string ToString()
        {
            return $"fanId: {fanId}, login: {login}, password: {password}";
        }
    }
}
