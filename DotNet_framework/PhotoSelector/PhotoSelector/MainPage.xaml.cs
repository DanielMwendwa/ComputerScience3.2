using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using System.Windows.Media.Imaging;

namespace PhotoSelector
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // hide the two buttons
            BtnCamera.Visibility = Visibility.Collapsed;
            BtnGallery.Visibility = Visibility.Collapsed;
        }

        // Create camera and photochooser objects
        // Create camera object
        CameraCaptureTask cct = new CameraCaptureTask();
        // create photochooser task
        PhotoChooserTask pct = new PhotoChooserTask();

        private void RdoCamera_Checked(object sender, RoutedEventArgs e)
        {
            // enable the camera button
            BtnGallery.Visibility = Visibility.Collapsed;
            BtnCamera.Visibility = Visibility.Visible;       
        }

        private void RdoPhotoGallery_Checked(object sender, RoutedEventArgs e)
        {
            // enable the photochooser button
            BtnCamera.Visibility = Visibility.Collapsed;
            BtnGallery.Visibility = Visibility.Visible;
        }

        private void BtnCamera_Click(object sender, RoutedEventArgs e)
        {
            // show windows camera
            cct.Show();
            cct.Completed += new EventHandler<PhotoResult>(cct_Completed);
        }

        void cct_Completed(object sender, PhotoResult e)
        {
            // code to display image
            BitmapImage Image = new BitmapImage();
            // set image source
            Image.SetSource(e.ChosenPhoto);
            //display on image control
            this.imgShow.Source = Image;
        }

        private void BtnGallery_Click(object sender, RoutedEventArgs e)
        {
            // show photochooser
            pct.Show();
            pct.Completed += new EventHandler<PhotoResult>(pct_Completed);
        }

        void pct_Completed(object sender, PhotoResult e)
        {
            // code to display image
            BitmapImage Image = new BitmapImage();
            // set image source
            Image.SetSource(e.ChosenPhoto);
            // display on image control
            this.imgShow.Source = Image;
        }
    }
}