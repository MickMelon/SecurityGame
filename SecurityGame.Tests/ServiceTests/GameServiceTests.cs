using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityGame.Enums;
using SecurityGame.Repositories;
using SecurityGame.Services;

namespace SecurityGame.Tests.ServiceTests
{
    [TestClass]
    public class GameServiceTests
    {
        [TestMethod]
        public void StartGame_ShouldPopulateVariables()
        {
            // Arrange
            var questionRepository = new MockQuestionRepository();
            var gameService = new GameService(questionRepository);

            // Act
            gameService.StartGame();

            // Assert
            Assert.IsTrue(
                gameService.CurrentQuestion != null &&
                gameService.Player != null &&
                gameService.QuestionCount == 0);
        }

        [TestMethod]
        public void SubmitAnswer_WrongAnswer_ShouldReturnIncorrectOrGameEnd()
        {
            // Arrange
            var questionRepository = new MockQuestionRepository();
            var gameService = new GameService(questionRepository);

            // Act
            gameService.StartGame();
            var result = gameService.SubmitAnswer(gameService.CurrentQuestion.WrongAnswer);

            // Assert
            Assert.IsTrue(result == AnswerResult.Wrong || result == AnswerResult.GameEnd);
        }

        [TestMethod]
        public void SubmitAnswer_CorrectAnswer_ShouldReturnCorrect()
        {
            // Arrange
            var questionRepository = new MockQuestionRepository();
            var gameService = new GameService(questionRepository);

            // Act
            gameService.StartGame();
            var result = gameService.SubmitAnswer(gameService.CurrentQuestion.CorrectAnswer);

            // Assert
            Assert.AreEqual(AnswerResult.Correct, result);
        }

        [TestMethod]
        public void SubmitAnswer_InvalidAnswer_ShouldReturnIncorrectOrGameEnd()
        {
            // Arrange
            var questionRepository = new MockQuestionRepository();
            var gameService = new GameService(questionRepository);

            // Act
            gameService.StartGame();
            var result = gameService.SubmitAnswer("A");

            // Assert
            Assert.IsTrue(result == AnswerResult.Wrong || result == AnswerResult.GameEnd);
        }
    }
}
