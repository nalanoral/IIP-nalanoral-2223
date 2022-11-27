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

namespace WpfBMI
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

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double getalcm = Convert.ToDouble(txtbxCM.Text);
            double getalkg = Convert.ToDouble(txtbxKg.Text);
            double BMI = getalkg / (getalcm / 100 * getalcm / 100);
            LblBMI.Content = "BMI :" + Math.Round(BMI, 1);
        }
    }
}
