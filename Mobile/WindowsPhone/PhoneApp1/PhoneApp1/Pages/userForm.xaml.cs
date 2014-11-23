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
using Newtonsoft.Json;

namespace PhoneApp1
{
    public partial class userForm : PhoneApplicationPage
    {
        public userForm()
        {
            InitializeComponent();
            if (accountInfo.Username != "")
            {
                pageName.Text = "Personal details";
                dohvatiSadrzaj();
            }
            else
            {
                pageName.Text = "Create account";
            }
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
            if (accountInfo.Username != "")
            {
                if (korIme.Text == "" || lozinka.Password == "" || mail.Text == "" || naziv.Text == "" || prezime.Text == "")
                {
                    MessageBox.Show("Please fill all inputs");
                }
                if (bloodGroup.Text != "A+" || bloodGroup.Text != "A-" || bloodGroup.Text != "B+" || bloodGroup.Text != "B-" || bloodGroup.Text != "AB+" || bloodGroup.Text != "AB-" || bloodGroup.Text != "0+" || bloodGroup.Text != "0-")
                {
                    MessageBox.Show("Blood type does not exist!");
                }
                else
                {
                    HttpClient client = new HttpClient();
                    SetProgress(true);
                    int krvnaGrupa = 0;
                    if (bloodGroup.Text != "A+") krvnaGrupa = 1;
                    if (bloodGroup.Text != "A-") krvnaGrupa = 2;
                    if (bloodGroup.Text != "B+") krvnaGrupa = 3;
                    if (bloodGroup.Text != "B-") krvnaGrupa = 4;
                    if (bloodGroup.Text != "AB+") krvnaGrupa = 5;
                    if (bloodGroup.Text != "AB-") krvnaGrupa = 6;
                    if (bloodGroup.Text != "0+") krvnaGrupa = 7;
                    if (bloodGroup.Text != "0-") krvnaGrupa = 8;
                    var values = new List<KeyValuePair<string, string>>();
                    values.Add(new KeyValuePair<string, string>("username", korIme.Text));
                    values.Add(new KeyValuePair<string, string>("password", lozinka.Password));
                    values.Add(new KeyValuePair<string, string>("email", mail.Text));
                    values.Add(new KeyValuePair<string, string>("name", naziv.Text));
                    values.Add(new KeyValuePair<string, string>("surname", prezime.Text));
                    values.Add(new KeyValuePair<string, string>("bloodType", krvnaGrupa.ToString()));
                    var content = new FormUrlEncodedContent(values);
                    var response = await client.PostAsync("http://188.226.168.226/api/update_user.php", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (responseString == "1")
                    {
                        SetProgress(false);
                        MessageBox.Show("Updated successfully");
                        SetProgress(false);
                        NavigationService.Navigate(new Uri("/Pages/registriraniKorisnik.xaml", UriKind.Relative));
                    }
                    else
                    {
                        SetProgress(false);
                        MessageBox.Show("Some error ccurred! Please try again");
                        SetProgress(false);
                    }
                    SetProgress(false);
                }

            }
            else
            {
                if (lozinka.Password == ponovanUnos.Password)
                {
                
                        if (korIme.Text == "" || lozinka.Password == "" || mail.Text == "" || naziv.Text == "" || prezime.Text == "")
                        {
                            MessageBox.Show("Please fill all inputs");
                        }
                        if (bloodGroup.Text != "A+" || bloodGroup.Text != "A-" || bloodGroup.Text != "B+" || bloodGroup.Text != "B-" || bloodGroup.Text != "AB+" || bloodGroup.Text != "AB-" || bloodGroup.Text != "0+" || bloodGroup.Text != "0-")
                        {
                            MessageBox.Show("Blood type does not exist!");
                        }
                        else
                        {

                            SetProgress(true);
                            int krvnaGrupa = 0;
                            if (bloodGroup.Text != "A+") krvnaGrupa = 1;
                            if (bloodGroup.Text != "A-") krvnaGrupa = 2;
                            if (bloodGroup.Text != "B+") krvnaGrupa = 3;
                            if (bloodGroup.Text != "B-") krvnaGrupa = 4;
                            if (bloodGroup.Text != "AB+") krvnaGrupa = 5;
                            if (bloodGroup.Text != "AB-") krvnaGrupa = 6;
                            if (bloodGroup.Text != "0+") krvnaGrupa = 7;
                            if (bloodGroup.Text != "0-") krvnaGrupa = 8;
                            HttpClient client = new HttpClient();
                            var values = new List<KeyValuePair<string, string>>();
                            values.Add(new KeyValuePair<string, string>("username", korIme.Text));
                            values.Add(new KeyValuePair<string, string>("password", lozinka.Password));
                            values.Add(new KeyValuePair<string, string>("email", mail.Text));
                            values.Add(new KeyValuePair<string, string>("name", naziv.Text));
                            values.Add(new KeyValuePair<string, string>("surname", prezime.Text));
                            values.Add(new KeyValuePair<string, string>("bloodType", krvnaGrupa.ToString()));
                            var content = new FormUrlEncodedContent(values);
                            var response = await client.PostAsync("http://188.226.168.226/api/register.php", content);
                            var responseString = await response.Content.ReadAsStringAsync();

                            if (responseString == "1")
                            {
                                MessageBox.Show("User created successfully");
                                SetProgress(false);
                                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                            }
                            else
                            {
                                MessageBox.Show("Some error ccurred! Please try again");
                                SetProgress(false);
                            }
                        }
                
                    }
                else
                {
                    MessageBox.Show("Password do not mach!");
                }
            }
        }
        private void dohvatiSadrzaj()
        {
            korIme.Text = accountInfo.Username;
            lozinka.Password = accountInfo.Password;
            mail.Text = accountInfo.mail;
            naziv.Text = accountInfo.Name;
            prezime.Text = accountInfo.Surname;
            ponovanUnos.Visibility = Visibility.Collapsed;
        }
        public void SetProgress(bool value)
        {
            if (SystemTray.ProgressIndicator == null)
            {
                SystemTray.ProgressIndicator = new ProgressIndicator();
                SystemTray.ProgressIndicator.Text = "applying";
            }

            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }
    }
}