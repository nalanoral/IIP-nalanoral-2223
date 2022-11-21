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

namespace WpfPizza
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

       
        private void rbn1_Checked(object sender, RoutedEventArgs e)
        {
            lblDescription.Content = "Tomatensaous, mozzarella & oregano ";
            imgPhoto.Source = new BitmapImage(new Uri("Images/spicy.jpg" ,UriKind.Relative));

        }

        private void rbn2_Checked(object sender, RoutedEventArgs e)
        {
            lblDescription.Content = "Tomatensaous, mozzarella , rode ui, " + Environment.NewLine + "paprika, pepperon & spaanse pepers.";
            imgPhoto.Source = new BitmapImage(new Uri("Images/4seizon.jpg", UriKind.Relative));
        }

        private void rbn3_Checked(object sender, RoutedEventArgs e)
        {

            lblDescription.Content = "Tomatensaous, mozzarella , rode ui,kip " + Environment.NewLine + "paprika, pepperon & spaanse pepers.";
            imgPhoto.Source = new BitmapImage(new Uri("Images/hawai.jpg", UriKind.Relative));
        }
    }
}
