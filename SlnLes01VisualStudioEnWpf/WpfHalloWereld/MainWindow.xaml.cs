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

namespace WpfHalloWereld
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

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
           lblName.Content= "Hallo "+txtName.Text;
        }

        private void btnHerstel_Click(object sender, RoutedEventArgs e)
        {
            lblName.Content = "Hallo, hoe is je naam? ";
            txtName.Text = "";

        }

        private void btnOk_MouseEnter(object sender, MouseEventArgs e)
        {
            btnOk.Background = Brushes.AliceBlue;
        }

        private void btnOk_MouseLeave(object sender, MouseEventArgs e)
        {
            btnOk.Background = Brushes.LightGray;
        }

        private void btnHerstel_MouseEnter(object sender, MouseEventArgs e)
        {
            btnOk.Background = Brushes.AliceBlue;
        }

        private void btnHerstel_MouseLeave(object sender, MouseEventArgs e)
        {
            btnOk.Background = Brushes.LightGray;
        }
    }
}
