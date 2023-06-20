using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    public class Data
    {
        public List<int> Numbers { get; private set; }
        public List<Person> People { get; private set; }

        public Data()
        {
            Numbers = new List<int>()
            {
                1,2,3,1,4,2,5,6,1,3,5,11,10
            };
            People = new List<Person>()
            {
                new Person( "Stuart Bradley", 5.7m,31, Gender.Male),
                new Person( "Simon Williams", 5.8m,55, Gender.Male),
                new Person( "Andrea Jones", 5.2m,58, Gender.Female),
                new Person( "Miles Darlow", 0.5m,0, Gender.Male),
                new Person( "David Cronshaw", 5.8m,32, Gender.Male),
                new Person( "Chris Brown", 6.1m,31, Gender.Male),
            };

        }
    }
}
