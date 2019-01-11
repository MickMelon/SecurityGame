using SecurityGame.Presenters;
using SecurityGame.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace SecurityGame.Views
{
    public partial class AuthView : UserControl, IAuthView
    {
        public string Username
        {
            get => TextBox_Username.Text;
            set => TextBox_Username.Text = value;
        }

        public string Password
        {
            get => TextBox_Password.Text;
            set => TextBox_Password.Text = value;
        }

        public string Error
        {
            get => Label_Error.Text;
            set => Label_Error.Text = value;
        }

        public AuthPresenter Presenter { set; private get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthView"/> class.
        /// </summary>
        public AuthView()
        {
            InitializeComponent();

            Label_Error.Text = "";
            TextBox_Password.PasswordChar = '*';
        }

        /// <summary>
        /// Called when the user clicks the login button.
        /// </summary>
        private void Button_Login_Click(object sender, EventArgs e)
        {
            Presenter.Login();
        }
    }
}
