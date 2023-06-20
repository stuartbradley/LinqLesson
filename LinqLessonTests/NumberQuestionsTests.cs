using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLessonTests
{
    public class NumberQuestionsTests
    {
        private NumberQuestions _questions;
        [SetUp]
        public void Setup()
        {
            Data data = new Data();
            _questions = new NumberQuestions(data.Numbers);
        }
        [Test]
        public void GetSmallestTest()
        {
            var answer = _questions.GetSmallest();
            answer.ShouldBe(1);
        }
        [Test]
        public void GetLargestTest()
        {
            var answer = _questions.GetLargest();
            answer.ShouldBe(11);
        }
        [Test]
        public void GetOrderedListTest()
        {
            var answer = _questions.GetOrderedList();
            answer[0].ShouldBe(1);
            answer.Last().ShouldBe(11);
        }
        [Test]
        public void GetMeanTest()
        {
            _questions.GetMean().ShouldBe(4);
        }







    }
}
