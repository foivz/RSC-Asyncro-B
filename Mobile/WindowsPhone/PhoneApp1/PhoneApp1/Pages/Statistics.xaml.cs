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

namespace PhoneApp1
{
    public partial class Statistics : PhoneApplicationPage
    {
        public Statistics()
        {
            InitializeComponent();
            postaviGrafove();
        }

        public void postaviGrafove()
        {

        }

        public ObservableCollection<PData> Data = new ObservableCollection<PData>()
        {
            new PData() { title = "slice #1", value = 30 },
            new PData() { title = "slice #2", value = 60 },
            new PData() { title = "slice #3", value = 40 },
            new PData() { title = "slice #4", value = 10 },
        };

        

        public class PData
        {
            public string title { get; set; }
            public double value { get; set; }
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            PieChart.DataSource = Data;
        }
    }
}