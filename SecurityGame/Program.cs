using SecurityGame.Presenters;
using SecurityGame.Repositories;
using SecurityGame.Services;
using SecurityGame.Views;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SecurityGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!TestDatabaseConnection())
            {
                MessageBox.Show(
                    "The game is currently unavailable. Apologies for any inconveniences.",
                    "Game Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            StartProgram();
        }

        /// <summary>
        /// Instantiates all the required initial objects and 
        /// starts the program.
        /// </summary>
        private static void StartProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate views
            var parentView = new ParentView();
            var menuView = new MenuView();
            var gameView = new GameView();
            var gameOverView = new GameOverView();
            var authView = new AuthView();
            var adminView = new AdminView();
            var questionManagerView = new QuestionManagerView();

            // Instantiate repositories
            var questionRepository = new EfQuestionRepository();
            var accountRepository = new EfAccountRepository();

            // Instantiate services
            var gameService = new GameService(questionRepository);
            var authService = new AuthService(accountRepository);

            // Instantiate presenters
            var gamePresenter = new GamePresenter(parentView, gameService, gameView, gameOverView);
            var menuPresenter = new MenuPresenter(parentView, authService, menuView);
            var authPresenter = new AuthPresenter(parentView, authService, authView);
            var adminPresenter = new AdminPresenter(parentView, questionRepository, adminView, questionManagerView);

            // Add views to the parent container
            parentView.Controls.Add(menuView);
            parentView.Controls.Add(gameView);
            parentView.Controls.Add(gameOverView);
            parentView.Controls.Add(authView);
            parentView.Controls.Add(adminView);
            parentView.Controls.Add(questionManagerView);

            // Show the login view as the first thing that is presented to 
            // the user when they start the application.
            authPresenter.ShowAuth();

            // Run the application
            Application.Run(parentView);
        }

        /// <summary>
        /// Checks to see if the tables in the database are 
        /// accessible.
        /// </summary>
        /// <returns>Whether there is a successful connection to the database.</returns>
        private static bool TestDatabaseConnection()
        {
            try
            {
                using (var context = new GameContext())
                {
                    context.Accounts.ToList();
                    context.Questions.ToList();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
