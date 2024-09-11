using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        delegate int del(int i);
        static void Main(string[] args)
        {

            del myDelegate = y => y * y;
            int j = myDelegate(5);
            Console.WriteLine(j);
        }
    }
}
