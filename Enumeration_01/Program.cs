using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_01
{
    enum Month
    { 
    January, Febuary, Murch, April,May, June, July,August, September
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Month m = Month.January;
            for(m=Month.January;m<=Month.September;m++) 
            {
                Console.WriteLine(m);
            }
            Console.BackgroundColor=ConsoleColor.Green;
        }
    }
}
