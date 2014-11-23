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
using System.Net.Http;
using Newtonsoft.Json;

namespace PhoneApp1
{
    public partial class Achievements : PhoneApplicationPage
    {
        public Achievements()
        {
            InitializeComponent();
            postaviSucelje();
        }
        private async void postaviSucelje()
        {
            nazivKorisnika.Text = accountInfo.Name + " " + accountInfo.Surname;
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("http://188.226.168.226/api/achivement.php/");
            string content = await result.Content.ReadAsStringAsync();
            List<achievements> data = JsonConvert.DeserializeObject<List<achievements>>(content);
            int brojac = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].username == accountInfo.Username)
                    brojac = int.Parse(data[i].donations);
            }
            if (brojac >= 15)
            {
                Description.Text = "You are one of our top doners. Thanks!";
                int rating = getRating(5);
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
            if (brojac >= 10 && brojac < 15)
            {
                Description.Text = "Thanks for donating blood";
                int rating = getRating(4);
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
            if (brojac >= 5 && brojac < 10)
            {
                Description.Text = "You are to kind. Thanks!";
                int rating = getRating(3);
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
            if(brojac >= 3 && brojac < 5)
            {
                Description.Text = "Now you have some experience. Come again and donate more!";
                int rating = getRating(2);
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
            if (brojac > 0 && brojac < 3)
            {
                Description.Text = "You have one donation! Keep it up!";
                int rating = getRating(1);
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
            if (brojac == 0)
            {
                Description.Text = "We are sorry that you didin't donate blood yet";
                int rating = getRating(0);
                BitmapImage bm = new BitmapImage(new Uri(@"/Assets/Icons/FavoritesStar.png", UriKind.RelativeOrAbsolute));
                BitmapImage bm_star = new BitmapImage(new Uri(@"/Assets/Icons/Favorites.png", UriKind.RelativeOrAbsolute));
                star1.Source = rating >= 1 ? bm : bm_star;
                star2.Source = rating >= 2 ? bm : bm_star;
                star3.Source = rating >= 3 ? bm : bm_star;
                star4.Source = rating >= 4 ? bm : bm_star;
                star5.Source = rating >= 5 ? bm : bm_star;
            }
                
        }

        private int getRating(int vracanje)
        {
            return vracanje;
        }
    }
}