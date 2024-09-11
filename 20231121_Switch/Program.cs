using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231121_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { int a, b; b = 0; a = 5 / b; Console.WriteLine("A"); }
            catch (ArithmeticException e) { Console.WriteLine("B"); }
            finally { Console.WriteLine("C"); }
            Console.ReadLine();
        }
    }
}
