using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231122_Method
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Program program = new Program();
            R57  r57 = new R57();
            Console.WriteLine(program.Abcd(4,6));
            Console.WriteLine(EFGH(10, 6));
            Console.WriteLine(PQRS(10, 6, 10));
            LMNOP(4, 7, 2);
            Console.WriteLine(R57.RemNum(100,70));
            Console.WriteLine();

        }
        public  double Abcd(double a, double b)
        {
            return a + b;

        }
        public static double EFGH(double a, double b)
        {
            return a - b;

        }
        public static double PQRS(double a, double b, double c)
        {
            return a - b + c;

        }
        public static void  LMNOP(double a, double b, double c)
        {
            Console.WriteLine( a - b + c);

        }



    }
    public class R57
    {
        public static double RemNum(double a, double b)
        {
            return a % b;
        }
        public double  KYAC(double a, double b)
        {
            return a % b;
        }

    }
}
