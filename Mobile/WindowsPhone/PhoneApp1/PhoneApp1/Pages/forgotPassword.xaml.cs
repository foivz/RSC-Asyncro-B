using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Net.Http;

namespace PhoneApp1.Pages
{
    public partial class forgotPassword : PhoneApplicationPage
    {
        public forgotPassword()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }
        private void BuildLocalizedApplicationBar()
        {
            //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton mail = new ApplicationBarIconButton(new Uri("/Assets/Icons/Check.png", UriKind.Relative));
            mail.Text = "send";
            mail.Click += send;
            ApplicationBar.Buttons.Add(mail);
        }
        private async void send(object sender, EventArgs e)
        {
            SetProgress(true);
            HttpClient client = new HttpClient();
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("email", eMail.Text));
            values.Add(new KeyValuePair<string, string>("username", userName.Text));
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://188.226.168.226/api/forgot.php", content);
            var responseString = await response.Content.ReadAsStringAsync();
            SetProgress(false);
            if (response.StatusCode.ToString() == "OK")
            {
                MessageBox.Show("New password was sent to your mail");
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }
        }
        public void SetProgress(bool value)
        {
            if (SystemTray.ProgressIndicator == null)
            {
                SystemTray.ProgressIndicator = new ProgressIndicator();
                SystemTray.ProgressIndicator.Text = "changing password";
            }

            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }
    }
}