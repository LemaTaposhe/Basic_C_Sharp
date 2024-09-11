using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String & StringBuilder
            //String Imutable(Non-Updateable)
            //StringBuilder Mutable(Updateable)

            //string str = "NVIT";
            //str = str + "CTG";
            //str = "IDB"; 

            //  Console.WriteLine(str);
            //StringBuilder sb= new StringBuilder("NVIT");
            //sb.Append(" CTG");
            //sb.Append(" IDB");
            //sb.Insert(2, " BD ");
            //Console.WriteLine(sb);
            // ----------------Stack To Heap------------------------

            // int (value type)=> Created on STACK
            int x = 10;
            int y = x;
            //Ref.Type=> Created on HEAP
            //Stack To HEAP
            //Boxing
            object obj01;
            obj01 = x;

            //Ref.Type-> Value Type
            //Heap to 



        }
    }
}
