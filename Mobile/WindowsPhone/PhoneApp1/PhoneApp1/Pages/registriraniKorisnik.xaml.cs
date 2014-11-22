using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PhoneApp1
{
    public partial class registriraniKorisnik : PhoneApplicationPage
    {
        public registriraniKorisnik()
        {
            InitializeComponent();
            postaviSucelje();
            BuildLocalizedApplicationBar();
        }

        private void BuildLocalizedApplicationBar()
        {
            //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();
            ApplicationBarMenuItem settingsBtn = new ApplicationBarMenuItem("Settings");
            settingsBtn.Click += settingsPage;
            ApplicationBar.MenuItems.Add(settingsBtn);
        }
        private void settingsPage(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Settings.xaml", UriKind.Relative));
        }
        private void postaviSucelje()
        {
            string[] imena = { "Personal data", "Achievements" ,"Donor info", "Statistics", "Share","About" };
            string[] slike = { "/Assets/Icons/Data-Settings.png", "/Assets/Icons/Certificate-01.png", "/Assets/Icons/Heart-ECG.png", "/Assets/Icons/Graph-02.png", "/Assets/Icons/Share-03.png", "/Assets/Icons/Dialog-Box-About.png" };

            List<twoLevelControl> Grids = new List<twoLevelControl>();
            for (int i = 0; i < 6; i++)
            {
                if (i % 2 == 0)
                {
                    twoLevelControl grid = new twoLevelControl();
                    Grids.Add(grid);
                    Uri uri = new Uri(slike[i], UriKind.Relative);
                    ImageSource imgSource = new BitmapImage(uri);
                    grid.Level1Image.Source = imgSource;
                    grid.Level1Name.Text = imena[i];
                    grid.LevelGrid1.Tap += LevelGrid1_Tap;
                }

                else
                {
                    twoLevelControl grid = Grids.Last();
                    Uri uri = new Uri(slike[i], UriKind.Relative);
                    ImageSource imgSource = new BitmapImage(uri);
                    grid.Level2Image.Source = imgSource;
                    grid.Level2Name.Text = imena[i];
                    grid.LevelGrid2.Tap += LevelGrid2_Tap;

                }
            }
            foreach (twoLevelControl grid in Grids)
            {
                stackPanel.Children.Add(grid);
            }
 
        }
        void LevelGrid1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            GridTap((Grid)sender);
        }
        void LevelGrid2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            GridTap((Grid)sender);
        }
        private void GridTap(Grid grid)
        {
            //trebam dobiti sto je korisnik kliknia
            TextBlock LevelName = (TextBlock)grid.Children[0];
            string ime = LevelName.Text;
            //korisnik
            if (String.Compare("Personal data", ime) == 0)
            {
                NavigationService.Navigate(new Uri("/userForm.xaml", UriKind.Relative));
            }
            else if (String.Compare("Achievements", ime) == 0)
            {

            }
            else if (String.Compare("Donor info", ime) == 0)
            {
                //NavigationService.Navigate(new Uri("/searchModule.xaml", UriKind.Relative));
            }
            else if (String.Compare("Statistics", ime) == 0)
            {
                //NavigationService.Navigate(new Uri("/kosara.xaml", UriKind.Relative));
            }
            else if (String.Compare("Share", ime) == 0)
            {

            }
            else if (String.Compare("About", ime) == 0)
            {

            }
        }
    }
}