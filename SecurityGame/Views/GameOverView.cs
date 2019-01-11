using SecurityGame.Presenters;
using SecurityGame.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace SecurityGame.Views
{
    public partial class GameOverView : UserControl, IGameOverView
    {
        public GamePresenter Presenter { set; private get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameOverView"/> class.
        /// </summary>
        public GameOverView()
        {
            InitializeComponent();
        }     

        /// <summary>
        /// Called when the user clicks the back to menu button.
        /// </summary>
        private void Button_BackToMenu_Click(object sender, EventArgs e)
        {
            Presenter.ShowMenu();
        }
    }
}
