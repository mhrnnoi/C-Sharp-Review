using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class Player
    {
        public Player(Color color, int playerNumber)
        {
            SetName();
            PlayerNumber = playerNumber;
            Color = color;
            Money = 1500;
            Properties = new List<Property>();
            ChestCard = new List<ChestCard>();
            ChanceCard = new List<ChanceCard>();
            Place = (Places)1;


        }

        public string Name { get; set; }
        public int PlayerNumber { get; private set; }
        public Color Color { get; set; }
        public int Money { get; private set; }
        public List<Property> Properties { get; set; }
        public List<ChestCard> ChestCard { get; set; }
        public List<ChanceCard> ChanceCard { get; set; }
        public int Dice { get; private set; }
        public Places Place { get; set; }

        public void RollADice()
        {
            var rnd = new Random();
            var Dice1 = rnd.Next(1, 7);
            var Dice2 = rnd.Next(1, 7);
            Console.WriteLine(Dice1 + " " + Dice2);
            Dice = Dice1 + Dice2;

        }
        public void SetName()
        {
            var input = "";
            Console.WriteLine("enter your name :");
            do
            {
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            Name = input;
        }
        void Buy() { }
        void trade() { }
        void Mortgage() { }
        void Pay() { }
        void receive() { }
        void auction() { }

    }
}