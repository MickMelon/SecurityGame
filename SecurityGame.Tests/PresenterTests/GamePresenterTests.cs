using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityGame.Presenters;
using SecurityGame.Repositories;
using SecurityGame.Services;
using SecurityGame.Views;

namespace SecurityGame.Tests.PresenterTests
{
    [TestClass]
    public class GamePresenterTests
    {
        [TestMethod]
        public void UpdateGameView_ShouldPopulateViewWithCorrectGameVariables()
        {
            // Arrange
            var mockRepository = new MockQuestionRepository();
            var gameService = new GameService(mockRepository);
            var parentView = new ParentView();
            var gameView = new GameView();
            var gameOverView = new GameOverView();
            var gamePresenter = new GamePresenter(parentView, gameService, gameView, gameOverView);

            // Act
            gameService.StartGame();
            gamePresenter.UpdateGameView();

            // Assert
            Assert.IsTrue(
                gameView.Virus == gameService.Player.Virus &&
                gameView.Reputation == gameService.Player.Reputation &&
                gameView.Question.Equals(gameService.CurrentQuestion.Content) &&
                gameView.QuestionCount == gameService.QuestionCount &&
                ((gameView.Answer1.Equals(gameService.CurrentQuestion.CorrectAnswer) && gameView.Answer2.Equals(gameService.CurrentQuestion.WrongAnswer))
                || (gameView.Answer1.Equals(gameService.CurrentQuestion.WrongAnswer) && gameView.Answer2.Equals(gameService.CurrentQuestion.CorrectAnswer)))
                );
        }
    }
}
