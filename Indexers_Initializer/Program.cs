using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_Initializer
{
    internal class Program
    {
        class Farm
        {
            string[]_animal=new string[10];
            public string this[int number]
            { 
            get
                {
                    return _animal[number]; 
                } 
            set 
                {
                    _animal[number]=value;
                }
            }
        }
        static void Main(string[] args)
        {
            Farm farm = new Farm() { [1] = "Cat", [3] = "Dog", [5] = "Bird" };
            Console.WriteLine(farm[3]);
        }
    }
}
