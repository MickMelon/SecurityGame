using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SecurityGame.Repositories
{
    public class EfQuestionRepository : IQuestionRepository
    {
        /// <summary>
        /// Get all the questions from the database.
        /// </summary>
        /// <returns>All the questions.</returns>
        public IEnumerable<Question> GetAllQuestions()
        {
            using (var context = new GameContext())
            {
                return context.Questions.ToList();
            }
        }

        /// <summary>
        /// Get a question from the database by ID.
        /// </summary>
        /// <param name="id">The Question ID.</param>
        /// <returns>The Question or null.</returns>
        public Question GetQuestion(int id)
        {
            using (var context = new GameContext())
            {
                return context.Questions.Where(q => q.ID == id).FirstOrDefault();
            }
        }

        /// <summary>
        /// Updates a Question in the database.
        /// </summary>
        /// <param name="question">The Question to be saved.</param>
        public void SaveQuestion(Question question)
        {
            using (var context = new GameContext())
            {
                context.Questions.AddOrUpdate(question);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Adds a Question to the database.
        /// </summary>
        /// <param name="question">The Question to be added.</param>
        public void AddQuestion(Question question)
        {
            using (var context = new GameContext())
            {
                context.Questions.Add(question);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a Question from the database.
        /// </summary>
        /// <param name="question">The Question to be deleted.</param>
        public void DeleteQuestion(Question question)
        {
            using (var context = new GameContext())
            {
                var questionToDelete = context.Questions.Where(q => q.ID == question.ID).FirstOrDefault();
                context.Questions.Remove(questionToDelete);
                context.SaveChanges();
            }
        }
    }
}
