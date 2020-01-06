using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Danillo Perez
namespace BreachingDroneElite
{
    class Civilian
    {
        private string _Gender;
        private int _Age;
        private string _Injuries;
        private string _Additional_Info;

        public Civilian (string Gender, int Age, string Injuries, string Info)
            {
            this._Gender = Gender;
            this._Age = Age;
            this._Injuries = Injuries;
            this._Additional_Info = Info;
            }
        public Civilian(string Injuries, string Info)
        {
            this._Injuries = Injuries;
            this._Additional_Info = Info;
        }
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
            public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
            public string Injuries
        {
            get
            {
                return _Injuries;
            }
            set
            {
                _Injuries = value;
            }
        }
        public string Info 
        {
            get
            {
                return _Additional_Info;
            }
            set
            {
                _Additional_Info = value;
            }
        }
    }        
}
