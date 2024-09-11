using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_DeferredExecution
{
    class Student
    {
        public int Id;
        public string Name;
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student(){Id=1, Name="Lima", Age=25},
                new Student(){Id=2, Name="Anower", Age=18},
                new Student(){Id=3, Name="Sojib", Age=15},
                new Student(){Id=4, Name="Ekram", Age=23},
                new Student(){Id=5, Name="Jobaida", Age=14}
            };

            var teenAgerStud = from student in studentList
                               where student.Age > 14 && student.Age < 21
                               select student;

            foreach (Student tStud in teenAgerStud)
            {
                Console.WriteLine("Student Name: {0}", tStud.Name);
            }

            Console.WriteLine();
            Console.WriteLine("==================");
            studentList.Add(new Student() { Id = 10, Name = "Sohail", Age = 16 });
            foreach (Student tStud in teenAgerStud)
            {
                Console.WriteLine("Student Name: {0}", tStud.Name);
            }

        }
    }
}
