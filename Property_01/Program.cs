using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_01
{
    class Student
    {
        string code = "N/A";
        string name = "Unknown";
        int age = 0; 
        public string Code 
        {
            get 
            { 
                return code; 
            } 
            set 
            {
                code = value; 
            } 
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code: " + Code + "Name: " + Name + "Age: " + age;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Code = "101";
            student.Name = "Monir";
            student.Age = 25;
            Console.WriteLine("Student Information: {0}",student);
        }
    }
}
