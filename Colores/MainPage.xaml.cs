using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Colores.Resources;
using System.Windows.Media;

namespace Colores
{
    public partial class MainPage : PhoneApplicationPage
    {
        int ro = 0;
        int az = 0;
        int am = 0;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
          

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        private void Combinacion()
        {
            if (ro == 1)
            {
                if (az == 1)
                {
                    if (am == 1)
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.White);
                    }
                    else
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Purple);
                    }
                }
                else
                {
                    if (am == 1)
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Orange);
                    }
                    else
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Red);
                    }
                }
            }
            else
            {
                if (am == 1)
                {
                    if (az == 1)
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Green);
                    }
                    else
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Yellow);
                    }
                }
                else
                {
                    if (az == 1)
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Blue);
                    }
                    else
                    {
                        RectanguloColorCom.Fill = new SolidColorBrush(Colors.Black);
                    }
                }
            }
            
        }

        private void UnicoRojo(object sender, RoutedEventArgs e)
        {
            RectanguloColorUnico.Fill = new SolidColorBrush(Colors.Red);
        }

        private void UnicoAzul(object sender, RoutedEventArgs e)
        {
            RectanguloColorUnico.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void UnicoAmarillo(object sender, RoutedEventArgs e)
        {
            RectanguloColorUnico.Fill = new SolidColorBrush(Colors.Yellow);
        }

        private void RojoCom(object sender, RoutedEventArgs e)
        {
            //CheckBox c = sender as CheckBox;

            //var isChecked = c.IsChecked;
            //if(isChecked)


            if (ro == 0)
            {
                ro = 1;
            }
            else 
            {
                ro = 0;
            }
            Combinacion();
            
           
           
        }

        private void AzulCom(object sender, RoutedEventArgs e)
        {
            if (az == 0)
            {
                az = 1;
            }
            else
            {
                az = 0;
            }
            Combinacion();
            

        }

        private void AmarilloCom(object sender, RoutedEventArgs e)
        {
            if (am == 0)
            {
                am = 1;
            }
            else
            {
                am = 0;
            }
            Combinacion();
            

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}