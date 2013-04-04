using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Puffer
{
    public partial class Clothing : PhoneApplicationPage
    {
        public Clothing()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void NavigateNext()
        {
            NavigationService.Navigate(new Uri("/Mood.xaml", UriKind.Relative));
        }

        private void InitialPuffer(string color)
        {
            switch (color)
            {
                case "teal":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer1.png", UriKind.Relative));
                    break;
                case "yellow":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer2.png", UriKind.Relative));
                    break;
                case "red":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer3.png", UriKind.Relative));
                    break;
                case "orange":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer4.png", UriKind.Relative));
                    break;
                case "green":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer5.png", UriKind.Relative));
                    break;
                case "blue":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer6.png", UriKind.Relative));
                    break;
                case "white":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer7.png", UriKind.Relative));
                    break;
                case "black":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer8.png", UriKind.Relative));
                    break;
                case "purple":
                    backgroundPuffer.Source = new BitmapImage(new Uri("/Assets/Colors/Puffer9.png", UriKind.Relative));
                    break;
                default:
                    //donothing;
                    break;
            }
        }

        private void setClothing(string clothing)
        {
            Mind mind = new Mind();
            mind.Clothing = clothing;
        }

        private void clothing1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("glasses");
            NavigateNext();
        }

        private void clothing2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("bowtie");
            NavigateNext();
        }

        private void clothing3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("tie");
            NavigateNext();
        }

        private void clothing4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("blue_muffs");
            NavigateNext();
        }

        private void clothing5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("pink_muffs");
            NavigateNext();
        }

        private void clothing6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("brown_scarf");
            NavigateNext();
        }

        private void clothing7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("blue_scarf");
            NavigateNext();
        }

        private void clothing8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("brown_hat");
            NavigateNext();
        }

        private void clothing9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setClothing("blue_hat");
            NavigateNext();
        }

        private void InitializePuffer(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Count > 0)
            {
                Mind mind = new Mind();
                InitialPuffer(mind.Color);
            }
        }
    }
}