using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityGame.Repositories;
using SecurityGame.Services;

namespace SecurityGame.Tests.ServiceTests
{
    [TestClass]
    public class AuthServiceTests
    {
        [TestMethod]
        public void Login_ValidUsernamePassword_ShouldReturnTrue()
        {
            // Arrange
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);

            // Act
            bool success = authService.Login("ValidUsername", "ValidPassword");

            // Assert
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Login_ValidUsernameInvalidPassword_ShouldReturnFalse()
        {
            // Arrange
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);

            // Act
            bool success = authService.Login("ValidUsername", "a");

            // Assert
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void Login_InvalidUsername_ShouldReturnFalse()
        {
            // Arrange
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);

            // Act
            bool success = authService.Login("invalid", "a");

            // Assert
            Assert.IsFalse(success);
        }

        [TestMethod]
        public void Login_UsernameCase_ShouldNotMatter()
        {
            // Arrange
            var accountRepository = new MockAccountRepository();
            var authService = new AuthService(accountRepository);

            // Act
            bool success = authService.Login("vALiDuSerName", "ValidPassword");

            // Assert
            Assert.IsTrue(success);
        }
    }
}
