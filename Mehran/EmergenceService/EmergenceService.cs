using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergenceService
{
    public class EmergenceService
    {

        private static List<Service> Services = new List<Service>();
        public static Report Reports { get; set; }

        public static void ClearServices()
        {
            Services.Clear();
            Process();
        }
        public static void PrintMainMenu()
        {
            Console.Clear();

            Console.WriteLine("Enter Number :  ");
            Console.WriteLine("Service (1)");
            Console.WriteLine("Report (2)");
            Console.WriteLine("Clear Services (3)");
            Console.WriteLine("Exit (4)");
        }
        public static void Switch(string input)
        {
            switch (input)
            {
                case "1":
                    Service();
                    break;
                case "2":
                    Report();
                    break;
                case "3":
                    ClearServices();
                    break;
                case "4":
                    Console.WriteLine("Good Bye..");
                    break;

                default:
                    Console.WriteLine("you entered wrong number! \nTry Again");
                    Process();
                    break;
            }
        }

        public static void Process()
        {

            PrintMainMenu();
            string input = Console.ReadLine();
            Switch(input);




        }

        public static void Report()
        {
            Reports = new Report(Services);
            Console.WriteLine();
            Console.WriteLine("press any key to back to main menu");
            Console.ReadKey();
            Process();


        }



        public static void Service()
        {
            Services.Add(new Service());
            Process();



        }
    }
}