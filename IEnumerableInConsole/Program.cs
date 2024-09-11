using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableInConsole
{
    internal class Program
    {
        static void Display(IEnumerable<bool> bools)
        {
            foreach (bool value in bools)
            {
                Console.WriteLine(value);
            }

        }
        static void Main(string[] args)
        {
            IEnumerable<int> result=from value in Enumerable.Range(0, 5) 
                                    select value;
            foreach (int value in result) 
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("=============");
            double average=result.Average();
            Console.WriteLine(average);
            Console.WriteLine("=====================");
            int[]convert=result.ToArray();
            foreach (int value in convert)
            {
                Console.WriteLine("======Parameter=====");
                Display(new List<bool> { true, false, false, false, true });
            }
        }
    }
}
