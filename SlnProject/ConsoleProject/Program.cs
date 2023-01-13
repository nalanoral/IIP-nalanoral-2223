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

            string[] animalnames = { "birds", "cat", "dog", "chicken", "cockerel", "duck", "cow", "donkey", "hogget" };
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
            //  Background Music activeren
            backgroundMusic.controls.play();


            do
            {
                Console.WriteLine(@" Welkome Sound Memory Game
a. Begin met spellen
b. Pauze nemen
c.stop");
                Console.Write("je keuze: ");
                keuze = Console.ReadLine();
                Console.WriteLine();
                backgroundMusic.controls.stop();

                if (keuze == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("What is your name :");
                    Console.ForegroundColor = ConsoleColor.Red;
                    string name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" How many sounds do u want to listen ?");
                    Console.ForegroundColor = ConsoleColor.Red;
                    aantalSounds = Convert.ToInt32(Console.ReadLine());

                    // random animal sounds play
                    //Select Random String From An Array C# =>>
                    //https://www.c-sharpcorner.com/article/how-to-select-a-random-string-from-an-array-of-strings/

                    // Create a Random object  
                    Random rnd = new Random();
                    int randomSound = rnd.Next(animalsounds.Length);

                    SoundPlayer animals = new SoundPlayer(animalsounds[randomSound]);

                    animals.Load();
                    animals.PlaySync();

                    List<string> sound = new List<String>();

                    for (int i = 0; i < animalsounds.Length; i++)
                    {

                        // add to list 

                        if (randomSound == 0)
                        {
                            sound.Add("birds");
                        }
                        else if (randomSound == 1)
                        {
                            sound.Add("dog");
                        }
                        else if (randomSound == 2)
                        {
                            sound.Add("cat");
                        }
                        else if (randomSound == 3)
                        {
                            sound.Add("chicken");
                        }
                    }
                    Console.WriteLine("++++");
                    string answer = Console.ReadLine();

                    if (answer == string.Join("-", sound))
                    {
                        Console.WriteLine("Bravo :-) ");

                    }
                    else
                    {
                        Console.WriteLine("uupss  :-( ");

                    }

                    Console.ReadKey();
                }

            }

            while (keuze != "c");

            Console.WriteLine("Game over");

            // Notatie voor me zelf //
            // use list for sound +if add to list //
            //Methodes voor lijsten =>> see pdf //
            // use for loop //

        }
    }
}

