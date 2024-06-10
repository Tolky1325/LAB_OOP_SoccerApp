using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerApp
{
    internal class Admin
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Role { get; set; }

        public Admin() { }

        public Admin(int id, string login, string password, string role)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Role = role;
        }

        public Admin(int id, string login, string password, string name, string surname)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
        }

        
        
        public delegate void PerformTextOut(string text);

       
        public void ExecuteDelegates()
        {
            PerformTextOut textOut1 = MethodA;
            textOut1("Hello from MethodA!");

            
            PerformTextOut textOut2 = (string txt) => Console.WriteLine(txt);
            textOut2("Hello from lambda!");

            
            PerformTextOut textOut3 = txt => Console.WriteLine(txt);
            textOut3("Hello from lambda with inferred type!");
        }

        static void MethodA(string text)
        {
            Console.WriteLine(text);
        }
    }
}
