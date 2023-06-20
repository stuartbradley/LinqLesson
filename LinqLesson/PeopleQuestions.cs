using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLesson
{
    public class PeopleQuestions
    {
        private readonly List<Person> _people;

        public PeopleQuestions(List<Person> people)
        {
            _people = people;
        }

        public int GetAgeOfAndreaJones()
        {
            return 0;
        }

        public decimal GetHeightOfStuartBradley()
        {
            return 0m;
        }

        public List<string> GetNamesOfEveryoneWhoIs5ft8()
        {
            return null;
        }

        public int GetCountOfMen()
        {
            return 0;
        }

        public string GetNameOfPerson0YearsOld()
        {
            return "";
        }

        public int HowManyPeopleBelow6ft()
        {
            return 5;
        }
    }
}
