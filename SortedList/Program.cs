using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,int>info= new SortedList<string,int>();
            //Fill the Sorted List
            info.Add("Lema", 25);
            info.Add("Lema1", 35);
            info.Add("Lema2", 45);
            info["Abcd"]= 24;
            info["Abcd2"] = 24;
            Console.WriteLine("========Original========");
            //Iterate Data
            foreach (KeyValuePair<string, int> n in info)
            { 
            string name=n.Key;
            int age=n.Value;
                Console.WriteLine("Name:{0},Age:{1}", name, age);
            }
        }
    }
}
