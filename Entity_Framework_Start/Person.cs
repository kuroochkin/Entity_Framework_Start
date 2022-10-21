using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Start
{
    public class Person
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person(int id, string? surname, string? name, int age)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Age = age;
        }
    }
}
