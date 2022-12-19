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

namespace WpfCarConfigurator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int totaalprijs;
        int modelprijs;
        int kleurprijs;
        int accessoiresprijs;
        string model;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            // juiste image hier toevoegen 

            if (chxSpeakers.IsChecked == true)
            {
                imgSpeakers.Opacity = 1;
            }
            else
            {
                imgSpeakers.Opacity = 0;
            }

            if (chxMaatjes.IsChecked == true)
            {
                imgMaatjes.Opacity = 1;
            }
            else
            {
                imgMaatjes.Opacity = 0;
            }
            if (chxVelgen.IsChecked == true)
            {
                imgVelgen.Opacity = 1;
            }
            else
            {
                imgVelgen.Opacity = 0;
            }
        }

        private void CbxModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            totaalprijs = 0;
            ComboBoxItem selectedItem = (ComboBoxItem)cbxModel.SelectedItem;
            if (cbxModel.SelectedIndex == 0)
            {
                model = "model1";
                modelprijs = 85000;
            }
            else if (cbxModel.SelectedIndex == 1)
            {
                model = "model2";
                modelprijs = 72000;
            }
            else if (cbxModel.SelectedIndex == 2)
            {
                model = "model3";
                modelprijs = 65300;
            }

        }
        private void BerekenPrijs()
        {
            totaalprijs = 0;
            totaalprijs = modelprijs + kleurprijs + accessoiresprijs;
        }

    }
}
