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

namespace DemoWpfRandom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // variabelen
        Random rnd = new Random();
        int vorigRandomGetal = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gebruiker klikt op "Genereer" knop
        /// </summary>
        private void btnGenereer_Click(object sender, RoutedEventArgs e)
        {
            // genereer nieuw getal
            int randomGetal = rnd.Next(1, 20);

            // toon bericht
            string bericht = randomGetal + $" (vorig random getal: {vorigRandomGetal})";
            lblMessage.Content = bericht;

            // onthoud random getal
            vorigRandomGetal = randomGetal;
        }
    }
}
