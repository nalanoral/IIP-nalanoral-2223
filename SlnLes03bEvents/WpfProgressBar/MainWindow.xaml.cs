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
using System.Windows.Threading;

namespace WpfProgressBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            lblCount.Content = count;
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_tick;
            timer.Start();
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            count++;
            lblCount.Content = count;
            rctnTimer.Width = count * 12;  // ??
            rctnTimer.Fill = new SolidColorBrush(Colors.Green);
            lblCount.Content = count + "%";

            if (rctnTimer.Width == 300)
            MessageBox.Show("voortgang voltooid");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
           
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            rctnTimer.Width = 0;
            lblCount.Content = "0 %";
        }
    }
}
