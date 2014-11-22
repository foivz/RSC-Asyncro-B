using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace PhoneApp1
{
    public partial class Achievements : PhoneApplicationPage
    {
        public Achievements()
        {
            InitializeComponent();
            postaviSucelje();
        }
        private void postaviSucelje()
        {
            nazivKorisnika.Text = accountInfo.Name + " " + accountInfo.Surname;
            
            if (accountInfo.Username!= "")
            {
                
            }
        }
    }
}