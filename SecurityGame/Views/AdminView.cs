using SecurityGame.Presenters;
using SecurityGame.Views.Interfaces;
using System.Windows.Forms;

namespace SecurityGame.Views
{
    public partial class AdminView : UserControl, IAdminView
    {
        public AdminPresenter Presenter { private get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminView"/> class.
        /// </summary>
        public AdminView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the user clicks the Back to Menu button.
        /// </summary>
        private void Button_BackToMenu_Click(object sender, System.EventArgs e)
        {
            Presenter.ShowMenu();
        }

        /// <summary>
        /// Called when the user clicks the Question Manager button.
        /// </summary>
        private void Button_QuestionManager_Click(object sender, System.EventArgs e)
        {
            Presenter.ShowQuestionManager();
        }
    }
}
