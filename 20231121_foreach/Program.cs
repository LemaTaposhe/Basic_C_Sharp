using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231121_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] trainee = { "A", "B", "C", "D", "E" };

            foreach (string x in trainee)
            {
                Console.WriteLine(x);
            }
        }
    }
}
