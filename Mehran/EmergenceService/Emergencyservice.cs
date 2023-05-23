using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmergenceService
{
    public class Emergencyservice : IHelp
    {
      

        public Emergencyservice()
        {
            Console.WriteLine("connecting to emergency departman ");
            Thread.Sleep(2000);
         

        }


        public void Help()
        {
            Console.WriteLine("reinforcements  will be in there  quickly .");
            Thread.Sleep(2000);

        }
    }
}