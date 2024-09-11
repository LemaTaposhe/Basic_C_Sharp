using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            //Fill the linklist
            foreach (int number in new int[10] { 10, 9, 2, 7, 5, 6, 4, 2, 3, 15 })
            { 
            ll.AddLast(number);
            }
            Console.WriteLine( "=========Orginal=========");
            //Iterate Data
            //foreach (int n in ll ) 
            //{
                //Console.WriteLine(n +" ");
            //}
            for(LinkedListNode<int>node= ll.First; node!=null; node = node.Next) 
            {
                Console.WriteLine(node.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
            //ll.Remove(7);
            ll.RemoveFirst();
            Console.WriteLine("========After Modify========");
            //Iterate Data
            foreach (int n in ll)
            {
                Console.WriteLine(n +" ");
            }
        }
    }
}
