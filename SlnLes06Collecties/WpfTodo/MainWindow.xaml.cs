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

namespace WpfTodo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // buttons standaard disabled
            btnAdd.IsEnabled = false;
            btnDelete.IsEnabled = false;
            btnTerug.IsEnabled = false;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtTaak.Text == "" && cbxPriotiteit.SelectedIndex == 0)
            {
                btnAdd.IsEnabled = false;
            }
            else
            {
                btnAdd.IsEnabled = true;
            }
            ListBoxItem taak = (ListBoxItem)lbxTodo.SelectedItem;

            if (taak != null)
            {
                if (cbxPriotiteit.SelectedIndex == 3)
                {
                    lbxTodo.Items.Add(txtTaak.Text);
                    taak.Foreground = Brushes.Red;
                }
                else if (cbxPriotiteit.SelectedIndex == 2)
                {
                    lbxTodo.Items.Add(txtTaak.Text);
                    taak.Foreground = Brushes.Orange;
                }
                else if (cbxPriotiteit.SelectedIndex == 1)
                {
                    lbxTodo.Items.Add(txtTaak.Text);
                    taak.Foreground = Brushes.Green;
                }

                txtTaak.Text = "";
            }
        }
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            lbxTodo.Items.Remove(lbxTodo.SelectedItem);
        }
        private void BtnTerug_Click(object sender, RoutedEventArgs e)
        {
            lbxTodo.Items.Remove(lbxTodo.SelectedItem);
            lbxTodo.Items.Add(txtTaak.Text);
            txtTaak.Text = "";
        }
    }
}
