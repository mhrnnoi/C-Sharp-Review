using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class Monopoly
    {
        private static readonly string _tutorialLink = "https://www.bing.com/ck/a?!&&p=32b89d9189c2035fJmltdHM9MTY4NDcxMzYwMCZpZ3VpZD0yYzA2YmE2OS1mMmFiLTY0YzctMDEyNS1hODA4ZjMyMDY1YWEmaW5zaWQ9NTE0NA&ptn=3&hsh=3&fclid=2c06ba69-f2ab-64c7-0125-a808f32065aa&u=a1L3ZpZGVvcy9zZWFyY2g_cT1tb25vcG9seStnYW1lK3R1dG9yaWFsJnFwdnQ9bW9ub3BvbHkrZ2FtZSt0dXRvcmlhbCZGT1JNPVZEUkU&ntb=1";
        public static double NumberOfPlayers { get; private set; }
        public static string LeaderBoard { get; private set; }
        public static double PlayedRounds { get; private set; }
        public static double PlayedGames { get; private set; }
        private static List<Player> PlayersTurn = new List<Player>();
        private static List<Color> ReminderColors = new List<Color>();
        // public Dictionary<int,Places> Places { get; set; }
        // {
        //     Color.Red,
        //     Color.Blue,
        //     Color.Green,
        //     Color.Yellow,
        //     Color.Purple,
        //     Color.Pink,


        // };
        private static List<Player> Players = new List<Player>();

        public static void MainMenu()
        {
            Console.WriteLine("hi ");
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.WriteLine("Options:  ");
            Console.WriteLine("(1) Start New Game");
            Console.WriteLine("(2) LeaderBoard");
            Console.WriteLine("(3) Tutorial");
            Console.WriteLine("(4) Reset LeaderBoard");
            Console.WriteLine("(5) Exit");




        }
        public static void PrepareTurns(Player firstPlayer)
        {
            var turn = firstPlayer;
            var turnIndex = Players.FindIndex(a => a == turn);

            for (int i = 0; i < Players.Count; i++)
            {
                PlayersTurn.Add(turn);

                if (turnIndex == Players.Count - 1)
                {
                    turn = Players.First();
                    turnIndex = Players.FindIndex(a => a == turn);

                }
                else
                {
                    turn = Players[turnIndex + 1];
                    turnIndex = Players.FindIndex(a => a == turn);
                }

            }
        }
        public static void Start()
        {
            MainMenu();
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    StartNewGame();
                    break;
                case "2":
                    GetLeaderboard();
                    break;
                case "3":
                    Intro();
                    break;
                case "4":
                    ResetLeaderboard();
                    break;
                case "5":
                    break;

                default:
                    Console.WriteLine("enter valid Number");
                    Thread.Sleep(2000);
                    Start();
                    break;

            }
        }

        public static void Intro()
        {

            Console.WriteLine("Welcome To Monopoly!");
            Console.WriteLine("If you need a tutorial you can watch this video : ");
            Console.WriteLine(_tutorialLink);
        }
        public static void GetLeaderboard()
        {

        }
        public static void ResetLeaderboard() { }
        public static void ShouldPrintIntro()
        {
            PlayedGames = Convert.ToDouble(File.ReadAllText("NumberOfPlayedGames.txt"));

            if (PlayedGames == 0)
            {
                Console.Clear();
                Intro();
                Console.WriteLine();
                Console.WriteLine("presss any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void SignUpPlayers()
        {
            Player player;
            for (int i = 1; i <= NumberOfPlayers; i++)
            {
                Console.WriteLine($"player number {i}");
                player = new Player(ColorChoose(), i);
                do
                {

                    if (Players.FindIndex(a => a.Name == player.Name) == -1)
                    {
                        Players.Add(player);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("the name is already taken enter another name");
                        player.SetName();
                    }

                } while (true);
                {

                }

                Console.WriteLine($"player number {i} created");
                Console.WriteLine("name : " + player.Name);
                Console.WriteLine("color : " + player.Color);

            }
        }
        public static Color ColorChoose()
        {
            do
            {
                ColorOption();
                Console.WriteLine();
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input) || double.TryParse(input, out double result1) == false)
                {
                    Console.WriteLine("plz enter valid number not character or emtpty: ");
                }
                else
                {
                    var number = Convert.ToDouble(input);
                    if (number < 1 || number > 6)
                    {
                        Console.WriteLine("plz enter valid number between 1 - 6");
                    }
                    else
                    {
                        var color = (Color)number;
                        if (ReminderColors.Contains(color))
                        {
                            ReminderColors.Remove(color);
                            return color;
                        }
                        else
                        {
                            Console.WriteLine("this color number is Already Taken");
                        }
                    }
                }

            } while (true);





        }
        public static void ColorOption()
        {
            Console.WriteLine("plz choose between this colors by its number :");
            for (int i = 0; i < ReminderColors.Count; i++)
            {
                Console.Write("(" + (int)ReminderColors[i] + ")");
                Console.Write(" ");
                Console.Write(ReminderColors[i]);
                Console.Write(" ");

            }
        }


        public static void StartNewGame()
        {
            ShouldPrintIntro();
            AskNumberOfPlayers();
            SignUpPlayers();
            PrepareTurns(StartFirst(Players));
            Play(PlayersTurn);


        }
        // public static void Go(Player player)
        // {
        //     player.Place = (Places)((int)player.Place + player.Dice);
        // }

        public static void Play(List<Player> players)
        {
            Console.WriteLine("ok game is about to start..");
            Thread.Sleep(2000);
            while (Players.Count > 1)
            {
                foreach (var item in players)
                {
                    Console.WriteLine(item.Name + " turn");
                    item.RollADice();
                    // Go(item);

                }
            }
        }
        // public static void ProcessPlace(Player player)
        // {
        //     if (player.Place is )
        //     {
                
        //     }
        // }

        public static Player StartFirst(List<Player> players)
        {
            Player highest;
            var multipleHighs = players;
            Console.Clear();

            do
            {
                Console.WriteLine("who start first? ");
                foreach (var item in players)
                {
                    Console.WriteLine("Now");
                    Console.WriteLine(item.Name + " roll dice");
                    item.RollADice();
                    Thread.Sleep(3000);

                    Console.WriteLine(item.Name + " got " + item.Dice);
                    Thread.Sleep(3000);

                }
                highest = players.OrderByDescending(a => a.Dice).First();
                multipleHighs = players.FindAll(a => a.Dice == highest.Dice);
                if (multipleHighs.Count > 1)
                {
                    Console.WriteLine("we have multiple high ");
                    foreach (var item in multipleHighs)
                    {
                        Console.WriteLine(item.Name);
                        Console.WriteLine("has " + item.Dice);

                    }
                    Console.WriteLine("so roll again!!");
                    players = multipleHighs;
                }
            } while (multipleHighs.Count > 1);


            Console.WriteLine(highest.Name + " starts first");
            return highest;


        }
        public static void AskNumberOfPlayers()
        {
            Console.WriteLine("Enter Number of Players to play: 2-6");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":

                    NumberOfPlayers = Convert.ToDouble(input);

                    break;


                default:
                    Console.WriteLine("plz enter valid number : ");
                    Thread.Sleep(3000);
                    AskNumberOfPlayers();
                    break;
            }
            Console.WriteLine("preparing...");
            Thread.Sleep(3000);
            Console.Clear();
        }


    }
}