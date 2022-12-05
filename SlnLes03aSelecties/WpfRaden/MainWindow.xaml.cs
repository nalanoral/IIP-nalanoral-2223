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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int raad;
        int pogingenOver = 3;

        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            raad = rnd.Next(1, 10);
        }

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver--;
            int gok = Convert.ToInt32(txtbxGok.Text);

            // Als de gegokte getal groter  dan de geraden getal 
            if (gok > raad)
            {
                lblResultaat.Content = $"Te hoog ! Je beht nog {pogingenOver} pogingen over";
                btnControleer.IsEnabled = false;    
            }

            // Als de gegokte getal kleiner  dan de geraden getal 
            else if (gok < raad)
            {
                lblResultaat.Content = $"Te laag ! Je beht nog {pogingenOver} pogingen over";
            }

            // Anders is het gegokte getal juist 
            else
            {
                lblResultaat.Content = $"Je hebt gewonnen !!!";
                btnControleer.IsEnabled = false;
            }

            // Als de gok en radend getal gelijk zijn en de pogingen over zijn
            if (gok == raad && pogingenOver == 0)
            {
                lblResultaat.Content = "Je hebt gewonnen !!!";
                btnControleer.IsEnabled = false;
            }
            else if (pogingenOver == 0)
            {
                lblResultaat.Content = "Je hebt geen pogingen meer ! Herstart het programma om te spelen";

                // Als de drie pogingen gebruikt zijn dan kan je de button niet meer gebruiken
                btnControleer.IsEnabled = false;
            }
        }
        private void btnHerstel_Click(object sender, RoutedEventArgs e)
        {
            lblResultaat.Content = "";
            btnControleer.IsEnabled = false;
            txtbxGok.Text = "";
        }
    }
}
