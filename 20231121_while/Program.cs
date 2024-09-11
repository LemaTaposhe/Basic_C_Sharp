using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231121_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first valeu");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            double y=Convert.ToDouble(Console.ReadLine());
            while (x <= y) 
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
