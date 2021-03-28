using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeFiExplore
{
    /// <summary>
    /// Interaction logic for Chart.xaml
    /// </summary>
    public partial class Chart : UserControl, INotifyPropertyChanged
    {
        private string[] _labels;
        public Chart()
        {
            InitializeComponent();
            var listKlines = Kline.getKlines();
            
            ChartValues<OhlcPoint> data = new ChartValues<OhlcPoint>();
            string[] array = new string[listKlines.Count];
            int counter = 0;
            foreach (var point in listKlines)
            {
                
                data.Add(new OhlcPoint(point.Open, point.High, point.Low, point.Close));
                array[counter] = point.OpenTime.ToShortDateString();
                counter++;
            }
            
            
            
            SeriesCollection = new SeriesCollection
            {
                new CandleSeries
                {
                    Values = data
                   
                }
            };
            Labels = array;
           
            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }

        public string[] Labels
        {
            get { return _labels; }
            set
            {
                _labels = value;
                OnPropertyChanged("Labels");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
    }
}
