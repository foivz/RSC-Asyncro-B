using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;

namespace PhoneApp1
{
    public partial class Statistics : PhoneApplicationPage
    {
        public static int moje;
        public static int ukupno;
        public static int ostalo;
        public Statistics()
        {
            InitializeComponent();
            postaviGrafove();
        }

        public async void postaviGrafove()
        {
            HttpClient client = new HttpClient();
            var result = await client.GetAsync("http://188.226.168.226/api/achivement.php/");
            string content = await result.Content.ReadAsStringAsync();
            List<achievements> data = JsonConvert.DeserializeObject<List<achievements>>(content);
            int brojac = 0;
            int suma = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].username == accountInfo.Username)
                    brojac = int.Parse(data[i].donations);
                suma += int.Parse(data[i].donations);
            }
            moje = brojac;
            ukupno = suma;
            ostalo = ukupno-moje;

            PieChart.Visibility = Visibility.Visible;
            PieChart.DataSource = Data;

            LineChart.DataSource = lineData;
        }

        public ObservableCollection<PData> Data = new ObservableCollection<PData>()
        {
            new PData() { title = "Moje donacije", value = moje },
            new PData() { title = "Ukupno donacija", value = ostalo },
        };

        public ObservableCollection<LineData> lineData = new ObservableCollection<LineData>()
        {
            new LineData() { Category = "Moje donacije", Line1 = moje},
            new LineData() { Category = "Ukupno donacija", Line1 = ostalo},
        };

        public class PData
        {
            public string title { get; set; }
            public double value { get; set; }
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            //PieChart.DataSource = Data;
            //LineChart.DataSource = lineData;
        }

        public class LineData
        {
            public string Category { get; set; }
            public double Line1 { get; set; }
        }
    }
}