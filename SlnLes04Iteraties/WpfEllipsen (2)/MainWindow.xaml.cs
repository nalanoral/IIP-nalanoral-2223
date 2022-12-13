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

namespace WpfEllipsen__2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // globale variabelen
        const int MAX_AANTAL_ELLIPSEN = 50;
        const int MAX_RADIUS = 150;
        const int MIN_RADIUS = 60;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTekenen_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            // tot de max ellipsen
            for (int i = 0; i < MAX_AANTAL_ELLIPSEN; i++)
            {
                Ellipse newEllipse = new Ellipse();

                // geef de random getallen voor de waardes
                int width = rnd.Next(MIN_RADIUS, MAX_RADIUS);
                int height = rnd.Next(MIN_RADIUS, MAX_RADIUS);
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
}

