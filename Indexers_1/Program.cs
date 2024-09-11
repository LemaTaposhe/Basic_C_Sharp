using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_1
{
    class MyClass
    {
        private string[] data = new string[6];
        public string this[int myIndex]
        { 
        get
            { 
                return data[myIndex];
            }
         set 
            { 
                data[myIndex] = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc= new MyClass();
            mc[0] = "Lema";
            mc[1] = "Taposhe";
            mc[2] = "Chemistry";
            mc[3] = "Chattogram";
            mc[4] = "Satkhira";
            mc[5] = "Bangladesh";
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", mc[0], mc[1], mc[2], mc[3], mc[4], mc[5]);

        }
    }
}
