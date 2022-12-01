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

namespace WpfAlcohol
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

        private void sldBier_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //Text voor  hoeveelheid glazen 
            txtBier.Text = sldBier.Value + " glazen";

            //Alle sliders samen optellen 
            rctAlcoholGehalte.Width = Math.Round(sldBier.Value * 17) + Math.Round(sldWijn.Value * 17) + Math.Round(sldSterkeDrank.Value * 17);

            //Na hoeveel glazen gaat het van groen naar rood
            int rood = Convert.ToInt32(rctAlcoholGehalte.Width);
            int groen = 255 - rood;
            int blauw = 0;

            //Aanmaken van de kleuren
            rctAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb((byte)rood, (byte)groen, (byte)blauw));

        }

        private void sldSterkeDrank_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtSterkeDrank.Text = sldSterkeDrank.Value + " glazen";
            //Text voor  hoeveelheid glazen 
            txtBier.Text = sldBier.Value + " glazen";

            //Alle sliders samen optellen 
            rctAlcoholGehalte.Width = Math.Round(sldBier.Value * 17) + Math.Round(sldWijn.Value * 17) + Math.Round(sldSterkeDrank.Value * 17);

            //Na hoeveel glazen gaat het van groen naar rood
            int rood = Convert.ToInt32(rctAlcoholGehalte.Width);
            int groen = 255 - rood;
            int blauw = 0;

            //Aanmaken van de kleuren
            rctAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb((byte)rood, (byte)groen, (byte)blauw));
        }

        private void sldWijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtWijn.Text = sldWijn.Value + " glazen";
            //Text voor  hoeveelheid glazen 
            txtBier.Text = sldBier.Value + " glazen";

            //Alle sliders samen optellen 
            rctAlcoholGehalte.Width = Math.Round(sldBier.Value * 17) + Math.Round(sldWijn.Value * 17) + Math.Round(sldSterkeDrank.Value * 17);

            //Na hoeveel glazen gaat het van groen naar rood
            int rood = Convert.ToInt32(rctAlcoholGehalte.Width);
            int groen = 255 - rood;
            int blauw = 0;

            //Aanmaken van de kleuren
            rctAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb((byte)rood, (byte)groen, (byte)blauw));
        }
    }
}
