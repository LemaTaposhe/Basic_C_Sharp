using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LembdaExpression
{
    internal class Program
    {
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int age { get; set; }
        }
        static void Main(string[] args)
        {
            List<Person> Person = new List<Person>()
            {
                new Person() { Id = 1, Name = "Lema", age = 25 },
                new Person() { Id = 2, Name = "Anwer", age = 41 },
                new Person() { Id = 3, Name = "Munir", age = 26 },
                new Person() { Id = 4, Name = "Ajhhf", age = 30 },
         };
            Person match = Person.Find((Person p) => { return p.Id == 3; });
            Console.WriteLine("ID:{0}\nName:{1}\nAge:{2}",match.Id,match.Name,match.age);
        }
    }
}
