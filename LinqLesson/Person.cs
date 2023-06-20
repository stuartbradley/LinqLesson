using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    public class Person
    {
        public Person(string name, decimal height, int age, Gender gender)
        {
            Name = name;
            Height = height;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public Decimal Height { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
