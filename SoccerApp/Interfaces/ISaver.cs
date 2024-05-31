using System;

namespace SoccerApp
{
    internal interface ISaver
    {
        string this[string key] { get; set; }

        string login { get; set; }
        string password { get; set; }
    }

    
    
}
