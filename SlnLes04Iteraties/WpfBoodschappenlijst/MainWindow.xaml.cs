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

namespace WpfBoodschappenlijst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string boodschappenlijst;
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void lbxBoodschappen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < lbxBoodschappen.Items.Count; i++)
            {
                ListBoxItem selectedItem = (ListBoxItem)lbxBoodschappen.Items.GetItemAt(i);
                if (selectedItem.IsEnabled == true)
                {
                    boodschappenlijst += " " + Convert.ToString(selectedItem.Content);
                }

            }
            lblBoodschappenlijst.Content = $"Je selecteerde: {boodschappenlijst}";


            // notatie voor me zelf => controller nog een keer //

        }
    }
}
