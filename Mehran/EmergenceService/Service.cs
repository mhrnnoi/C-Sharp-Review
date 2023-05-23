using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmergenceService
{
    public class Service
    {
        public User User { get; private set; }
        public IHelp Helper { get; private set; }

        public string Accident { get; private set; }

        public Service()
        {
            User = new User();
            ConnectingToDepartmant();
            Helper.Help();


        }
        public void DisplayAllInfo()
        {
            Console.WriteLine(User.FirstName);
            Console.WriteLine(User.LastName);
            Console.WriteLine(User.Gender);
            Console.WriteLine(User.Address);
            Console.WriteLine(User.Id);
            Console.WriteLine(Accident);

        }

        public void ConnectingToDepartmant()
        {
            string input;
            bool IsEnteredCorrect = false;
            do
            {
                Console.WriteLine("what's Your emergency? enter number ");
                Console.WriteLine("robbery (1)");
                Console.WriteLine("fire service (2)");
                Console.WriteLine("hard breathing (3)");

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Accident = "robbery";
                        Helper = new PoliceService();
                        IsEnteredCorrect = true;
                        break;

                    case "2":
                        Accident = "fire service";
                        Helper = new FireService();
                        IsEnteredCorrect = true;

                        break;


                    case "3":
                        Accident = "hard breathing";
                        Helper = new Emergencyservice();
                        IsEnteredCorrect = true;

                        break;
                    default:
                        Console.WriteLine("plz enter correct accident using  number");
                        break;
                }
            } while (!IsEnteredCorrect);


        }


    }
}