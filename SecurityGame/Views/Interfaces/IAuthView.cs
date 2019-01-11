using SecurityGame.Presenters;

namespace SecurityGame.Views.Interfaces
{
    public interface IAuthView
    {
        string Username { get; set; }
        string Password { get; set; }
        string Error { get; set; }

        AuthPresenter Presenter { set; }
    }
}
