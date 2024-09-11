using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231121_Do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first value");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second value:");
            double y = Double.Parse(Console.ReadLine());
            do
            {

                Console.WriteLine(x);
                x++;
            }

            while (x <= y);


        }



    }
}
