using SecurityGame.Models;
using System.Collections.Generic;

namespace SecurityGame.Repositories.Interfaces
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetAllQuestions();
        Question GetQuestion(int id);
        void SaveQuestion(Question question);
        void AddQuestion(Question question);
        void DeleteQuestion(Question question);
    }
}
