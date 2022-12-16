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

namespace WpfEllipsen__3_
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

        private void BtnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            // variabelen
            int maxCirkels = Convert.ToInt32(sldCirkels.Value);
            int maxRadius = Convert.ToInt32(sldMaxRadius.Value);
            int minRadius = Convert.ToInt32(sldMinRadius.Value);

            if (sldMaxRadius.Value < sldMinRadius.Value)
            {
                lblError.Content = "De minimum straal mag niet groter zijn dan de maximum straal";
                lblError.Foreground = Brushes.Red;
            }
            else
            {
                lblError.Content = "";
                lblError.Foreground = Brushes.Black;
                for (int i = 0; i < maxCirkels; i++)
                {
                    Ellipse newEllipse = new Ellipse();

                    // geef de random getallen voor de waardes
                    int width = rnd.Next(minRadius, maxRadius);
                    int height = rnd.Next(minRadius, maxRadius);
                    int red = rnd.Next(0, 255);
                    int green = rnd.Next(0, 255);
                    int blue = rnd.Next(0, 255);
                    double xPos = rnd.Next(0, 700);
                    double yPos = rnd.Next(0, 255);

                    // maak de ellipsen met rnd waardes
                    newEllipse.Width = width;
                    newEllipse.Height = height;
                    newEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
                    newEllipse.SetValue(Canvas.LeftProperty, xPos);
                    newEllipse.SetValue(Canvas.TopProperty, yPos);
                    canvas1.Children.Add(newEllipse);
                }
            }
        }
        private void SldCirkels_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblcirkels.Content = sldCirkels.Value;
        }

        private void SldMinRadius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMinRadius.Content = sldMinRadius.Value;
        }

        private void SldMaxRadius_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMaxRadius.Content = sldMaxRadius.Value;
        }
    }
}
