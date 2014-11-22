using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

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
        private void send(object sender, EventArgs e)
        {

        }
    }
}