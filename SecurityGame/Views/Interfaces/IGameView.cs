using SecurityGame.Presenters;

namespace SecurityGame.Views.Interfaces
{
    public interface IGameView
    {
        int Virus { get; set; }
        int Reputation { get; set; }
        int QuestionCount { get; set; }
        string Question { get; set; }
        string Answer1 { get; set; }
        string Answer2 { get; set; }

        GamePresenter Presenter { set; }
    }
}
