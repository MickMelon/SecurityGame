using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityGame.Constants;
using SecurityGame.Presenters;
using SecurityGame.Repositories;
using SecurityGame.Services;
using SecurityGame.Views;
using SecurityGame.Views.Interfaces;

namespace SecurityGame.Tests.PresenterTests
{
    [TestClass]
    public class AuthPresenterTests
    {
        [TestMethod]
        public void Login_UsernameEmpty_ShouldDisplayError()
        {
            // Arrange
            var parentView = new ParentView();
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);
            IAuthView authView = new AuthView();
            var authPresenter = new AuthPresenter(parentView, authService, authView);

            // Act
            authView.Username = "";
            authView.Password = "password";
            authPresenter.Login();

            // Assert
            Assert.IsTrue(authView.Error.Equals(Messages.LOGIN_EMPTY));
        }

        [TestMethod]
        public void Login_PasswordEmpty_ShouldDisplayError()
        {
            // Arrange
            var parentView = new ParentView();
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);
            IAuthView authView = new AuthView();
            var authPresenter = new AuthPresenter(parentView, authService, authView);

            // Act
            authView.Username = "username";
            authView.Password = "";
            authPresenter.Login();

            // Assert
            Assert.IsTrue(authView.Error.Equals(Messages.LOGIN_EMPTY));
        }

        [TestMethod]
        public void Login_UsernameIllegalCharacters_ShouldDisplayError()
        {
            // Arrange
            var parentView = new ParentView();
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);
            IAuthView authView = new AuthView();
            var authPresenter = new AuthPresenter(parentView, authService, authView);

            // Act
            authView.Username = "#";
            authView.Password = "password";
            authPresenter.Login();

            // Assert
            Assert.IsTrue(authView.Error.Equals(Messages.LOGIN_ILLEGAL_CHARS));
        }
    }
}
