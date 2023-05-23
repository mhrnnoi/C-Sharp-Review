using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmergenceService
{
    public class Report
    {
        public static List<Service> Services { get; private set; }
        public Report(List<Service> services)
        {
            Services = new List<Service>();
            Services = services;
            StartReport();
        }
        public static void StartReport()
        {
            string input;
            PrintReportOptions();
            input = Console.ReadLine();
            ProcessReport(input);
        }
        public static void PrintReportOptions()
        {
            Console.Clear();

            Console.WriteLine("options: ");
            Console.WriteLine("all services: (1)");
            Console.WriteLine("fire services: (2)");
            Console.WriteLine("Emergency: (3)");
            Console.WriteLine("police services (males) 4");
            Console.WriteLine("police services (females) 5");
        }

        public static void ProcessReport(string report)
        {
            switch (report)
            {
                case "1":
                    AllServicesReport();
                    break;
                case "2":
                    FireServicesReport();
                    break;
                case "3":
                    EmergencyReport();
                    break;
                case "4":
                    PoliceServicesMReport();
                    break;
                case "5":
                    PoliceServicesFReport();
                    break;

                default:
                    Console.WriteLine("you entered invalid number plz enter between 1 - 5");
                    StartReport();
                    break;
            }
        }
        public static void AllServicesReport()
        {
            int counter = 0;
            Console.Clear();
            Console.WriteLine("All Services: ");

            foreach (var item in Services)
            {
                counter++;
                Console.WriteLine("#" + counter);
                Console.WriteLine("__________________");
                item.DisplayAllInfo();
                Console.WriteLine("__________________");


            }
            Console.WriteLine(counter + " times");
        }
        public static void FireServicesReport()
        {
            int counter = 0;
            Console.Clear();

            Console.WriteLine("All Fire Services: ");

            foreach (var item in Services.FindAll(a => a.Helper.GetType() == typeof(FireService)))
            {
                counter++;

                Console.WriteLine("#" + counter);

                Console.WriteLine("__________________");
                item.DisplayAllInfo();
                Console.WriteLine("__________________");
                Console.WriteLine(counter + " times");


            }
        }
        public static void EmergencyReport()
        {
            int counter = 0;
            Console.Clear();

            Console.WriteLine("All Emergency Services: ");

            foreach (var item in Services.FindAll(a => a.Helper.GetType() == typeof(EmergenceService)))
            {
                counter++;

                Console.WriteLine("#" + counter);

                Console.WriteLine("__________________");
                item.DisplayAllInfo();
                Console.WriteLine("__________________");
                Console.WriteLine(counter + " times");

            }
        }
        public static void PoliceServicesMReport()
        {
            int counter = 0;
            Console.Clear();

            Console.WriteLine("All Police Services for males: ");

            foreach (var item in Services.FindAll(a => a.Helper.GetType() == typeof(PoliceService) && a.User.Gender == "m"))
            {
                counter++;

                Console.WriteLine("#" + counter);

                Console.WriteLine("__________________");
                item.DisplayAllInfo();
                Console.WriteLine("__________________");
                Console.WriteLine(counter + " times");

            }
        }
        public static void PoliceServicesFReport()
        {
            int counter = 0;
            Console.Clear();

            Console.WriteLine("All police Services for woman: ");


            foreach (var item in Services.FindAll(a => a.Helper.GetType() == typeof(PoliceService) && a.User.Gender == "f"))
            {
                counter++;

                Console.WriteLine("#" + counter);

                Console.WriteLine("__________________");
                item.DisplayAllInfo();
                Console.WriteLine("__________________");
                Console.WriteLine(counter + " times");

            }
        }
    }
}