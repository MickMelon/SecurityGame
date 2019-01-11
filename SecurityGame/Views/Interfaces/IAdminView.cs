using SecurityGame.Presenters;

namespace SecurityGame.Views.Interfaces
{
    public interface IAdminView
    {
        AdminPresenter Presenter { set; }
    }
}
