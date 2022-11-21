namespace WpfChat
{
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


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summ
    /// ary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            txtMessage.Text =txtMessage.Text.Replace("shit","****");
            tbChat.Text += txtName.Text + " says:" + Environment.NewLine + txtMessage.Text + Environment.NewLine + Environment.NewLine;
            txtName.Text = "";
            txtMessage.Text = "";
        }
    }
}
