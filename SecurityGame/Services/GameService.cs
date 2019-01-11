using SecurityGame.Enums;
using SecurityGame.Extensions;
using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SecurityGame.Services
{
    public class GameService
    {
        public Question CurrentQuestion { get; private set; }
        public Player Player { get; private set; }
        public int QuestionCount { get; private set; }

        private List<Question> _unusedQuestions;
        private List<Question> _usedQuestions;

        private readonly IQuestionRepository _questionRepository;

        /// <summary>
        /// Initializes a new instance of <see cref="GameService"/> class.
        /// </summary>
        /// <param name="questionRepository">The question repository.</param>
        public GameService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        /// <summary>
        /// Starts a new game.
        /// </summary>
        public bool StartGame()
        {
            if (!InitializeQuestions()) return false;
            InitializePlayer();
            QuestionCount = 0;
            return true;
        }

        /// <summary>
        /// Called when the player submits an answer. 
        /// </summary>
        /// <param name="answer">The answer to the question</param>
        /// <returns>Result to the answer: correct, incorrect or game end.</returns>
        public AnswerResult SubmitAnswer(string answer)
        {
            var answerResult = CheckAnswer(answer);

            if (IsPlayerDead())
            {
                EndGame();
                return AnswerResult.GameEnd;
            }

            if (IsLastQuestion())
            {
                ResetQuestions();
                ShuffleQuestions();
            }

            NextQuestion();

            return answerResult;
        }

        /// <summary>
        /// Ends the game by clearing all the questions and player.
        /// </summary>
        private void EndGame()
        {
            _unusedQuestions.Clear();
            _usedQuestions.Clear();
            QuestionCount = 0;
            Player = null;
            CurrentQuestion = null;
        }

        /// <summary>
        /// Checks to see if the given answer was correct and
        /// carries out the result.
        /// </summary>
        /// <param name="answer">The given answer to the question.</param>
        /// <returns>Whether the answer is correct.</returns>
        private AnswerResult CheckAnswer(string answer)
        {
            if (answer.Equals(CurrentQuestion.CorrectAnswer))
            {
                ModifyPlayerAttributes(CurrentQuestion.CorrectVirusChange, CurrentQuestion.CorrectReputationChange);
                return AnswerResult.Correct;
            }

            ModifyPlayerAttributes(CurrentQuestion.WrongVirusChange, CurrentQuestion.WrongReputationChange);
            return AnswerResult.Wrong;         
        }

        /// <summary>
        /// Checks if the player reputation is below 1 or if
        /// virus is above 99
        /// </summary>
        /// <returns>Whether the player is dead.</returns>
        private bool IsPlayerDead() => Player.Reputation < 1 || Player.Virus > 99;   

        /// <summary>
        /// Modifies the player attributes and ensures virus does 
        /// not go below 0 and reputation does not go above 100.
        /// </summary>
        /// <param name="virus">The value to change player virus by</param>
        /// <param name="reputation">The value to change player reputation by</param>
        private void ModifyPlayerAttributes(int virus, int reputation)
        {
            Player.Virus += virus;
            Player.Reputation += reputation;

            if (Player.Virus < 0) Player.Virus = 0;
            if (Player.Reputation > 100) Player.Reputation = 100;
        }
        
        /// <summary>
        /// Retrieves all the questions from the database, shuffles them 
        /// and sets the current question.
        /// </summary>
        private bool InitializeQuestions()
        {
            _unusedQuestions = _questionRepository.GetAllQuestions().ToList();
            if (_unusedQuestions.Count <= 0) return false;

            _usedQuestions = new List<Question>();
            ShuffleQuestions();
            CurrentQuestion = _unusedQuestions[0];

            return true;
        }

        /// <summary>
        /// Checks if the current question is the last one.
        /// </summary>
        /// <returns>Whether this is the last question.</returns>
        private bool IsLastQuestion() => _unusedQuestions.Count == 1;

        /// <summary>
        /// Moves all the used questions back into unused questions
        /// and resets the used questions list.
        /// </summary>
        private void ResetQuestions()
        {
            foreach (var question in _usedQuestions)
                _unusedQuestions.Add(question);

            _usedQuestions.Clear();
        }

        /// <summary>
        /// Goes to the next question and moves the previous question
        /// to the used questions list.
        /// </summary>
        private void NextQuestion()
        {        
            _usedQuestions.Add(_unusedQuestions[0]);
            _unusedQuestions.RemoveAt(0);

            if (_unusedQuestions.Count <= 0) ResetQuestions();

            CurrentQuestion = _unusedQuestions[0];

            QuestionCount++;
        }

        /// <summary>
        /// Randomly shuffles the questions.
        /// </summary>
        private void ShuffleQuestions()
        {
            _unusedQuestions.Shuffle();
        }

        /// <summary>
        /// Initializes the player with the starting attributes.
        /// </summary>
        private void InitializePlayer()
        {
            Player = new Player()
            {
                Virus = 0,
                Reputation = 50
            };
        }
    }
}
