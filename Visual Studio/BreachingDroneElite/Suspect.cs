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
        private string _Priority;
        //public enum _Priority {Alpha, Bravo, Charlie, Delta};

        public Suspect(string Name, string Weapon, string Utility, string priority)
        {
            this._Name = Name;
            this._Weapon = Weapon;
            this._Utility = Utility;
            this._Priority = priority;
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Weapon
        {
            get
            {
                return _Weapon;
            }
            set
            {
                _Weapon = value;
            }
        }
        public string Utility
        {
            get
            {
                return _Utility;
            }
            set
            {
                _Utility = value;
            }
        }
        public string priority
        {
            get
            {
                return _Priority;
            }
            set
            {
                _Priority = value;
            }
        }
    }
}
