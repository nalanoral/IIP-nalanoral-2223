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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfOpties_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int chechk = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //CHECKBOX
            CheckBox cb = (CheckBox)sender;
            chechk++;
            if (chechk >= 1)
            {
                imgChecked.Source = new BitmapImage(new Uri("Images/checked.jpg", UriKind.Relative));
            }

            if (cb.Name != cbOther.Name)
            {
                txtOther.Visibility = Visibility.Hidden;
            }
            else
            {
                txtOther.Visibility = Visibility.Visible;
            }
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            chechk--;
            if (chechk < 1)
            {
                imgChecked.Source = new BitmapImage(new Uri("", UriKind.Relative));
            }

            CheckBox cb = (CheckBox)sender;
            if (cb.Name == cbOther.Name)

            {
                txtOther.Visibility = Visibility.Hidden;
            }
        }
    }
}

