using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityGame.Models;
using SecurityGame.Presenters;
using SecurityGame.Repositories;
using SecurityGame.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SecurityGame.Tests.PresenterTests
{
    [TestClass]
    public class AdminPresenterTests
    {
        [TestMethod]
        public void SaveQuestion_ShouldSaveWithCorrectVariables()
        {
            // Arrange
            var parentView = new ParentView();
            var adminView = new AdminView();
            var questionView = new QuestionManagerView();
            var questionRepository = new MockQuestionRepository();
            var adminPresenter = new AdminPresenter(parentView, questionRepository, adminView, questionView);

            // Act
            adminPresenter.SaveQuestion();
            var question = questionRepository.GetQuestion(questionView.SelectedQuestion + 1);

            // Assert
            Assert.IsTrue(
                questionView.Content.Equals(question.Content, StringComparison.OrdinalIgnoreCase) &&
                questionView.CorrectAnswer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase) &&
                questionView.WrongAnswer.Equals(question.WrongAnswer, StringComparison.OrdinalIgnoreCase) &&
                questionView.CorrectVirusChange == question.CorrectVirusChange &&
                questionView.CorrectReputationChange == question.CorrectReputationChange &&
                questionView.WrongVirusChange == question.WrongVirusChange &&
                questionView.WrongReputationChange == question.WrongReputationChange);
        }

        [TestMethod]
        public void UpdateQuestionListView_ShouldPopulateViewWithCorrectVariables()
        {
            // Arrange
            var parentView = new ParentView();
            var adminView = new AdminView();
            var questionView = new QuestionManagerView();
            var questionRepository = new MockQuestionRepository();
            var adminPresenter = new AdminPresenter(parentView, questionRepository, adminView, questionView);
            var questionsFromDatabase = questionRepository.GetAllQuestions().ToList();
            var questionContents = new List<string>();
            foreach (var question in questionsFromDatabase)
                questionContents.Add($"[{question.ID}] {question.Content}");

            // Act
            adminPresenter.UpdateQuestionListView();

            // Assert
            CollectionAssert.AreEqual(questionView.QuestionList.ToList(), questionContents.ToList());
        }

        [TestMethod]
        public void UpdateQuestionView_ShouldPopulateViewWithCorrectVariables()
        {
            // Arrange
            var parentView = new ParentView();
            var adminView = new AdminView();
            var questionView = new QuestionManagerView();
            var questionRepository = new MockQuestionRepository();
            var adminPresenter = new AdminPresenter(parentView, questionRepository, adminView, questionView);
            var question = questionRepository.GetQuestion(questionView.SelectedQuestion + 1);

            // Act
            adminPresenter.UpdateQuestionView();

            // Assert
            Assert.IsTrue(
                questionView.Content.Equals(question.Content, StringComparison.OrdinalIgnoreCase) &&
                questionView.CorrectAnswer.Equals(question.CorrectAnswer, StringComparison.OrdinalIgnoreCase) &&
                questionView.WrongAnswer.Equals(question.WrongAnswer, StringComparison.OrdinalIgnoreCase) &&
                questionView.CorrectVirusChange == question.CorrectVirusChange &&
                questionView.CorrectReputationChange == question.CorrectReputationChange &&
                questionView.WrongVirusChange == question.WrongVirusChange &&
                questionView.WrongReputationChange == question.WrongReputationChange);
        }
    }
}
