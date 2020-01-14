using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BreachingDroneElite
{
    class File_Services
    {
        public static BitmapImage finalImage;
        public static int savedImageCount = Directory.GetFiles(@"C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images").Length - 1;

        public static void DeleteFile()
        {
            for (int i = 0; i <= savedImageCount; i++)
            {
                File.Delete(@"C:\Users\alexp\OneDrive\Documenten\GitHub\BreachingDroneElite\Visual Studio\Images\Frame" + i + ".jpg");
            }
            savedImageCount = 0;
        }
        public static void ImageInit()
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
                finalImage = _image;
            }
            catch (IOException)
            {

            }

        }
        public static string ConvertImage()
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(@"C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame.jpg");
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            string imageString = base64ImageRepresentation;
            return imageString;
        }
        public static void SaveImage()
        {
            int id = DataLayer.userCount + 1;
            string naam = "Unknown";
            int team = 0;
            try
            {
                string imageString = File_Services.ConvertImage();
                System.IO.File.Move("C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame.jpg", "C:/Users/alexp/OneDrive/Documenten/GitHub/BreachingDroneElite/Visual Studio/Images/Frame" + savedImageCount + ".jpg");
                DataLayer.SQLQuery("INSERT INTO face (id, Naam, Team, img) " +
                                   "VALUES('" + id + "', '" + naam + "', '" + team + "', '" + imageString + "')");
                savedImageCount++;
                DataLayer.SQLQuery("SELECT * FROM face");
            }
            catch
            {
                savedImageCount++;
            }
        }

    }
}
