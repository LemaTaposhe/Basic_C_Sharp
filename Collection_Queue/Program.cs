using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            //Fill the queue
            foreach (int number in new int[10] { 10, 9, 2, 7, 5, 6, 4, 2, 3, 15 })
            {
                numbers.Enqueue(number);
                Console.WriteLine("{0} has joined the queue.", number);
            }
            Console.WriteLine("==========Original========");
            //Iterate Data
            foreach (int n in numbers) 
            {
                Console.WriteLine(n+"  ");

            }
            Console.WriteLine();
            Console.WriteLine();
            //Empty Queue
            Console.WriteLine("===============Draining The Queue=====");
            while (numbers.Count>0) 
            {
            int num=numbers.Dequeue();
                Console.WriteLine("{0} has laft the queue.",num);
                //Iterate Data
                foreach (int n in numbers)
                {
                    Console.WriteLine(n+" ");
                }
                Console.ReadKey();
            }
        }
    }
}
