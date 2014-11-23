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
    public partial class donation : PhoneApplicationPage
    {
        public donation()
        {
            InitializeComponent();
            postaviSadrzaj();
            BuildLocalizedApplicationBar();
        }
        private void postaviSadrzaj()
        {
            korisnik.Text = accountInfo.Name + " " + accountInfo.Surname;
            institution.Text = institucija.institution;
            usrnme.Text = accountInfo.Username;
            mail.Text = accountInfo.mail;
            bldtype.Text = accountInfo.id.ToString();
            DateTime date = DateTime.Now;
            dateTime.Text = date.ToString();

        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton arrangeBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/Check.png", UriKind.Relative));
            arrangeBtn.Text = "arrange";
            arrangeBtn.Click += arrangeDonating;
            ApplicationBar.Buttons.Add(arrangeBtn);
        }
        private async void arrangeDonating(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("username", usrnme.Text));
            values.Add(new KeyValuePair<string, string>("email", mail.Text));
            values.Add(new KeyValuePair<string, string>("blood_type", bldtype.Text));
            values.Add(new KeyValuePair<string, string>("date", dateTime.Text));
            values.Add(new KeyValuePair<string, string>("institution", institution.Text));
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://188.226.168.226/api/donate.php", content);
            string responseString = await response.Content.ReadAsStringAsync();
            if (responseString == "1")
            {
                MessageBox.Show("Thanks for donating!");
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again!");
            }

        }
    }
}