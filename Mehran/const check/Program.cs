using System;

namespace const_check
{
    public class whatIsGoingOn
    {
        public readonly int jes = 98;
        public const double pi = 3.14;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var wtf = new whatIsGoingOn();
            
            
        }
    }
}
