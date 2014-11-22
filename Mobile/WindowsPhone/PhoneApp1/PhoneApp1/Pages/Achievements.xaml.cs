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
using System.Windows.Media.Imaging;

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
            nazivKorisnika.Text = accountInfo.Username;
            
            if (accountInfo.Username!= "")
            {
                int rating = getRating();
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
        }

        private int getRating()
        {
            return 4;
        }
    }
}