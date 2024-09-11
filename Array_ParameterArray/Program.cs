using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ParameterArray
{
    class MyClass
    {
        public int AddElement(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr) 
            { 
            sum += i;   
            }
            return sum; 
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();    
            int myvar=myClass.AddElement(1,5,8,9,7);
            Console.WriteLine("The Sum Is: {0} " , myvar);
        }
    }
}
