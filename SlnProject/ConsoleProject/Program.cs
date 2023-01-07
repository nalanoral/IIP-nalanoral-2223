
using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using WMPLib;

namespace ConsoleProject
{
    internal class Program
    {
        //Random aanmaken
        private static Random rnd = new Random();

        public bool GameOver { get; private set; } = false;

        private int guessSound = 0;
        private int isMatch;

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






        static void Main(string[] args)
        {


            WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

            // initialiseer player for background music
            backgroundMusic.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/background.mp3");

            backgroundMusic.controls.stop();
            Console.WriteLine(@"Sound Memory Game
" + Environment.NewLine);

            Console.ReadLine();
            do
            {
                Console.WriteLine("Enter animal name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string animalsname = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;

                //switch (animals) =>> use switch for colors of animals
                // {

                //}

                //Music activeren
                backgroundMusic.controls.play();

            }
            while (true);
            Console.WriteLine("Game over");
        }

        private void PlayThisGame()
        {
            List<string> Animals = new List<string>() // list of animals
            {
               "Bird",
               "Duck",
               "Dog",
               "Chicken",
               "Cow",
               "Donkey",
            };


            Random random = new Random();

            int index = random.Next(Animals.Count);
            if (Animals.Count > index)
            {
                string nextAnimal = Animals[index];
                Console.WriteLine($"{nextAnimal}");
                Animals.RemoveAt(index);

                Console.ReadLine();
            }

            List<string> sounds = new List<string>()
            {
                "birds",
                "ducksounds",
                "dogsounds",
                "chickensound",
                "cow",
                "donkeysounds",

            };
            if (isMatch == 6)
            {
                Animals = sounds;
            }

        }
    }
}

