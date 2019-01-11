using SecurityGame.Presenters;
using System.Collections.Generic;

namespace SecurityGame.Views.Interfaces
{
    public interface IQuestionManagerView
    {
        IList<string> QuestionList { get; set; }
        int SelectedQuestion { get; set; }

        string Content { get; set; }
        string CorrectAnswer { get; set; }
        string WrongAnswer { get; set; }
        int CorrectVirusChange { get; set; }
        int CorrectReputationChange { get; set; }
        int WrongVirusChange { get; set; }
        int WrongReputationChange { get; set; }

        AdminPresenter Presenter { set; }
    }
}
