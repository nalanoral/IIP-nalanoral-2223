﻿using System;
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

namespace DemoWpfRadioButton
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

        private void rbn1_1_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie 1 checked";
        }

        private void rbn1_2_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie 2 checked";
        }

        private void rbn1_3_Checked(object sender, RoutedEventArgs e)
        {
            lblMessage.Content = "optie 3 checked";
        }
    }
}