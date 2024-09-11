using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231121_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls. Enter a Number: ");
                int a=int.Parse(Console.ReadLine());
            for(int i=0; i<a; i++) 
            { Console.WriteLine(i); }
        }
    }
}
