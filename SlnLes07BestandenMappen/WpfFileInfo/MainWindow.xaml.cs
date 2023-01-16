using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfFileInfo
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

        private void btnKies_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.Filter = "Tekstbestanden|.TXT;.TEXT";

            bool? dialogResult = dialog.ShowDialog();

            if (dialogResult == true)
            {
                string chosenFileName;
                chosenFileName = dialog.FileName;

                // doe filtering voor krakters hier//


                FileInfo fi = new FileInfo(chosenFileName);
                lblInfo.Content += $"bestandsnaam: {fi.Name}{Environment.NewLine}";
                lblInfo.Content += $"extensie: {fi.Extension}{Environment.NewLine}";
                lblInfo.Content += $"gemaakt op: {fi.CreationTime.ToString()}{Environment.NewLine}";
                lblInfo.Content += $"mapnaam: {fi.Directory.Name}{Environment.NewLine}";
            }

            else
            {
                // user cancelled or escaped dialog window
                lblInfo.Content = "geen bestand gekozen";
            }
        }
    }
}
