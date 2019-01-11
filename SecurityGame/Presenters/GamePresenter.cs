using SecurityGame.Enums;
using SecurityGame.Services;
using SecurityGame.Views;
using SecurityGame.Views.Interfaces;
using System;

namespace SecurityGame.Presenters
{
    public class GamePresenter : Presenter
    {
        private readonly GameService _gameService;
        private readonly IGameView _gameView;
        private readonly IGameOverView _gameOverView;

        private static Random _random = new Random();

        /// <summary>
        /// Initializes a new instance of the <see cref="GamePresenter"/> class.
        /// </summary>
        /// <param name="gameService">The game service.</param>
        /// <param name="gameView">The game view.</param>
        public GamePresenter(
            ParentView parentView,
            GameService gameService,
            IGameView gameView,
            IGameOverView gameOverView) : base(parentView)
        {
            _gameService = gameService;
            _gameView = gameView;
            _gameOverView = gameOverView;

            _gameView.Presenter = this;
            _gameOverView.Presenter = this;
        }

        /// <summary>
        /// Displays the game view to the user.
        /// </summary>
        public bool StartGame()
        {
            if (!_gameService.StartGame()) return false;
            UpdateGameView();
            return true;
        }


        /// <summary>
        /// Updates the game view with the current game variables 
        /// held in the game service.
        /// </summary>
        public void UpdateGameView()
        {
            _gameView.Virus = _gameService.Player.Virus;
            _gameView.Reputation = _gameService.Player.Reputation;
            _gameView.Question = _gameService.CurrentQuestion.Content;
            _gameView.QuestionCount = _gameService.QuestionCount;

            // Randomise the order in which the answers are displayed on the view
            // so the correct answer is not always in the same place.
            if (_random.Next(10) % 2 == 0)
            {
                _gameView.Answer1 = _gameService.CurrentQuestion.CorrectAnswer;
                _gameView.Answer2 = _gameService.CurrentQuestion.WrongAnswer;
            }
            else
            {
                _gameView.Answer1 = _gameService.CurrentQuestion.WrongAnswer;
                _gameView.Answer2 = _gameService.CurrentQuestion.CorrectAnswer;
            }
        }

        /// <summary>
        /// Submits the user's answer to the question to the
        /// game service.
        /// </summary>
        /// <param name="answer">The user's answer to the question.</param>
        public void SubmitAnswer(string answer)
        {
            var result = _gameService.SubmitAnswer(answer);

            if (result == AnswerResult.GameEnd)
            {
                ShowGameOver();
                return;
            }

            UpdateGameView();
        }
    }
}
