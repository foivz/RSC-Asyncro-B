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
    public partial class Donor : PhoneApplicationPage
    {
        public Donor()
        {
            InitializeComponent();
            postaviSucelje();
        }
        private void postaviSucelje()
        {
            List<donorControl> donori = new List<donorControl>();
            for (int i = 0; i < 4; i++)
            {
                donorControl d = new donorControl();
                d.adresa.Text = "testna adresa";
                d.stanjeKrvi.Text = i.ToString();
                donori.Add(d);
            }
            foreach (donorControl don in donori)
            {
                stackPanel.Children.Add(don);
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            ocisti();
        }
        private void ocisti()
        {
            stackPanel.Children.Clear();
        }
    }
    
}