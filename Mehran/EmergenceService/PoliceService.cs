using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmergenceService
{
    public class PoliceService : IHelp
    {

        public PoliceService()
        {
            Console.WriteLine("connecting to Police departman ");
            Thread.Sleep(2000);
        }

        

        public void Help()
        {
            Console.WriteLine("reinforcements  will be in there  quickly .");
            Thread.Sleep(2000);

            Console.WriteLine("press any key to continue");
            Console.ReadKey();


        }
    }
}