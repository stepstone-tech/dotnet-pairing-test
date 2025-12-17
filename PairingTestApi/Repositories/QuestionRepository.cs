using PairingTestApi.Models;
using PairingTestApi.Repositories.Interfaces;

namespace PairingTestApi.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        //This method mocks the data which would usually come from a database
        public IEnumerable<Question> GetQuestions()
        {
            return new List<Question>
            {
                new Question() { QuestionId = 1, QuestionText = "What is the capital of Cuba?"},
                new Question() { QuestionId = 2, QuestionText = "What is the capital of France?"},
                new Question() { QuestionId = 3, QuestionText = "What is the capital of Poland?"},
                new Question() { QuestionId = 4, QuestionText = "What is the capital of Germany?"}
            };
        }
    }
}
