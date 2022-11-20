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

namespace DemoWpfComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbxCountries.SelectedIndex = 1; // begin te tellen vanaf 0, dus index 1 = tweede item
            ComboBoxItem newItem = new ComboBoxItem();
            newItem.Content = "Spanje";
            cbxCountries.Items.Add(newItem);
        }

        private void cbxCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)cbxCountries.SelectedItem;
            lblMessage.Content = "geselecteerd: " + selectedItem.Content;
        }
    }
}
