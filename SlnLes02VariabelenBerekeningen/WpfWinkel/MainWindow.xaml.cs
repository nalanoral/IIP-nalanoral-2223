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
        const double PRIJSBANAAN = 2.20;
        const double PRIJSBOTER = 3.05;
        const double PRIJSEIEREN = 2.75;
        int aantalBananen;
        int aantalBoter;
        int aantalEieren;

        string prijsboter = PRIJSBOTER.ToString("0.00");
        string prijsbanaan = PRIJSBANAAN.ToString("0.00");
        string prijseieren = PRIJSEIEREN.ToString("0.00");

        double totalPrijs;
      
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
            lblBananaPrijs.Content = PRIJSBANAAN.ToString("0.00");
            lblBoterPrijs.Content = PRIJSEIEREN.ToString("0.00");
            lblEirenPrijs.Content = PRIJSEIEREN.ToString("0.00");

        }

        private void BtnBananen_Click(object sender, RoutedEventArgs e)
        {
            lblBananen.Content = aantalBananen - 1;
            lstboxVerkocht.Items.Add($"{PRIJSBANAAN} - 1 pak banaan");
            totalPrijs += 2.20;

        }

        private void BtnBoter_Click(object sender, RoutedEventArgs e)
        { 
            lblBoter.Content = aantalBoter - 1;
            lstboxVerkocht.Items.Add($"{PRIJSBOTER} - 1 pak boter");
            totalPrijs += 3.05;

        }

        private void BtnEiren_Click(object sender, RoutedEventArgs e)
        {
            lblEiren.Content = aantalEieren - 1;
            lstboxVerkocht.Items.Add($"{PRIJSEIEREN} - 1 pak boter");
            totalPrijs += 2.75;
        }

        private void BtnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            BtnAfrekenen.IsEnabled = true;
            double som = totalPrijs;
            LblSom.Content = $"{Math.Round(som, 2)} euro";

        }

        private void BtnHerstel_Click(object sender, RoutedEventArgs e)
        {
            lstboxVerkocht.Items.Clear();
            lblBananen.Content = "";
            lblBoter.Content = "";
            lblEiren.Content = "";

        }
    }
}
