using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Linq;
using WMPLib;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // below are all the necessary integers declared for  game
        int lastScore = 0;
        int score = 0;
        int record;
        int soundsCount = 0;
    
        public double Volume { get; set; }

        // Random aanmaken
        private static Random rnd = new Random();

        // Muziek aanmaken voor background
        WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

        // Muziek aanmaken voor applause
        WMPLib.WindowsMediaPlayer applause = new WMPLib.WindowsMediaPlayer();

        WMPLib.WindowsMediaPlayer wrong = new WMPLib.WindowsMediaPlayer();

        // Create a sound player for all the sounds in the game
        SoundPlayer player = new SoundPlayer();
        SoundPlayer birds = new System.Media.SoundPlayer();
        SoundPlayer chicken = new System.Media.SoundPlayer();
        SoundPlayer cockerel = new System.Media.SoundPlayer();
        SoundPlayer cow = new System.Media.SoundPlayer();
        SoundPlayer dog = new System.Media.SoundPlayer();
        SoundPlayer donkey = new System.Media.SoundPlayer();
        SoundPlayer duck = new System.Media.SoundPlayer();
        SoundPlayer hogget = new System.Media.SoundPlayer();
        SoundPlayer cat = new System.Media.SoundPlayer();

        List<string> sounds = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            // btnStart.IsEnabled = false;
            // btnRestart.IsEnabled = false;
            // btnMute.IsEnabled = false;

            // initialiseer player for background music
            backgroundMusic.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/background.mp3");
            backgroundMusic.controls.play();

            // initialiseer applause 
            applause.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/Applause.mp3");
            applause.controls.stop();

            // initialiseer faut sound
            wrong.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/wrong.mp3");
            wrong.controls.stop();

            // Assign images into the array
            string[] animals = new string[9] { "birds", "dog", "cat", "chicken", "cockerel", "cow", "donkey", "duck", "hogget" };
        }
        private void GameLoop(object sender, EventArgs e)
        {
            soundsCount++;
            lblScore.Content = "Score: " + soundsCount;
            if (soundsCount > record)
            {
                record = soundsCount;
                lblHighscore.Content = "High Score :" + record;
            }
            lblLastScore.Content = "Last Score: " + lastScore;

            // variabele item on nieuw item toe te voegen aan listbox
            ListBoxItem item = new ListBoxItem();
            item.Content = tbxName.Text + " " + soundsCount;
            lbxLijst.Items.Add(item);
            tbxName.Text = "";
        }
        private void ImgDog_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            imgDog.Opacity = 0.4;
            dog.SoundLocation = "Sounds/dog.wav";
            dog.Play();
            CheckCorrect("dog");
        }
        private void ImgCat_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cat.SoundLocation = "Sounds/cat.wav";
            cat.Play();
            imgCat.Opacity = 0.4;
            CheckCorrect("cat");
        }
        private void ImgChicken_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            imgChicken.Opacity = 0.4;
            chicken.SoundLocation = "Sounds/chickensound.wav";
            chicken.Play();
            CheckCorrect("chicken");
        }
        private void ImgCockerel_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cockerel.SoundLocation = "Sounds/cockerelsound.wav";
            cockerel.Play();
            imgCockerel.Opacity = 0.4;
            CheckCorrect("cockerel");
        }
        private void ImgBird_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            birds.SoundLocation = "Sounds/birds.wav";
            birds.Play();
            imgBird.Opacity = 0.4;
            CheckCorrect("birds");
        }
        private void ImgDuck_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            imgDuck.Opacity = 0.4;
            duck.SoundLocation = "Sounds/ducksounds.wav";
            duck.Play();
            CheckCorrect("duck");
        }
        private void ImgCow_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cow.SoundLocation = "Sounds/cow.wav";
            cow.Play();
            imgCow.Opacity = 0.4;
            CheckCorrect("cow");
        }
        private void ImgDonkey_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            donkey.SoundLocation = "Sounds/donkeysounds.wav";
            donkey.Play();
            imgDonkey.Opacity = 0.4;
            CheckCorrect("donkey");
        }
        private void ImgHogget_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            hogget.SoundLocation = "Sounds/hoggetsounds.wav";
            hogget.Play();
            imgHogget.Opacity = 0.4;
            CheckCorrect("hogget");
        }
        private void SldVolume_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int player = Convert.ToInt32(sldVolume.Value);
            lblVolume.Content = $"Volume: {sldVolume.Value}";
            lblVolume.Foreground = Brushes.Orange;
        }
        private void PlaySounds()
        {
            backgroundMusic.controls.stop();

            // Assign sounds into the array
            string[] animalsounds = new string[9];
            animalsounds[0] = birds.SoundLocation = "Sounds/birds.wav";
            animalsounds[1] = dog.SoundLocation = "Sounds/dog.wav";
            animalsounds[2] = cat.SoundLocation = "Sounds/cat.wav";
            animalsounds[3] = chicken.SoundLocation = "Sounds/chickensound.wav";
            animalsounds[4] = cockerel.SoundLocation = "Sounds/cockerelsound.wav";
            animalsounds[5] = cow.SoundLocation = "Sounds/cow.wav";
            animalsounds[6] = donkey.SoundLocation = "Sounds/donkeysounds.wav";
            animalsounds[7] = duck.SoundLocation = "Sounds/ducksounds.wav";
            animalsounds[8] = hogget.SoundLocation = "Sounds/hoggetsounds.wav";

            // random animal sounds play
            int aantalSounds = Convert.ToInt32(tbxCount.Text);
            for (int i = 0; i < aantalSounds; i++)
            {
                // https://stackoverflow.com/questions/14297853/how-to-get-random-values-from-array-in-c-sharp //
                // https://www.c-sharpcorner.com/article/how-to-select-a-random-string-from-an-array-of-strings//
                int randomSound = rnd.Next(0, animalsounds.Length);
                SoundPlayer animals = new SoundPlayer(animalsounds[randomSound]);
                animals.Load();
                animals.PlaySync();
                switch (randomSound)
                {
                    case 0:
                        sounds.Add("birds");
                        break;
                    case 1:
                        sounds.Add("dog");
                        break;
                    case 2:
                        sounds.Add("cat");
                        break;
                    case 3:
                        sounds.Add("chicken");
                        break;
                    case 4:
                        sounds.Add("cockerel");
                        break;
                    case 5:
                        sounds.Add("cow");
                        break;
                    case 6:
                        sounds.Add("donkey");
                        break;
                    case 7:
                        sounds.Add("duck");
                        break;
                    case 8:
                        sounds.Add("hogget");
                        break;
                }
            }
        }
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            PlaySounds();
            GameLoop(sender, e);
        }

        // https://www.dotnetperls.com/sequenceequal // 
        // https://stackoverflow.com/questions/3232744/easiest-way-to-compare-arrays-in-c-sharp //
        private void CheckCorrect(string animals)
        {
            if (sounds[soundsCount] != animals)
            {
                wrong.controls.play();
                MessageBox.Show(" Play again!");
            }
            else
            {
                MessageBox.Show("Correct! Yougot it!");
                applause.controls.play();
                soundsCount++;
            }
        }
        private void ImportTekstBestand() // methode for tekstbestand  importe to  listbox =>> using pdf van les material
        {
            // variabelen path  for My Documenten op de pc
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string bestand = System.IO.Path.Combine(folder, $"{txtBestand.Text}.txt");

            if (System.IO.File.Exists(bestand))
            { // file existis =>> https://learn.microsoft.com/en-us/dotnet/api/system.io.directory.getfiles?source=recommendations&view=net-7.0
                using (StreamReader reader = System.IO.File.OpenText(bestand)) // using streamreader for bestand  open +read
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        ListBoxItem newItem = new ListBoxItem(); // create new listboxitem
                        newItem.Content = line;
                        lbxLijst.Items.Add(newItem); // add +item aan de listbox
                    }
                }
            }
            txtBestand.Text = "Naam Bestand"; // reset textbox 
        }
        private void ExportToTekstBestand() // methode for listbox  exporteren to tekstbestand
        {
            // pad zoeken
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string bestand = System.IO.Path.Combine(folder, $"{txtBestand.Text}.txt");
            using (StreamWriter writer = System.IO.File.CreateText(bestand)) // streamwriter om een tekstbestand for save
            {
                foreach (ListBoxItem item in lbxLijst.Items)
                {
                    writer.WriteLine(item.Content); // write regel per regel to  het tekstbestand
                }
            }
            txtBestand.Text = "Naam Bestand"; // reset textbox
        }
        private void BtnRestart_Click(object sender, RoutedEventArgs e)
        {
            applause.controls.stop();
            wrong.controls.stop();
            GameLoop(sender, e);
            PlaySounds();  
            lbxLijst.Items.Clear();
            lblHighscore.Content = string.Empty; 
            lblLastScore.Content = "";
            lblName.Content = "";
            txtBestand.Text = "";
            tbxCount.Text = "";
        }
        private void BtnMute_Click(object sender, RoutedEventArgs e)
        {
            backgroundMusic.settings.mute = true;  
            btnMute.Background = Brushes.Orange;
        }
        private void BtnUnmute_Click(object sender, RoutedEventArgs e)
        {
            backgroundMusic.settings.mute = false;
            btnUnmute.Background = Brushes.Orange;
        }
    }
}
