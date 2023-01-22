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
            int mute = 1;
            int score = 0;

            List<string> afspeellijst = new List<string>();
            List<string> sounds = new List<string>();

            // Create a Random object  
            Random rnd = new Random();
            SoundPlayer player = new SoundPlayer();

            string[] animalnames = { "birds", "cat", "dog", "chicken", "cockerel", "duck", "cow", "donkey", "hogget" };
            string[] animalsounds = new string[9];

            animalsounds[0] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/birds.wav");
            animalsounds[1] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/dog.wav");
            animalsounds[2] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/cat.wav");
            animalsounds[3] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/chickensound.wav");
            animalsounds[4] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/cockerelsound.wav");
            animalsounds[5] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/cow.wav");
            animalsounds[6] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/donkeysounds.wav");
            animalsounds[7] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/ducksounds.wav");
            animalsounds[8] = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/hoggetsounds.wav");

            WMPLib.WindowsMediaPlayer backgroundMusic = new WMPLib.WindowsMediaPlayer();

            // initialiseer player for background music
            backgroundMusic.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Sounds/background.mp3");

            // Music activeren
            backgroundMusic.controls.play();

            do
            {
                // banner printen
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Welkome Sound Memory Game");
                Console.WriteLine("=============================");

                Console.WriteLine(@" 
a.Begin met spellen
b.Mute/un mute volume
c.Animal sounds aan afspeellijst toevoegen
d.Score
e.Stop met spellen");
                Console.Write("je keuze: ");
                keuze = Console.ReadLine();
                backgroundMusic.controls.stop();

                // begining of play
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

                    // https://stackoverflow.com/questions/14297853/how-to-get-random-values-from-array-in-c-sharp //
                    // https://www.c-sharpcorner.com/article/how-to-select-a-random-string-from-an-array-of-strings//
                    for (int i = 0; i < aantalSounds; i++)
                    {
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
                        Console.WriteLine("Your answer is :");
                        string answer = Console.ReadLine();

                        if (answer == string.Join(",", sounds))
                        {
                            Console.WriteLine("Bravo ! you got it");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine("oepss    !");
                        }
                        sounds.Clear();
                    }
                }
                // geluid (un)muten
                else if (keuze == "b")
                {

                    MuteSong(mute, player);
                    if (mute == 1)
                    {
                        mute--;
                    }
                    else
                    {
                        mute++;
                    }
                    Console.Clear();
                }
                else if (keuze == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("lijst voor animalsname:");
                    string animalsname = Console.ReadLine();
                    AddSound(animalsname, afspeellijst);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (keuze == "d")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Jij hebt {Score(score)} .");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            
            while(keuze != "e");  // 
        }
        private static void MuteSong(int mute, SoundPlayer player)
        {
            if (mute == 1)
            {
                player.Stop();
            }
            else
            {
                player.Play();
            }
        }
        private static List<string> AddSound(string sound, List<string> afspeellijst)
        {
            afspeellijst.Add($"{sound}");
            return afspeellijst;
        }
        private static string Score(int aantalPunten)
        {
            if (aantalPunten == 1)
            {
                return $"{aantalPunten} punt";
            }
            else
            {
                return $"{aantalPunten} punten";
            }
        }
    }
}