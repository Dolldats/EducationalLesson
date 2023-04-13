using EducationalLesson.Entities;
using System.Linq.Expressions;

namespace EducationalLesson.Repositories.Interface
{
    public interface IQuestionRepository : IRepository<Question>
    {
        List<Question> GetQuestions();
        List<Question> GetQuestions(Expression<Func<Question, bool>> expression);
        Question GetQuestion(Expression<Func<Question, bool>> expression);
        List<SubjectQuestion> GetQuestionByCategoryId(string id);
        List<SubjectQuestion> SelectQuestionByCategory();
    }
}
