using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Puffer
{
    public partial class PivotPage1 : PhoneApplicationPage
    {
        public PivotPage1()
        {
            InitializeComponent();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void setColor(string color)
        {
            Mind mind = new Mind();
            mind.Color = color;
        }

        private void NavigateNext()
        {
            NavigationService.Navigate(new Uri("/Clothing.xaml", UriKind.Relative));
        }

        private void puffer1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("teal");
            NavigateNext();
        }

        private void puffer2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("yellow");
            NavigateNext();
        }

        private void puffer3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("red");
            NavigateNext();
        }

        private void puffer4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("orange");
            NavigateNext();
        }

        private void puffer5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("green");
            NavigateNext();
        }

        private void puffer6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("blue");
            NavigateNext();
        }

        private void puffer7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("white");
            NavigateNext();
        }

        private void puffer8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("black");
            NavigateNext();
        }

        private void puffer9_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            setColor("purple");
            NavigateNext();
        }

    }
}