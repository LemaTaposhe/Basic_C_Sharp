using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int>numbers= new Stack<int>();
            //Fill the stack
            foreach (int number  in new int[10] {10,9,2,7,5,6,4,2,3,15}) 
            { 
            numbers.Push(number);
                Console.WriteLine("{0} has joined the Stack.",number);

            }
            Console.WriteLine("========Original============================");
 // Iterate Data
            foreach (int n in numbers)
            {
                Console.Write(n + "  ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Empty The Queue
            Console.WriteLine("=========Draining The Stack==========");
            while (numbers.Count > 0)
            {
                int num = numbers.Pop();
                Console.WriteLine("{0} has left the Stack.", num);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("=========After Modify===========");
            // Iterate Data
            foreach (int n in numbers)
            {
                Console.Write(n + "  ");
            }
            Console.ReadKey();
        }
    }
}
