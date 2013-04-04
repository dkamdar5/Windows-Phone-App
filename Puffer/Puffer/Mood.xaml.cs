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
    public partial class Mood : PhoneApplicationPage
    {
        public Mood()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void mood1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("smile");
        }

        private void mood2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("frown");
        }

        private void mood3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("normal");
        }

        private void mood4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("mad");
        }

        private void mood5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("calm");
        }

        private void mood6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("happy");
        }

        private void mood7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("sleepy");
        }

        private void mood8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("naughty");
        }

        private void mood9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Confirmation("love");
        }

        private void setMood(string mood)
        {
            Mind mind = new Mind();
            mind.Mood = mood;
            mind.CreationComplete = true;
        }

        private void Confirmation(string mood)
        {
            MessageBoxResult result = MessageBox.Show("Do you set this as password?","Confirmation", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                setMood(mood);
                App.Current.Terminate();
            }
        }

        private void InitializePuffer(object sender, RoutedEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Count > 1)
            {
                Mind mind = new Mind();
                InitialPuffer(mind.Color,mind.Clothing);
            }
        }

        private void InitialPuffer(string color, string clothing)
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

                switch (clothing)
            {
                case "glasses":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes1.png", UriKind.Relative));
                    break;
                case "bowtie":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes2.png", UriKind.Relative));
                    break;
                case "tie":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes3.png", UriKind.Relative));
                    break;
                case "blue_muffs":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes4.png", UriKind.Relative));
                    break;
                case "pink_muffs":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes5.png", UriKind.Relative));
                    break;
                case "brown_scarf":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes6.png", UriKind.Relative));
                    break;
                case "blue_scarf":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes7.png", UriKind.Relative));
                    break;
                case "brown_hat":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes8.png", UriKind.Relative));
                    break;
                case "blue_hat":
                    backgroundClothing.Source = new BitmapImage(new Uri("/Assets/Clothes/Clothes9.png", UriKind.Relative));
                    break;
                default:
                    //donothing;
                    break;
            }
        }
    }
}