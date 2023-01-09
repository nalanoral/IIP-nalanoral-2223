using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using WMPLib;

namespace ConsoleProject
{
    internal class Program
    {
        // Random aanmaken
        private static Random rnd = new Random();

        public bool GameOver { get; private set; } = false;

        private int guessSound = 0;
        private int isMatch;

        WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

        // sounds voor animals
        SoundPlayer birds = new System.Media.SoundPlayer();
        SoundPlayer chicken = new System.Media.SoundPlayer();
        SoundPlayer cockerel = new System.Media.SoundPlayer();
        SoundPlayer cow = new System.Media.SoundPlayer();
        SoundPlayer dog = new System.Media.SoundPlayer();
        SoundPlayer donkey = new System.Media.SoundPlayer();
        SoundPlayer duck = new System.Media.SoundPlayer();
        SoundPlayer hogget = new System.Media.SoundPlayer();
        SoundPlayer cat = new System.Media.SoundPlayer();

        static void Main(string[] args)
        {
            string keuze;
            int aantalSounds;
            Random rnd = new Random();

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

            WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

            // initialiseer player for background music
            backgroundMusic.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/background.mp3");

            // Music activeren
            backgroundMusic.controls.play();

            // backgroundMusic.controls.stop();
            do
            {
                Console.WriteLine(@" Welkome Sound Memory Game
a. Begin met spellen
b. Pauze namen
c.stop");
                Console.Write("je keuze: ");
                keuze = Console.ReadLine();
                Console.WriteLine();
                if (keuze == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What is your name :");
                    Console.ForegroundColor = ConsoleColor.Red;
                    string name = Console.ReadLine();
                    Console.WriteLine(" How many sounds do u want to listen ?");
                    aantalSounds = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (keuze != "c");
            Console.WriteLine("Game over");

            // Notatie voor me zelf //
            // use list for sound + add to list //
            //Methodes voor lijsten =>> see pdf //
            // use for loop //

        }
    }
}

