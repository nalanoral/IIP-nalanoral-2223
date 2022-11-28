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

namespace WpfWinkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aantalBananen;
        int aantalBoter;
        int aantalEieren;
        double totalPrijs;
        const double PRIJS_BANAAN = 2.20;
        const double PRIJS_BOTER = 3.05;
        const double PRIJS_EIEREN = 2.75;


        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();
            aantalBananen = rnd.Next(5, 40);
            aantalBoter = rnd.Next(5, 40);
            aantalEieren = rnd.Next(5, 40);
            lblBananen.Content = aantalBananen + "over";
            lblBoter.Content = aantalBoter + "over";
            lblEiren.Content = aantalEieren + "over";

        }

        private void btnBananen_Click(object sender, RoutedEventArgs e)
        {   
            lblBananen.Content = aantalBananen - 1;
            lstboxVerkocht.Items.Add($"{PRIJS_BANAAN} - 1 pak banaan");
            totalPrijs += 2.20;

        }

        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {
            lblBoter.Content = aantalBoter - 1;
            lstboxVerkocht.Items.Add($"{PRIJS_BOTER} - 1 pak boter");
            totalPrijs += 3.05;

        }

        private void btnEiren_Click(object sender, RoutedEventArgs e)
        {
            lblEiren.Content = aantalEieren - 1;
            lstboxVerkocht.Items.Add($"{PRIJS_EIEREN} - 1 pak boter");
            totalPrijs += 2.75;
        }

        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnHerstel_Click(object sender, RoutedEventArgs e)
        {
            lstboxVerkocht.Items.Clear();
            lblBananen.Content = "";
            lblBoter.Content = "";
            lblEiren.Content = "";

        }
    }
}
