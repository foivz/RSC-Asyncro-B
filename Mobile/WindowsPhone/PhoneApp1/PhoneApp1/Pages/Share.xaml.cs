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
    public partial class Share : PhoneApplicationPage
    {
        public Share()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton shareBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/camera.png", UriKind.Relative));
            shareBtn.Text = "share";
            shareBtn.Click += shareClick;
            ApplicationBar.Buttons.Add(shareBtn);
        }
        private void shareClick(object sender, EventArgs e)
        {
            if (facebook.IsChecked == true)
            {
                
            }
            if (twitter.IsChecked == true)
            {
                
            }
        }
    }

}