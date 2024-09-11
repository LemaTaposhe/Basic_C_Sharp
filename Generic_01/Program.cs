using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_01
{
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T getItem(int i)
        {
            return array[i];
        }

        public void setItem(int i, T item)
        {
            array[i] = item;
        }

    }

    internal class Tester
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> mga_int = new MyGenericArray<int>(5);
            // Setting Value
            for (int c = 0; c < 5; c++)
            {
                mga_int.setItem(c, c * 10);
            }
            // Get the Value
            for (int c = 0; c < 5; c++)
            {
                Console.Write(mga_int.getItem(c) + "  ");
            }

            MyGenericArray<char> mga_char = new MyGenericArray<char>(5);
            // Setting Value
            for (int c = 0; c < 5; c++)
            {
                mga_char.setItem(c, (char)(c * 10));
            }
            // Get the Value
            for (int c = 0; c < 5; c++)
            {
                Console.Write(mga_char.getItem(c) + "  ");
            }
        }
    }
}
