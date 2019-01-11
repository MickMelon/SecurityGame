using SecurityGame.Constants;
using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using SecurityGame.Views;
using SecurityGame.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecurityGame.Presenters
{
    public class AdminPresenter : Presenter
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IAdminView _adminView;
        private readonly IQuestionManagerView _questionManagerView;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminPresenter"/> class.
        /// </summary>
        /// <param name="parentView">The parent view.</param>
        /// <param name="questionRepository">The question repository.</param>
        /// <param name="adminView">The admin view.</param>
        /// <param name="questionManagerView">The question manager view.</param>
        public AdminPresenter(ParentView parentView,
            IQuestionRepository questionRepository,
            IAdminView adminView,
            IQuestionManagerView questionManagerView) : base(parentView)
        {
            _questionRepository = questionRepository;
            _adminView = adminView;
            _questionManagerView = questionManagerView;

            _adminView.Presenter = this;
            _questionManagerView.Presenter = this;
            
            UpdateQuestionListView();
        }

        /// <summary>
        /// Saves the selected question from the view in the database.
        /// </summary>
        public void SaveQuestion()
        {
            int questionId = GetQuestionId(_questionManagerView.SelectedQuestion);
            var question = _questionRepository.GetQuestion(questionId);

            question.Content = _questionManagerView.Content;
            question.CorrectAnswer = _questionManagerView.CorrectAnswer;
            question.WrongAnswer = _questionManagerView.WrongAnswer;
            question.CorrectVirusChange = _questionManagerView.CorrectVirusChange;
            question.CorrectReputationChange = _questionManagerView.CorrectReputationChange;
            question.WrongVirusChange = _questionManagerView.WrongVirusChange;
            question.WrongReputationChange = _questionManagerView.WrongReputationChange;

            _questionRepository.SaveQuestion(question);
        }

        /// <summary>
        /// Adds a new question to the database with default 
        /// values.
        /// </summary>
        public void AddQuestion()
        {
            var question = new Question()
            {
                Content = "New question",
                CorrectAnswer = "Correct answer",
                WrongAnswer = "Incorrect answer",
                CorrectVirusChange = 0,
                CorrectReputationChange = 0,
                WrongVirusChange = 0,
                WrongReputationChange = 0
            };

            _questionRepository.AddQuestion(question);
        }

        /// <summary>
        /// Deletes the currently selected question from 
        /// the database.
        /// </summary>
        public void DeleteQuestion()
        {
            int questionId = GetQuestionId(_questionManagerView.SelectedQuestion);
            var question = _questionRepository.GetQuestion(questionId);

            _questionRepository.DeleteQuestion(question);         
            _questionManagerView.SelectedQuestion = 0;

            UpdateQuestionView();
            UpdateQuestionListView();           
        }

        /// <summary>
        /// Updates the list of questions on the view.
        /// </summary>
        public void UpdateQuestionListView()
        {
            var questionsFromDatabase = _questionRepository.GetAllQuestions().ToList();
            var questionContents = new List<string>();
            int selectedQuestion = _questionManagerView.SelectedQuestion >= 0 
                ? _questionManagerView.SelectedQuestion : 0;

            if (questionsFromDatabase.Count > 0)
                foreach (var question in questionsFromDatabase)
                    questionContents.Add($"[{question.ID}] {question.Content}");
            else
                questionContents.Add(Messages.NO_QUESTIONS);

            _questionManagerView.QuestionList = questionContents;
            _questionManagerView.SelectedQuestion = selectedQuestion;
        }

        /// <summary>
        /// Updates the selected question fields on the view.
        /// </summary>
        public void UpdateQuestionView()
        {
            int questionId = GetQuestionId(_questionManagerView.SelectedQuestion);
            var question = _questionRepository.GetQuestion(questionId);

            if (question == null) return;

            _questionManagerView.Content = question.Content;
            _questionManagerView.CorrectAnswer = question.CorrectAnswer;
            _questionManagerView.WrongAnswer = question.WrongAnswer;
            _questionManagerView.CorrectReputationChange = question.CorrectReputationChange;
            _questionManagerView.CorrectVirusChange = question.CorrectVirusChange;
            _questionManagerView.WrongReputationChange = question.WrongReputationChange;
            _questionManagerView.WrongVirusChange = question.WrongVirusChange;
        }

        /// <summary>
        /// Get the question ID for the question in the specified 
        /// index. The ID is contained in square brackets in the 
        /// question content.
        /// </summary>
        /// <param name="questionIndex">The index of the question in the view list.</param>
        /// <returns>The question ID.</returns>
        private int GetQuestionId(int questionIndex)
        {
            string questionContent = _questionManagerView.QuestionList[questionIndex];
            int bracketIndex = questionContent.IndexOf("]");

            if (bracketIndex == -1) return -1;

            return int.Parse(questionContent.Substring(1, bracketIndex - 1));
        }
    }
}
