using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var anonymousData = new
            {
               // firstName = "Lema",
            //lastName = "Taposhe"

            };
           // Console.WriteLine("Name: " + anonymousData.firstName + " " + anonymousData.lastName);
            //Dynamic Type
            dynamic dynamicData = 10;
            Console.WriteLine("Data of dynamic Type: " + dynamicData);
            dynamicData = "Kazi Anwer";
            Console.WriteLine("Data of dynamic Type: " + dynamicData);
            dynamicData = 100.9; 
            Console.WriteLine("Data of dynamic Type: " + dynamicData);
            dynamicData = "A";
            Console.WriteLine("Data of dynamic Type: " + dynamicData);
        }


    }
}
