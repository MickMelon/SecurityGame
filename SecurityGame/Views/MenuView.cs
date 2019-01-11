using SecurityGame.Presenters;
using SecurityGame.Views.Interfaces;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SecurityGame.Views
{
    public partial class MenuView : UserControl, IMenuView
    {
        public MenuPresenter Presenter { set; private get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuView"/> class.
        /// </summary>
        public MenuView()
        {
            InitializeComponent();
            VisibleChanged += OnVisibleChanged;
        }

        /// <summary>
        /// Called when the <see cref="Presenters.Presenter"/> class shows
        /// the menu view.
        /// </summary>
        private void OnVisibleChanged(object sender, EventArgs e)
        {
            Button_Admin.Visible = Presenter.DoesAdminNeedDisplayed();
        }

        /// <summary>
        /// Called when the user clicks the start game button.
        /// </summary>
        private void Button_StartGame_Click(object sender, EventArgs e)
        {
            Presenter.ShowGame();
        }

        /// <summary>
        /// Called when the user clicks the how to play button.
        /// </summary>
        private void Button_HowToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "You will be asked questions related to cybersecurity where " +
                "you must give two-way answers.\n\nYour answers will affect " +
                "your attributes (virus and reputation), depending on " +
                "whether you gave the correct answer.\n\n" +
                "If your virus reaches 100 or your reputation reaches 0, " +
                "you will lose the game!",
                "How to Play");
        }

        /// <summary>
        /// Called when the user clicks the exit game button.
        /// </summary>
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Called when the user clicks the admin panel button.
        /// </summary>
        private void Button_Admin_Click(object sender, EventArgs e)
        {
            Presenter.ShowAdmin();
        }
    }
}
