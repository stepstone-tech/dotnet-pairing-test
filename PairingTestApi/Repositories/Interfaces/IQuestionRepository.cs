using PairingTestApi.Models;

namespace PairingTestApi.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        public IEnumerable<Question> GetQuestions();
    }
}
