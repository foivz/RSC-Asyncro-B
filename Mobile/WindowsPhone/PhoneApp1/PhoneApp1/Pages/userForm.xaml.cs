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

namespace PhoneApp1
{
    public partial class userForm : PhoneApplicationPage
    {
        public userForm()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton acceptBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/Check.png", UriKind.Relative));
            acceptBtn.Text = "accept";
            acceptBtn.Click += accept;
            ApplicationBar.Buttons.Add(acceptBtn);
        }
        private async void accept(object sender, EventArgs e)
        {
            if (lozinka.Password == ponovanUnos.Password)
            {
                HttpClient client = new HttpClient();
                var values = new List<KeyValuePair<string, string>>();
                values.Add(new KeyValuePair<string, string>("username", korIme.Text));
                values.Add(new KeyValuePair<string, string>("password", lozinka.Password));
                values.Add(new KeyValuePair<string, string>("email", mail.Text));
                values.Add(new KeyValuePair<string, string>("name", naziv.Text));
                values.Add(new KeyValuePair<string, string>("surname", prezime.Text));
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("http://188.226.168.226/api/register.php", content);
                var responseString = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseString);

                
            }
            else
            {
                MessageBox.Show("Password do not mach!");
            }
        }
    }
}