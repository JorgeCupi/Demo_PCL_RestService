using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ConsumingRestServices.Phone.Resources;
using ConsumingRestServices.Core;
using ConsumingServices.Core.Models;

namespace ConsumingRestServices.Phone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            WeatherResult result = await Services.GetWeatherResults(-16.509227, -68.124413, 10);
            lstWeatherResults.ItemsSource = result.list;
        }
    }
}