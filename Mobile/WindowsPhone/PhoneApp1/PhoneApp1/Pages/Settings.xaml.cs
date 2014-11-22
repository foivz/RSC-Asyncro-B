using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace PhoneApp1
{
    public partial class Settings : PhoneApplicationPage
    {
        public static bool pushNotifications = false;
        public static bool alarmMessaging = false;
        public static bool locationUsage = false;
        public Settings()
        {
            InitializeComponent();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton saveBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/camera.png", UriKind.Relative));
            saveBtn.Text = "save";
            saveBtn.Click += save_Click;
            ApplicationBar.Buttons.Add(saveBtn);
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (pushNotification.IsChecked == true)
            {
                pushNotifications = true;
            }
            if (alarmCheckBox.IsChecked == true)
            {
                alarmMessaging = true;
            }
            if (location.IsChecked == true)
            {
                locationUsage = true;
            }
        }
    }
}