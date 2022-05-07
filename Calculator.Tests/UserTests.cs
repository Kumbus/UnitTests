using Classes;
using Moq;
using NUnit.Framework;

namespace Calculator.Tests
{
    public class UserTests
    {

        [Test]
        public void Login_WhenCorrectData_ShouldReturnEmptyString()
        {
            //Arrange
            var mockUserRepository = new Mock<IUsersRepository>();
            mockUserRepository.Setup(x => x.Login(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            var authentication = new Authentication(mockUserRepository.Object);

            //Act
            var result = authentication.Login("login", "password");

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
