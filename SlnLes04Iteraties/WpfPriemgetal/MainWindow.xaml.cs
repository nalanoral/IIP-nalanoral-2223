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

namespace WpfPriemgetal
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

        private void BtnCtrl_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);
            int deler = getal / 2;
            int counter = 0;

            //delers opzoeken
            for (int i = 2; i <= deler; i++)
            {
                if (getal % i == 0)
                {
                    counter++;
                    lblResultaat.Foreground = new SolidColorBrush(Colors.Red);
                    lblResultaat.Content = $"{getal} is geen priemgetal";
                }
                else
                {
                    lblResultaat.Foreground = new SolidColorBrush(Colors.Green);
                    lblResultaat.Content = $"{getal} is een priemgetal";
                }
            }
        }
    }
}
