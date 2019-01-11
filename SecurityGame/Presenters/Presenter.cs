using SecurityGame.Views;

namespace SecurityGame.Presenters
{
    public abstract class Presenter
    {
        private readonly ParentView _parentView;

        /// <summary>
        /// Initializes a new instance of the <see cref="Presenter"/> class.
        /// </summary>
        /// <param name="parentView">The parent view.</param>
        public Presenter(ParentView parentView)
        {
            _parentView = parentView;
        }

        /// <summary>
        /// Shows the menu view.
        /// </summary>
        public void ShowMenu() => ShowView("MenuView");

        /// <summary>
        /// Shows the game view.
        /// </summary>
        public void ShowGame() => ShowView("GameView");

        /// <summary>
        /// Shows the game over view.
        /// </summary>
        public void ShowGameOver() => ShowView("GameOverView");

        /// <summary>
        /// Shows the authentication view.
        /// </summary>
        public void ShowAuth() => ShowView("AuthView");

        /// <summary>
        /// Shows the admin view.
        /// </summary>
        public void ShowAdmin() => ShowView("AdminView");

        /// <summary>
        /// Shows the question manager view.
        /// </summary>
        public void ShowQuestionManager() => ShowView("QuestionManagerView");

        /// <summary>
        /// Shows the game is unavailable view.
        /// </summary>
        public void ShowGameUnavailable() => ShowView("GameUnavailableView");

        /// <summary>
        /// Shows a view by the name of the class. The class name must
        /// correspond to one added to the parent view in <see cref="Program"/>.
        /// </summary>
        /// <param name="viewName">The name of the view.</param>
        private void ShowView(string viewName)
        {
            if (_parentView.Controls.ContainsKey(viewName))
            {
                HideAll();
                int index = _parentView.Controls.IndexOfKey(viewName);
                _parentView.Controls[index].Show();
            }
        }

        /// <summary>
        /// Hides all of the views.
        /// </summary>
        private void HideAll()
        {
            for (int i = 0; i < _parentView.Controls.Count; i++)
                _parentView.Controls[i].Hide();
        }
    }
}
