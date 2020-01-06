using Emgu.CV;
using Emgu.CV.Structure;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.IO;
using System.Drawing;
using System.Windows.Threading;
using System.Net.Cache;
using System.Data;
using Npgsql;
using System.Diagnostics;

namespace BreachingDroneElite
{
    public partial class MainWindow : Window
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void llOpenConnAndSelect_LinkClicked(object sender,
                     LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string connstring = String.Format("Server={0};Port={1};" +
                    "User Id={2};Password={3};Database={4};");
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT * FROM simple_table";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                conn.Close();
            }
            catch (Exception msg)
            {
                throw;
            }
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                BitmapImage _image = new BitmapImage();
                _image.BeginInit();
                _image.CacheOption = BitmapCacheOption.None;
                _image.UriCachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
                _image.CacheOption = BitmapCacheOption.OnLoad;
                _image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                _image.UriSource = new Uri(@"C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame.jpg", UriKind.RelativeOrAbsolute);
                _image.EndInit();
                imagebox.Source = _image;
            }
            catch (IOException)
            {

            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dispatcherTimer.Start();
        }
    }
}
