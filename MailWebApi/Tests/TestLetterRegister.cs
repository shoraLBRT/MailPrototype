using MailService.Models;
using MailWebApi.Logger;
using MailWebApi.Repository;
using MailWebApi.Validators;
using Moq;
using Xunit;

namespace MailWebApi.Tests
{
    public class TestLetterRegister
    {
        private readonly Mock<IRepository<Letter>> _letterRepositoryMock;
        private readonly Mock<ILetterValidator> _letterValidatorMock;
        private readonly Mock<IErrorLogger> _errorLoggerMock;
        private readonly LetterRegistrar _letterRegistrar;
        public TestLetterRegister()
        {
            _letterRepositoryMock = new Mock<IRepository<Letter>>();
            _letterValidatorMock = new Mock<ILetterValidator>();
            _errorLoggerMock = new Mock<IErrorLogger>();
            _letterRegistrar = new LetterRegistrar(_letterRepositoryMock.Object, _letterValidatorMock.Object, _errorLoggerMock.Object);
        }
        [Fact]
        public async Task TryRegisterAsync_ValidLetter_ShouldReturnTrue()
        {
            _letterValidatorMock.Setup(v => v.Validate(It.IsAny<Letter>())).Returns((true, null));

            Letter letter = new Letter()
            {
                SubjectOfLetter = "тестовая тема",
                Content = "тестовый контент",
                RecipientId = 2,
                SenderId = 3
            };
            (bool success, string? errorMessage) = await _letterRegistrar.TryRegisterAsync(letter);

            Assert.True(success);
            Assert.Null(errorMessage);
        }

        [Fact]
        public async Task TryRegisterAsync_InvalidLetter_ShouldReturnFalse()
        {
            _letterValidatorMock.Setup(v => v.Validate(It.IsAny<Letter>())).Returns((false, "Error message"));

            Letter letter = new Letter()
            {
                SubjectOfLetter = "тестовая тема",
                Content = "тестовый контент",
                RecipientId = 2
            };
            (bool success, string? errorMessage) = await _letterRegistrar.TryRegisterAsync(letter);

            Assert.False(success);
            Assert.Equal("Письмо не соответствует необходимым требованиям. А именно Error message", errorMessage);
        }

        [Fact]
        public async Task TryRegisterAsync_ExceptionThrown_ShouldReturnFalse()
        {
            _letterValidatorMock.Setup(v => v.Validate(It.IsAny<Letter>())).Returns((true, null));

            _letterRepositoryMock.Setup(r => r.AddAsync(It.IsAny<Letter>())).ThrowsAsync(new Exception("Test exception"));

            Letter letter = new Letter()
            {
                SubjectOfLetter = "тестовая тема",
                Content = "тестовый контент",
                RecipientId = 2,
                SenderId = 3
            };

            (bool success, string? errorMessage) = await _letterRegistrar.TryRegisterAsync(letter);

            Assert.False(success);
            Assert.Equal("Непредвиденная ошибка. Test exception", errorMessage);
        }
    }
}
