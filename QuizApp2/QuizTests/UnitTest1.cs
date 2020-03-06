using NUnit.Framework;
using ConsoleApp;

namespace QuizTests
{
    public class Tests
    {
        private QuestionCL _qcl;
        [SetUp]
        public void Setup()
        {
            _qcl = new QuestionCL();
        }

        [TestCase(1)]
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(25)]
        [TestCase(29)]
        public void ValidQuestionNumberTest(int newcurrentQ)
        {
            //act
            _qcl.currentQ = newcurrentQ;
           
            //Assert
            Assert.AreEqual(newcurrentQ, _qcl.currentQ);
        }
        [TestCase(-3)]
        [TestCase(-5)]
        [TestCase(35)]
        [TestCase(56)]
        [TestCase(48)]
        public void InvalidQuestionNumberTest(int newcurrentQ)
        {
            // arrange
            _qcl.currentQ = 2;
            //act
            _qcl.currentQ = newcurrentQ;
            //Assert
            Assert.AreEqual(newcurrentQ, _qcl.currentQ);
        }
        [TestCase(0, "Which country has a capital that is an anagram of its 7th largest city?")]
        [TestCase(3, "Which three countries are landlocked by one other country ?")]
        public void CorrectQuestionTest(int newQuestionNum,string newQuestion)
        {
            //act
            var message = _qcl.ChangeQuestion();
            //assert
            Assert.AreEqual(newQuestionNum,newQuestion, message);
        }
        //[TestCase()]
        //public void CorrectScore(int newScore)
        //{
        //    //act
        //    //assert
        //}
    }
}