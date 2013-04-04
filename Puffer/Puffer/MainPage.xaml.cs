using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Puffer.Resources;

namespace Puffer
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCreate_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigateNext();//go to next page
        }

        private void btnLogin_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Count > 0) //if something stored
            {
                Mind mind = new Mind();
                if (mind.CreationComplete)
                {
                    //password is stored successfully in storage
                    NavigateNext();
                }
                else
                {
                    MessageBox.Show("Please Create Password First");//error
                }
            }
            else
            {
                MessageBox.Show("Please Create Password First");//error
            }
        }

        private void NavigateNext()
        {
            //navigates to the next page
            NavigationService.Navigate(new Uri("/Color.xaml", UriKind.Relative));
        }
    }
}