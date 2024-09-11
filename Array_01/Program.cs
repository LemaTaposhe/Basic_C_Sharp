using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integer Array
            int[] arr_01 = new int[4];
            arr_01[0] = 84;
            arr_01[1] = 74;
            arr_01[3] = 34;
            arr_01[2] = 21;
            //arr_01[04]=185;
            //Array.Sort(arr_01);//(Assading or desanding)
           // Array.Reverse(arr_01);
            for (int i = 0;i<arr_01.Length;i++) 
            {
               // Console.WriteLine(arr_01[i]);
            }
            Console.WriteLine("===================");
            //String Array
            string[] week = new string[7];
            week[0] = "Saturday";
            week[1] = "Sunday";
            week[2] = "Monduy";
            week[3] = "Tuesday";
            week[4] = "Wednesday";
            week[5] = "Thursday";
            week[6] = "Friday";
            for (int i = 0; i < week.Length; i++)
            {
                //Console.WriteLine(week[i]);
            }
            //Console.WriteLine(week[2]);
            //Char Array
            char[] charArr= new char[4];
            charArr[0]= 'A';
            charArr[1] = 'B';
            charArr[2] = 'C';
            charArr[3] ='D';
            for (int i = 0;i <=charArr.Length-1;i++)
            {
               // Console.WriteLine(charArr[i]);
            }

            Array.Resize(ref charArr, 20);
            for (int i = 0; i < charArr.Length; i++)
            {
                //Console.WriteLine(charArr[i]);
            }
            int[] arr_003 = { 3, 1, 4, 5, 2, 6 };
            foreach (var i in arr_003)
            {
                //Console.WriteLine(i);
            }

            // Integer Array
            int[] arr_101 = new int[] { 3, 1, 4, 5, 2, 6 };
            Array.Sort(arr_101);
            Array.Reverse(arr_101);
            //foreach (int i in arr_01)
            foreach (var i in arr_101)
            {
                //Console.WriteLine(i);
            }
            //String Array
            string[] arr_102 = new string[] { "d", "b", "e", "a", "c" };
            Array.Sort(arr_102);
            //Array.Reverse(arr_102);
            //foreach (string i in arr_102)
            foreach (var i in arr_102)
            {
                //Console.WriteLine(i);
            }
            //Multiple data type in an array
            object[] arr_150 = new object[4];
            arr_150[0] = 10;
            arr_150[1] = "Munir";
            arr_150[2]=DateTime.Now;
            arr_150[3] = true;
            for (int i = 0; i < arr_150.Length; i++)
            {
                Console.WriteLine(arr_150[i]);
            }
            //Array List
            ArrayList al=new ArrayList();
            al.Add(10);
            al.Add(54);
            al.Add(74);
            al.Add(12);
            //Console.WriteLine("capacity :{0}",al.Capacity);
            //Console.WriteLine("Count:{0}", al.Count);
           // Console.WriteLine("The Original Content Are-----------");
            foreach (var i in al)
            { 
           // Console.Write(i+" ");
            }
            //Console.Write();

            //Copy
            //int[] anower = { 2, 3, 4, 5 };
            //int[] copyAnwer = anower;
            //copyAnwer[2] = 49;
            //anower[2] = 49;
            //Console.WriteLine("The values for anower(variable)are:" + anower[2]);
            //Console.WriteLine("The values for copyAnwer(variable)are:" + anower[2]);
            //Clone
            int[] anower = { 2, 3, 4, 6 };
            int[]copyAnower = (int[])anower.Clone();    
            //copyAnwer[2]=49;


        }

    }
}
