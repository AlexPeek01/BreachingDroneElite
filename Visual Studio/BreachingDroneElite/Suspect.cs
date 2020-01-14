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
        private string _Additional_Information;

        public Suspect(string Name, string Weapon, string Utility, string priority, string info)
        {
            this._Name = Name;
            this._Weapon = Weapon;
            this._Utility = Utility;
            this._Priority = priority;
            this._Additional_Information = info;

            Suspect henk = new Suspect("henk","m4a1","grenades","3","likes to overendulge on snacks");

        }
        public Suspect(string Name, string priority, string info)
        {
            this._Name = Name;
            this._Priority = priority;
            this._Additional_Information = info;
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
        public string info
        {
            get
            {
                return _Additional_Information;
            }
            set
            {
                _Additional_Information = value;
            }
        }
       
    }
}
