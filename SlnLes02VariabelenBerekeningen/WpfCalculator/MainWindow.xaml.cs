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

namespace WpfCalculator
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
        private void btnEen_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "1";
        }

        private void btnTwee_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "2";
        }

        private void btnDrie_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "3";
        }

        private void btnVier_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "4";
        }

        private void btnVijf_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "5";
        }

        private void btnZes_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "6";
        }

        private void btnZeven_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "7";
        }

        private void btnAcht_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "8";
        }

        private void btnNegen_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "9";
        }

        private void btnNul_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + "0";
        }

        private void btnKomma_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + ".";
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Clear();
            lblUitkomst.Content = "0.0";
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            // random getal genereren als invoer
            Random random = new Random();
            txtBxInvoeg.Text = Convert.ToString(random.Next(0, 9));
        }

        private void btnOptellen_Click(object sender, RoutedEventArgs e)
        {
            // optelling
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = uitkomst + invoeg;
        }

        private void btnAftrekken_Click(object sender, RoutedEventArgs e)
        {
            // aftrekking
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = uitkomst - invoeg;
        }

        private void btnVermenigvuldigen_Click(object sender, RoutedEventArgs e)
        {
            // vermenigvuldiging
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = uitkomst * invoeg;
        }

        private void btnDelen_Click(object sender, RoutedEventArgs e)
        {
            // deling
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = uitkomst / invoeg;  
        }

        private void btnVierkantswortel_Click(object sender, RoutedEventArgs e)
        {
            //sqrt = worte
            // vierkantswortel
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = Math.Sqrt(invoeg);

        }

        private void btnKwadraat_Click(object sender, RoutedEventArgs e)
        {
            // sqr = kwadraat
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = Math.Pow(invoeg, 2);
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            //sin formule
            double invoeg = Convert.ToDouble(txtBxInvoeg.Text);
            double uitkomst = Convert.ToDouble(lblUitkomst.Content);
            txtBxInvoeg.Text = "";
            lblUitkomst.Content = Math.Sin(invoeg);
        }
    }
}
