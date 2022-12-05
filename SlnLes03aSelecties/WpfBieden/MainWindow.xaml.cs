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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoogsteBod;
        string hoogsteBieder;

        public MainWindow()
        {
            InitializeComponent();
            lblHoogsteBod.Content = "er is geen bod uitgebracht";
        }

        private void btnBod_Click(object sender, RoutedEventArgs e)
        {
            string bieder = txtbxNaam.Text;
            int bod = Convert.ToInt32(txtbxBod.Text);
            if (bod > hoogsteBod)
            {
                hoogsteBieder = bieder;
                hoogsteBod = bod;
                lblHoogsteBod.Content = $"{hoogsteBieder} heeft met {hoogsteBod} euro nu het hoogste bod ! ";
            }
            else
               lblHoogsteBod.Content = $"Sorry, {hoogsteBieder} heeft momenteel hoogste bod ";

        }
    }
}
