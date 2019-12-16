using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Alex Peek
namespace BreachingDroneElite
{
    class Operator
    {
        private string _Name;
        private string _Rank;
        private string _Weapon;
        private string _Utility;
        //Test for github

        public Operator(string Name, string Rank, string Weapon, string Utility)
        {
            this._Name = Name;
            this._Rank = Rank;
            this._Weapon = Weapon;
            this._Utility = Utility;
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
        public string Rank
        {
            get
            {
                return _Rank;
            }
            set
            {
                _Rank = value;
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
    }


}
