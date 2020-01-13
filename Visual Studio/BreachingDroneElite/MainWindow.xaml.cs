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
        private int ID = 0;
        private string Naam = "Unknown";
        private int Team;
        private int savedImageCount = 100;
        DataLayer dl = new DataLayer();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeleteImages();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            TimerStart();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            TimerTick();
        }
        private void CaptureButton_Click(object sender, RoutedEventArgs e)
        {
            SaveImage();
        }
        private void TimerStart()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            dispatcherTimer.Start();
        }
        public void TimerTick()
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
            catch (IOException) { }
        }

        private void SaveImage()
        {
            ID = 7;
            Naam = "Björn";
            Team = 1;
            try
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(@"C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame.jpg");
                string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                string imageString = base64ImageRepresentation;
                System.IO.File.Move("C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame.jpg", "C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame" + savedImageCount + ".jpg");
                //DataLayer.SQLQuery();
                 DataLayer.SQLQuery("INSERT INTO face (id, Naam, Team, img) " +
                                   "VALUES('" + ID + "', '" + Naam + "', '" + Team + "', '" + "imgstring" + "')");
                savedImageCount++;
                DataLayer.SQLQuery("SELECT * FROM face");
            }
            catch
            {
                savedImageCount++;
            }
        }
        private void DeleteImages()
        {
            for (int i = 0; i <= savedImageCount; i++)
            {
                File.Delete(@"C:\Users\alexp\OneDrive\Documenten\GitHub\BreachingDroneElite\Visual Studio\Images\Frame" + i + ".jpg");
            }
            savedImageCount = 0;
        }

        private void CNFRM_BTN(object sender, RoutedEventArgs e)
        {
            DataLayer.SQLQuery(textbox1.Text);
        }
    }
}
