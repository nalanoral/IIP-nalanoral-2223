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

namespace WpfEllipsen__1_
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

        private void BtnTekenen_Click(object sender, RoutedEventArgs e)
        {
            // maak de ellipsen
            Ellipse newEllipse = new Ellipse();
            newEllipse.Width = 150;
            newEllipse.Height = 60;
            newEllipse.Fill = new SolidColorBrush(Color.FromRgb(122, 78, 200));
            double xPos = 50;
            double ypos = 85;
            newEllipse.SetValue(Canvas.LeftProperty, xPos);
            newEllipse.SetValue(Canvas.TopProperty, ypos);
            canvas1.Children.Add(newEllipse);

        }
    }
}
