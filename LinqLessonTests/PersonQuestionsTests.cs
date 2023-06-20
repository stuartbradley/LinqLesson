using LinqLesson;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLessonTests
{
    public class PersonQuestionsTests
    {
        private PeopleQuestions _peopleQuestions;
        [SetUp]
        public void Setup()
        {
            Data data = new Data();
            _peopleQuestions = new PeopleQuestions(data.People);
        }

        [Test]
        public void GetAgeOfAndreaJonesTest()
        {
            _peopleQuestions.GetAgeOfAndreaJones().ShouldBe(58);
        }

        [Test]
        public void GetHeightOfStuartBradleyTest()
        {
            _peopleQuestions.GetHeightOfStuartBradley().ShouldBe(5.7m);
        }
        [Test]
        public void GetNamesOfEveryoneWhoIs5ft8Test()
        {
            var ans = _peopleQuestions.GetNamesOfEveryoneWhoIs5ft8();
            ans[0].ShouldBe("Simon Williams");
            ans[1].ShouldBe("David Cronshaw");
        }
        [Test]
        public void GetCountOfMenTest()
        {
            _peopleQuestions.GetCountOfMen().ShouldBe(5);
        }
        [Test]
        public void GetNameOfPerson0YearsOldTest()
        {
            _peopleQuestions.GetNameOfPerson0YearsOld().ShouldBe("Miles Darlow");
        }
        [Test]
        public void HowManyPeopleBelow6ftTest()
        {
            _peopleQuestions.HowManyPeopleBelow6ft().ShouldBe(5);
        }

    }
}
