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

namespace WpfOxo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // variabelen aanmaken
        int player = 0;
        string letter;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLinksBoven_Click(object sender, RoutedEventArgs e)
        {
            //bepalen welke letter 
            if (player == 0)
            {
                letter = "O";
                player++;
            }
            else
            {
                letter = "X";
                player--;
            }

            // letter schrijven in de button
            Button btn = (Button)sender;
            btn.Content = $"{letter}";
            btn.IsEnabled = false;

            if (btnLinksBoven.Content == btnMidiBoven.Content && btnLinksBoven.Content == btnRechtsBoven.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            } 
            else if (btnLinksBoven.Content == btnLinksMidden.Content && btnLinksBoven.Content == btnLinksOnder.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            }
            else if (btnLinksBoven.Content == btnMidi.Content && btnLinksBoven.Content == btnRechtsOnder.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            }
            else if (btnMidiBoven.Content == btnMidi.Content && btnMidiBoven.Content == btnMiddenOnder.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            }
            else if (btnRechtsBoven.Content == btnMidi.Content && btnRechtsBoven.Content == btnLinksOnder.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            }
            else if (btnRechtsBoven.Content == btnMiddenRechts.Content && btnRechtsBoven.Content == btnRechtsOnder.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            }
            else if (btnLinksOnder.Content == btnMiddenOnder.Content && btnLinksOnder.Content == btnRechtsOnder.Content)
            {
                lblWinnaar.Content = $"speler {letter} heeft gewonnen";
            }
            else
            {
                lblWinnaar.Content = "";
            }
        }
    }
}
