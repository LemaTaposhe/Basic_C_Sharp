using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_method_01
{
    public class Class1
    {
        public int w = 1;
        public int b = 2;
    }
    internal class Program:Class2
    {
        static void Main(string[] args)
        {
       Program n = new Program();
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();

   
            int m = 7;
            Console.WriteLine(m+ Class2.p);


            int x = 10;
            int y = 5;
            Class2.Multi(y, x);
            Console.WriteLine(Class2.Sum(x,y));
            Console.WriteLine(Class2.Sub(x,y ));

        }
    }


    public class Class2 : Class1
    {
        public static int p = 5;
        public static int q = 12;
    

        public static int Sum(int a,int b)
        {
            return a + b; 
        }
        public static void Multi(int a,int b)
        {
            Console.WriteLine(a*b);
        }
        public static int Sub(int a, int b)
        { 
            return a-b;
        }


    } 
    

}

