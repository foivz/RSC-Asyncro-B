using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Devices.Geolocation;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PhoneApp1
{
    public partial class Donor : PhoneApplicationPage
    {
        public Donor()
        {
            InitializeComponent();
            postaviSucelje();
        }
        private async void postaviSucelje()
        {
            List<donorControl> donori = new List<donorControl>();
           /* if (Settings.locationUsage == true)
            {
                Geolocator geo = new Geolocator();
                Geoposition geoposition = await geo.GetGeopositionAsync(maximumAge: TimeSpan.FromMinutes(5), timeout: TimeSpan.FromSeconds(10));
                string lat = geoposition.Coordinate.Latitude.ToString();
                string lon = geoposition.Coordinate.Longitude.ToString();
            }*/
            //else
           // {
            HttpClient client = new HttpClient();
            var values = new List<KeyValuePair<string, string>>();
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://188.226.168.226/api/institutions.php",content);
            string responseString = await response.Content.ReadAsStringAsync();
            
            if (responseString != "")
            {

                List<donorJSON> data = JsonConvert.DeserializeObject<List<donorJSON>>(responseString);
                for (int i = 0; i < data.Count; i++)
                {
                    donorControl d = new donorControl();
                    Uri uri = new Uri(data[i].picture, UriKind.Absolute);
                    ImageSource imgSource = new BitmapImage(uri);
                    d.slika.Source = imgSource; 
                    d.adress.Text = "Adress: " + data[i].adress;
                    d.capacity.Text = "Capacity: " + data[i].capacity;
                    d.username.Text = "Name: " + data[i].username;
                    d.stored.Text = "Stored: " + data[i].stored;
                    d.Tap += gridTapped;
                    donori.Add(d);
                }
                foreach (donorControl don in donori)
                {
                    stackPanel.Children.Add(don);
                }
            }
                
           // }
        }

        private void gridTapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/donation.xaml", UriKind.Relative));
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            ocisti();
        }
        private void ocisti()
        {
            stackPanel.Children.Clear();
        }
    }
    
}