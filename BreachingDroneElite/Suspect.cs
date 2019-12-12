using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Alex Peek
namespace BreachingDroneElite
{
    class Suspect
    {
        private string _Name;
        private string _Weapon;
        private string _Utility;
        enum _Priority {Alpha, Bravo, Charlie, Delta};

        public Suspect(string Name, string Weapons, string Utility, string Priority)
        {
            this._Priority = Priority
        }
    }
}
