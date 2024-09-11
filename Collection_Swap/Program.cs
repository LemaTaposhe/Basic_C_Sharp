using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Swap
{
    internal class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args)
        {
            int a = 10, b = 15;
            char c = 'x',d='y';
            Console.WriteLine("Before Swapping");
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine();
            Console.WriteLine("c={0},d={1}", c, d);
            Console.WriteLine();
            Console.WriteLine("========================");
                Swap<int>(ref  a, ref b);
            Swap<char>(ref c, ref d);
            Console.WriteLine("After Swapping");
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine();
            Console.WriteLine("c={0},d={1}",c,d);

        }
    }
}
