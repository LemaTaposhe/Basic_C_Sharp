using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231121_if_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter marks: ");
            int marks = Int32.Parse(Console.ReadLine());
            if (marks <33) 
            {
                Console.WriteLine("F");
            }
            else if (marks >=33 && marks< 40)
            {
                Console.WriteLine("D");
            }
            else if (marks >= 40 && marks < 50)
            {
                Console.WriteLine("C");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("B");
            }
            else if (marks >= 60 && marks < 70)
            {
                Console.WriteLine("A-");
            }
            else if (marks >= 70 && marks < 80)
            {
                Console.WriteLine("A");
            }
            else if (marks >= 80 && marks < 100)
            {
                Console.WriteLine("A+");
            }
            else { Console.WriteLine("Invailed Number"); }

        }
    }
}
