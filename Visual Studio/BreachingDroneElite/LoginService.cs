using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreachingDroneElite
{
    class LoginService
    {
        private static string _userName = "admin";
        private static string _hashedPassword = "?iv??A???M???g??s?K??o*?H?";
        public static String EncryptPassword(string password)
            {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
        public static void WindowOpen()
        {
            var mw = new MainWindow();
            mw.Show();
        }
        public static string hashedPassword
        {
            get
            {
                return _hashedPassword;
            }
            set
            {
                _hashedPassword = value;
            }
        }
        public static string userName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        //Easteregg 2
    }
}
