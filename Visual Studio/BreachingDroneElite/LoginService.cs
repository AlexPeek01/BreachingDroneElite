using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreachingDroneElite
{
    class LoginService
    {
        public static string hashedPassword = "?iv??A???M???g??s?K??o*?H?";
       
        public static String EncryptPassword(string password)
            {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }
        public static void WindowOpenClose()
        {
           
            var mw = new MainWindow();
            mw.Show();

           


        }
    }
}
