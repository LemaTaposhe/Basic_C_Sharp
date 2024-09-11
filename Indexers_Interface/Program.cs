using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_Interface
{

        interface IPerl
        {
            int this[int number] { get; set; }
        }
        class InterfaceImplementer : IPerl
        {
            int[] _data = { 0, 10, 20, 30 };
            public int this[int number]
            {
                get
                {
                    return _data[number];

                }
                set
                {
                    _data[number] = value;
                }

            }
            
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerl perl=new InterfaceImplementer();
            Console.WriteLine(perl[0]);
            Console.WriteLine(perl[1]);
            Console.WriteLine(perl[2]);
            Console.WriteLine(perl[3]);
            Console.WriteLine("====================");
            perl[0] = -1;
            Console.WriteLine(perl[0]);

        }
    }
}
