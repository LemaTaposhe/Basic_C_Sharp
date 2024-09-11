using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber_01
{
    internal class Program
    {
        static Random Random = new Random();
        public static List<int>GetRandomNumber(int myNumber) 
        {
        List<int> list = new List<int>();
            for (int i=0;i<myNumber; i++) 
            {
                int num;
                do
                {
                num=Random.Next();
                }
                while(list.Contains(num));
                list.Add(num);

            }
            return list;
        }
        static void Main(string[] args)
        {
            List<int>myVal=GetRandomNumber(10);
            Console.WriteLine("Result For "+myVal.Count);
            Console.WriteLine("-------------");
            myVal.ForEach(Console.WriteLine);
        }
    }
}
