using System;

namespace SoccerApp
{
    internal class Admin
    {
        // Properties with capitalized names
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Constructors
        public Admin() { }

        public Admin(int id, string login, string password)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
        }

        public Admin(int id, string login, string password, string name, string surname)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
        }

        // Delegate definition
        public delegate void PerformTextOut(string text);

        // Method using delegates
        public void ExecuteDelegates()
        {
            PerformTextOut textOut1 = MethodA;
            textOut1("Hello from MethodA!");

            // Using lambda expression
            PerformTextOut textOut2 = (string txt) => Console.WriteLine(txt);
            textOut2("Hello from lambda!");

            // Using lambda expression with inferred parameter type
            PerformTextOut textOut3 = txt => Console.WriteLine(txt);
            textOut3("Hello from lambda with inferred type!");
        }

        // Static method for the delegate
        static void MethodA(string text)
        {
            Console.WriteLine(text);
        }
    }
}
