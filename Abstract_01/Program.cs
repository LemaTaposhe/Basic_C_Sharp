using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_01
{

    abstract class Shape
    {
        protected float l, b;
        public abstract float Area();
        public abstract float Circumference();
    }
    class Rectangle : Shape
    {
        public void GetLRB()
        {
            Console.Write("Enter The values of Length: ");
            l = float.Parse(Console.ReadLine());
            Console.Write("Enter The values of Breadth: ");
            b = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return l * b;
        }
        public override float Circumference()
        {
            return 2 * (l + b);
        }
    }
    class Rectangle2 : Shape
    {
        public void GetLRB()
        {
            Console.Write("Enter The values of Length(2): ");
            l = float.Parse(Console.ReadLine());
            Console.Write("Enter The values of Breadth(2): ");
            b = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return l * b*3;
        }
        public override float Circumference()
        {
            return 4 * (l + b);
        }
        internal class Program
        {

            public static void Calculate(Shape s)
            {
                Console.WriteLine("Area: " + s.Area());
            }
            static void Main(string[] args)
            {
                Rectangle r= new Rectangle();
                Rectangle2 r2=  new Rectangle2();
                r.GetLRB();
                Calculate(r);
                Console.WriteLine("===========================");
                r2.GetLRB();
                Calculate(r2);
            }
        }
    }
}