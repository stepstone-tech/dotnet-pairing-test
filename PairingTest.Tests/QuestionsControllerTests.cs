using Microsoft.AspNetCore.Mvc;
using PairingTest.Controllers;

namespace PairingTest.Tests
{
    public class Tests
    {
        private QuestionsController _questionsController;

        [SetUp]
        public void Setup()
        {
            _questionsController = new QuestionsController();
        }

        [Test]
        public void GetQuestions_Returns_Ok()
        {
            var result = _questionsController.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsNull(result.Model);
        }
    }
}