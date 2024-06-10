using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp
{
    internal class Fan
    {
        [Key]
        public int fanId {  get; set; }
        [Required]
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Fan() { }
        public Fan(int fanId, string Login, string Password, string Role)
        {
            this.fanId = fanId;
            this.Login = Login;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
