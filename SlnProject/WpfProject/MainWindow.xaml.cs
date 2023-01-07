using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WMPLib;


namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nr = 0;

        List<int> ls = new List<int>();

        //Random aanmaken
        private static Random rnd = new Random();

        //Muziek aanmaken voor background
       
        WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

        //sounds voor animals
        SoundPlayer birds = new System.Media.SoundPlayer();
        SoundPlayer chicken = new System.Media.SoundPlayer();
        SoundPlayer cockerel = new System.Media.SoundPlayer();
        SoundPlayer cow = new System.Media.SoundPlayer();
        SoundPlayer dog = new System.Media.SoundPlayer();
        SoundPlayer donkey = new System.Media.SoundPlayer();
        SoundPlayer duck = new System.Media.SoundPlayer();
        SoundPlayer hogget = new System.Media.SoundPlayer();
        SoundPlayer cat = new System.Media.SoundPlayer();

        public double Volume { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            // initialiseer player for background music
            backgroundMusic.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/background.mp3");

            backgroundMusic.controls.stop();
        }

        //  background music  
        private void PlaySong()
        {
            backgroundMusic.controls.play();
        }

        private void Game()
        {
        }


        private void resetGame()
        {
        }



        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            PlaySong();

            lblScore.Content = "score:" + nr;


            // ls.Add(rnd.Next(0, 9));


            //nr = 0;
        }

        private void imgDog_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            dog.SoundLocation = "Sounds/dog.wav";
            dog.Play();
        }

        private void imgCat_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cat.SoundLocation = "Sounds/cat.wav";
            cat.Play();
        }

        private void imgChicken_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            chicken.SoundLocation = "Sounds/chickensound.wav";
            chicken.Play();
        }

        private void imgCockerel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cockerel.SoundLocation = "Sounds/cockerelsound.wav";
            cockerel.Play();
        }

        private void imgBird_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            birds.SoundLocation = "Sounds/birds.wav";
            birds.Play();
        }

        private void imgDuck_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            duck.SoundLocation = "Sounds/ducksounds.wav";
            duck.Play();
        }

        private void imgCow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cow.SoundLocation = "Sounds/cow.wav";
            cow.Play();
        }

        private void imgDonkey_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            donkey.SoundLocation = "Sounds/donkeysounds.wav";
            cow.Play();
        }

        private void imgHogget_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            hogget.SoundLocation = "Sounds/hoggetsounds.wav";
            hogget.Play();
        }

        private void btnMute_Click(object sender, RoutedEventArgs e)
        {
            backgroundMusic.settings.mute = true;
        }

        private void sldVolume_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //player = (int)sldVolume.Value;
            lblVolume.Content = $"Volume: {sldVolume.Value}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resetGame();
        }
    }
}
