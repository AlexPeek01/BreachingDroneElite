using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BreachingDroneElite
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (LoginService.EncryptPassword(Password.Password) == LoginService.hashedPassword && LoginService.userName == UsernameTextbox.Text)
            {
                LoginService.WindowOpen();
                this.Close();
            }
            else
            {
                IncorrectPass.Content = "Incorrect credentials";
                
            }
        }
    }
}
