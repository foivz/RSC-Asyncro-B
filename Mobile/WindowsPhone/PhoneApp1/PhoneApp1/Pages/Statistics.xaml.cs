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
        }

        public ObservableCollection<PData> Data = new ObservableCollection<PData>()
        {
            new PData() { title = "Moje donacije", value = moje },
            new PData() { title = "Ukupno donacija", value = ostalo },
        };

        public ObservableCollection<LineData> lineData = new ObservableCollection<LineData>()
        {
            new LineData() { Category = "01.01.2014", Line1 = moje},
            new LineData() { Category = "23.11.2014", Line1 = ostalo},
        };

        public class PData
        {
            public string title { get; set; }
            public double value { get; set; }
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            PieChart.DataSource = Data;
            LineChart.DataSource = lineData;
        }

        public class LineData
        {
            public string Category { get; set; }
            public double Line1 { get; set; }
        }
    }
}