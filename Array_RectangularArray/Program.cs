using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_RectangularArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] table = { 2, 4, 7, 55 };
            //  for (int c = 0; c < 4; c++)
            // {
            //Console.WriteLine(table[c]);
            // }
            //Console.ReadKey();
            //===========================================
            int[,] table = { { 2, 4, 7, 55 }, { 3, 1, 8, 10 }, { 6, 0, 49, 12 } };
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("{0,5}", table[r,c]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }


    }
}
