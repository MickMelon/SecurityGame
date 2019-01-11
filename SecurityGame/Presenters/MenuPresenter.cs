using SecurityGame.Services;
using SecurityGame.Views;
using SecurityGame.Views.Interfaces;

namespace SecurityGame.Presenters
{
    public class MenuPresenter : Presenter
    {
        private readonly AuthService _authService;
        private readonly IMenuView _menuView;

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuPresenter"/> class.
        /// </summary>
        /// <param name="parentPresenter">The parent presenter.</param>
        /// <param name="menuView">The game view.</param>
        public MenuPresenter(ParentView parentView,
            AuthService authService,
            IMenuView menuView) : base(parentView)
        {
            _authService = authService;
            _menuView = menuView;      

            _menuView.Presenter = this;
        }

        /// <summary>
        /// Checks if the user is an admin to so we know 
        /// whether to display the button for the admin 
        /// panel.
        /// </summary>
        /// <returns>Whether the admin panel button needs displayed.</returns>
        public bool DoesAdminNeedDisplayed() => _authService.UserIsAdmin();
    }
}
