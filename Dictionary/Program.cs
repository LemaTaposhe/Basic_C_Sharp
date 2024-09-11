using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> info = new Dictionary<string, int>();

            // Fill the Dictionary
            info.Add("Lima", 25);
            info.Add("Anower", 45);
            info["Sohail"] = 24;
            info["Sojib"] = 34;
            info.Add("Lima2", 45);

            Console.WriteLine("=========Original===========");
            // Iterate Data
            foreach (KeyValuePair<string, int> n in info)
            {
                string name = n.Key;
                int age = n.Value;
                Console.WriteLine("Name: {0}, Age: {1}", name, age);
            }
        }
    }
}
