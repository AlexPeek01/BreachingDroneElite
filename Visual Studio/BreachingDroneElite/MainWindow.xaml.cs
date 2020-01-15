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
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private List<Room> rooms = new List<Room>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //File_Services.DeleteFile();

        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Startup();
            //File_Services.DeleteFile();
            Room room1 = new Room("Room1", 0, "Unknown", "");
            rooms.Add(room1);
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //File_Services.ImageInit();
            //imagebox.Source = File_Services.finalImage;

        }
        private void CaptureButton_Click(object sender, RoutedEventArgs e)
        {
            File_Services.SaveImage();
        }
        private void CNFRM_BTN(object sender, RoutedEventArgs e)
        {
            DataLayer.SQLQuery(textbox1.Text);
        }
        private void Stop_BTN_Click(object sender, RoutedEventArgs e)
        {
            imagebox.Visibility = Visibility.Hidden;
            dispatcherTimer.Stop();
        }
        private void Start_BTN_Click(object sender, RoutedEventArgs e)
        {
            imagebox.Visibility = Visibility.Visible;
            dispatcherTimer.Start();
        }
        private void Pause_BTN_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        public void Startup()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 30);
            dispatcherTimer.Start();
            //File_Services.DeleteFile();

           
        }
    }
}
