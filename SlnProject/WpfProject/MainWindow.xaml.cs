using System;
using System.Collections.Generic;
using System.IO;
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
        int highScore;
        int currentScore = 0;
        const int NUMBER_OF_ANIMALS = 9;

        // Create an array to store all the images in the game
        Image[] animalPictures;

        // Create an array to store all the sounds in the game
        Stream[] animalSounds;



        //Random aanmaken
        private static Random rnd = new Random();

        //Muziek aanmaken voor background

        WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

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

        public double Volume { get; set; }
        public MainWindow()
        {
            InitializeComponent();


            // initialiseer player for background music
            backgroundMusic.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/background.mp3");
            backgroundMusic.controls.play();
            //backgroundMusic.controls.stop();

            // Assign images into the array
            animalPictures = new Image[NUMBER_OF_ANIMALS];
            animalPictures[0] = imgBird;
            animalPictures[1] = imgDog;
            animalPictures[2] = imgCat;
            animalPictures[3] = imgChicken;
            animalPictures[4] = imgCockerel;
            animalPictures[5] = imgDuck;
            animalPictures[6] = imgCow;
            animalPictures[7] = imgDonkey;
            animalPictures[8] = imgHogget;

            lblScore.Content = "Score: " + currentScore;
        }
        // background music  
        static private void PlaySounds()
        {
            // Assign sounds into the array   
            string[] animalsounds = new string[9];
            animalsounds[0] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/birds.wav");
            animalsounds[1] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/dogsounds.wav");
            animalsounds[2] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/cat.wav");
            animalsounds[3] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/chickensound.wav");
            animalsounds[4] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/cockerelsound..wav");
            animalsounds[5] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/cow.wav");
            animalsounds[6] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/donkeysounds.wav");
            animalsounds[7] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/ducksounds.wav");
            animalsounds[8] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/hoggetsounds..wav");
            // random animal sounds play
            int randomSound = rnd.Next(animalsounds.Length);
            SoundPlayer animals = new SoundPlayer(animalsounds[randomSound]);
            
            animals.Play();
            animals.Load();


        }

        private void Game()
        {
        }
        private void resetGame()
        {
        }
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            PlaySounds();
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

        void CountScore(object sender, EventArgs e)
        {
            // Open subprogram to see if user enter a correct answer
            bool answer = CheckCorrectOrNot(sender);

            // Check if the user got the correct answer
            if (answer == true)
            {
                // User gets one point added to their score
                currentScore = currentScore + 1;

                lblHighScore.Content = "New High Score: " + currentScore;
            }
            else
            {
                // Show score
                lblHighScore.Content = "Score: " + currentScore;
            }
        }
        private bool CheckCorrectOrNot(object sender)
        {
            throw new NotImplementedException();

            // Check if the user pressed the picture of the animal
            // that corresponds to the sound that was played

            //if ()
            //{
            //  User has selected the right answer! Display the "correct" message
            // MessageBox.Show("Correct! You got it!");

            // Game();

            //return true;
            //}

            //else

            //{
            // User has clicked the wrong animal! Display the "wrong" message 
            // MessageBox.Show("Oops! Wrong answer");
            //return false;
            //}

        }

        bool CheckHighScore()
        {
            if (currentScore > highScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resetGame();
        }
    }
}
