using System;
using System.Collections.Generic;
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

namespace DemoWpfSliderRectangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sliderVal = Convert.ToInt32(Math.Round(sld1.Value));
            lblValue.Content = sliderVal;
            rct1.Width = sliderVal;
            //byte red = Convert.ToByte(sliderVal);
            //byte green = Convert.ToByte(255 - sliderVal);
            //rct1.Fill = new SolidColorBrush(Color.FromRgb(red, green, 0));
        }
    }
}
