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

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
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
                    /*HttpClient client = new HttpClient();
                    string baseString = "";
                    LoginForm form = new LoginForm();
                    form.username = usrname.Text;
                    form.password = pswd.Password;
                    var jsonSer = JsonConvert.SerializeObject(form);
                    var response = await client.PostAsync(baseString, new StringContent(jsonSer, Encoding.UTF8, "application/json"));
                    string content = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode.ToString() == "OK")
                    {
                        MessageBox.Show("Tribalo bi biti ok");
                        accountInfo account = new accountInfo();
                        account.Username = usrname.Text;
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode.ToString());
                    }
                    SetProgress(false);*/
                    NavigationService.Navigate(new Uri("/Pages/registriraniKorisnik.xaml", UriKind.Relative));
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