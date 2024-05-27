using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerApp.Classes
{
    internal class Fan
    {
        public int fanId;
        public string fanGender;

        public Fan(int fanId, string fanGender)
        {
            this.fanId = fanId;
            this.fanGender = fanGender;
        }
    }
}
