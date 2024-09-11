using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorInMethod
{
    internal class Program
    {
        public static IEnumerable<string> GetProducts()
        {
            foreach (var item in Enumerable.Range(1, 5))
            { 
            yield return"Product: "+ item.ToString();

            }
        }
        static void Main(string[] args)
        {
            foreach(var i in GetProducts())
            {
                Console.WriteLine(i);
            }

        }
    }
}
