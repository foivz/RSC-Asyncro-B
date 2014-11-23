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
                else
                {
                    HttpClient client = new HttpClient();
                    var values = new List<KeyValuePair<string, string>>();
                    values.Add(new KeyValuePair<string, string>("username", korIme.Text));
                    values.Add(new KeyValuePair<string, string>("password", lozinka.Password));
                    values.Add(new KeyValuePair<string, string>("email", mail.Text));
                    values.Add(new KeyValuePair<string, string>("name", naziv.Text));
                    values.Add(new KeyValuePair<string, string>("surname", prezime.Text));
                    var content = new FormUrlEncodedContent(values);
                    var response = await client.PostAsync("http://188.226.168.226/api/update_user.php", content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (responseString == "1")
                    {
                        MessageBox.Show("Updated successfully");
                        SetProgress(false);
                        NavigationService.Navigate(new Uri("/Pages/registriraniKorisnik.xaml", UriKind.Relative));
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
                if (lozinka.Password == ponovanUnos.Password)
                {
                
                        if (korIme.Text == "" || lozinka.Password == "" || mail.Text == "" || naziv.Text == "" || prezime.Text == "")
                        {
                            MessageBox.Show("Please fill all inputs");
                        }
                        else
                        {

                            SetProgress(true);
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
                SystemTray.ProgressIndicator.Text = "registering";
            }

            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }
    }
}