using SecurityGame.Presenters;
using SecurityGame.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace SecurityGame.Views
{
    public partial class GameView : UserControl, IGameView
    {
        public int Virus
        {
            get => int.Parse(Label_Virus.Text);
            set => Label_Virus.Text = value.ToString();
        }

        public int Reputation
        {
            get => int.Parse(Label_Reputation.Text);
            set => Label_Reputation.Text = value.ToString();
        }

        public int QuestionCount
        {
            get => int.Parse(Label_QuestionCount.Text);
            set => Label_QuestionCount.Text = value.ToString();
        }

        public string Question
        {
            get => Label_Question.Text;
            set => Label_Question.Text = value;
        }

        public string Answer1
        {
            get => Button_Answer1.Text;
            set => Button_Answer1.Text = value;
        }

        public string Answer2
        {
            get => Button_Answer2.Text;
            set => Button_Answer2.Text = value;
        }

        public GamePresenter Presenter { set; private get; }

        private bool _loaded;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameView"/> class.
        /// </summary>
        public GameView()
        {
            InitializeComponent();
            VisibleChanged += OnVisibleChanged;
            _loaded = false;
        }
        
        /// <summary>
        /// Called when the <see cref="Presenters.Presenter"/> class shows
        /// the game view.
        /// </summary>
        private void OnVisibleChanged(object sender, EventArgs e)
        {
            if (!_loaded)
            {
                _loaded = true;
                return;
            }

            if (!Presenter.StartGame())
            {
                Presenter.ShowMenu();
                MessageBox.Show("The game could not be started.", "Error Starting Game");  
            }
        }

        /// <summary>
        /// Called when the user clicks the first answer button.
        /// </summary>
        private void Button_Answer1_Click(object sender, System.EventArgs e)
        { 
            Presenter.SubmitAnswer(Button_Answer1.Text);
        }

        /// <summary>
        /// Called when the user clicks the second answer button.
        /// </summary>
        private void Button_Answer2_Click(object sender, System.EventArgs e)
        {
            Presenter.SubmitAnswer(Button_Answer2.Text);
        }


        
    }
}
