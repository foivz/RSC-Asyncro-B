using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Phone.Net.NetworkInformation;
using System.Runtime.Serialization.Json;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            dohvatiNesto();
            accountInfo.Username = "";
            accountInfo.Name = "";
            accountInfo.Password = "";
            accountInfo.Surname = "";
            pushNotification notifikacije = new pushNotification();
            BuildLocalizedApplicationBar();
        }
        private async void dohvatiNesto()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("http://188.226.168.226/api/achivement.php/");
            string content = await result.Content.ReadAsStringAsync();
            List<achievements> data = JsonConvert.DeserializeObject<List<achievements>>(content);
            int brojac = 0;
            int suma = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].username == accountInfo.Username)
                {
                    brojac = int.Parse(data[i].donations);
                    suma += int.Parse(data[i].donations);
                }
                suma += int.Parse(data[i].donations);
            }
            Statistics.moje = brojac;
            Statistics.ukupno = suma;
            Statistics.ostalo = Statistics.ukupno - Statistics.moje;
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Terminate();
        }
        // Sample code for building a localized ApplicationBar
        private void BuildLocalizedApplicationBar()
        {
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton loginBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/Check.png", UriKind.Relative));
            loginBtn.Text = "login";
            loginBtn.Click+=login;
            ApplicationBar.Buttons.Add(loginBtn);

            ApplicationBarIconButton register = new ApplicationBarIconButton(new Uri("/Assets/Icons/User-Add.png", UriKind.Relative));
            register.Text = "register";
            register.Click += registration;
            ApplicationBar.Buttons.Add(register);

        //    // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem forgotPsswd = new ApplicationBarMenuItem("forgot your password?");
            forgotPsswd.Click += forgotPass;
            ApplicationBar.MenuItems.Add(forgotPsswd);
        }
        private void forgotPass(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/forgotPassword.xaml", UriKind.Relative));
        }
        private async void login(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                SetProgress(true);
                if (usrname.Text == "" || pswd.Password == "")
                {
                    MessageBox.Show("Please eneter username and password!");
                }
                else
                {
                    HttpClient client = new HttpClient();
                    var values = new List<KeyValuePair<string, string>>();
                    values.Add(new KeyValuePair<string, string>("username", usrname.Text));
                    values.Add(new KeyValuePair<string, string>("password", pswd.Password));
                    var content = new FormUrlEncodedContent(values);
                    var response = await client.PostAsync("http://188.226.168.226/api/login.php", content);
                    var responseString = await response.Content.ReadAsStreamAsync();

                    if (response.StatusCode.ToString() == "OK")
                    {
                        if (response.Content.ReadAsStringAsync().Result == "0")
                        {
                            MessageBox.Show("User does not exist");
                        }
                        else
                        {
                            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(userData));
                            userData res = JsonConvert.DeserializeObject<userData>(response.Content.ReadAsStringAsync().Result);
                            accountInfo.Name = res.name;
                            accountInfo.Surname = res.surname;
                            accountInfo.mail = res.email;
                            accountInfo.Password = res.password;
                            accountInfo.Username = res.username;
                            accountInfo.id = res.id;
                            NavigationService.Navigate(new Uri("/Pages/registriraniKorisnik.xaml", UriKind.Relative));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode.ToString());
                    }
                    SetProgress(false);
                    
                }
                SetProgress(true);
            }
            else
            {
                MessageBox.Show("No internet connection!");
                SetProgress(false);
            }
            SetProgress(false);
        }
        private void registration(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/userForm.xaml", UriKind.Relative));
        }
        
        public void SetProgress(bool value)
        {
            if (SystemTray.ProgressIndicator == null)
            {
                SystemTray.ProgressIndicator = new ProgressIndicator();
                SystemTray.ProgressIndicator.Text = "logging in";
            }

            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }
    }
}