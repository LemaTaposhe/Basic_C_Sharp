using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            //int[] a = new int[10] {10,9,8,7,5,6,4,2,3,15};
            // Fill the list
            //foreach (int number in a)
            foreach (int number in new int[10] { 10, 9, 2, 7, 5, 6, 4, 2, 3, 15 })
            {
                list.Add(number);
            }

            Console.WriteLine("=========Original===========");
            Console.WriteLine("=========Foreach========");
            // Iterate Data
            foreach (int n in list)
            {
                Console.Write(n + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //list.Insert(0, 199);
            //list.Insert(list.Count - 1, 299);
            //list.Remove(9);
            list.RemoveAt(1);


            Console.WriteLine("============After Modify============");

            Console.WriteLine("=========Foreach========");
            // Iterate Data
            foreach (int n in list)
            {
                Console.Write(n + "  ");
            }

            //Console.WriteLine("\n=========For========");
            //for(int i=0; i<list.Count; i++)
            //{
            //    Console.Write(list[i] + "  ");
            //}

            Console.ReadKey();
        }
    }
}
