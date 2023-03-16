using PairingTest.Models;

namespace PairingTest.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        public IEnumerable<Question> GetQuestions();
    }
}
