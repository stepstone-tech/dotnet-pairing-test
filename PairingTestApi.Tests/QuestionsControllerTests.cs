using Microsoft.AspNetCore.Mvc;
using PairingTestApi.Controllers;

namespace PairingTestApi.Tests
{
    public class Tests
    {
        private QuestionsController _questionsController;

        [SetUp]
        public void Setup()
        {
            _questionsController = new QuestionsController();
        }

        [TearDown]
        public void TearDown()
        {
            _questionsController.Dispose();
        }

        [Test]
        public void GetQuestions_Returns_Ok()
        {
            var result = _questionsController.Index() as ViewResult;

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.Null);
        }
    }
}