using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Danillo Perez
namespace BreachingDroneElite
{
    //10:32
    class Room
    {
        string _RoomName;
        int _PersonCount;
        string _DangerLevel;
        string _Additional_Info;
        public Room(string RoomName, int PersonCount, string Dangerlevel, string Info)
        {
        }
        public string RoomName
        {
            get
            {
                return _RoomName;
            }
            set
            {
                _RoomName = value;
            }
        }
        public int PersonCount
        {
            get
            {
                return _PersonCount;
            }
            set
            {
                _PersonCount = value;
            }
        }
        public string DangerLevel
        {
            get
            {
                return _DangerLevel;
            }
            set
            {
                _DangerLevel = value;
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


