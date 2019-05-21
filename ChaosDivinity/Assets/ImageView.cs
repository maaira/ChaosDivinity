using System;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ChaosDivinity.Assets
{
    public class ImageView
    {
        public static Image ImageSet(string path)
        {
            Image img = new Image();
            BitmapImage bitmapImage = new BitmapImage();
            img.Width = bitmapImage.DecodePixelWidth = 70;

            try
            {

                bitmapImage.UriSource = new Uri(path);

            }
            catch (UriFormatException e)
            {
                Debug.WriteLine(e.Source);
                Debug.WriteLine(e.Message);

            }
            img.Source = bitmapImage;
            return img;
        }
    }
}
