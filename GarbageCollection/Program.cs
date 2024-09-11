using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
   
{
    class MyClass
    { 
    public MyClass() 
        {
            Console.WriteLine("Constructor");
        }
        ~MyClass() 
        {
            Console.WriteLine("Distructor");
        }
        public void Dispose()
        { 
        GC.SuppressFinalize(this);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            try 
            {
                mc = new MyClass();
            }
            finally 
            { 
                mc.Dispose(); 
            }
        }
    }
}
