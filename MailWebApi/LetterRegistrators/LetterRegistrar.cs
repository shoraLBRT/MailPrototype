using MailService.Models;
using MailWebApi.Logger;
using MailWebApi.Repository;
using MailWebApi.Validators;

namespace MailWebApi
{
    internal class LetterRegistrar : ILetterRegistrar
    {
        private IRepository<Letter> letterRepository;
        private IErrorLogger logger;
        private ILetterValidator _validator;

        public LetterRegistrar(IRepository<Letter> efRepository, ILetterValidator validator, IErrorLogger errorLogger)
        {
            letterRepository = efRepository;
            _validator = validator;
            logger = errorLogger;
        }
        public async Task<(bool isValid, string? errorString)> TryRegisterAsync(Letter letter)
        {
            try
            {
                CheckIfLetterIsValid(letter);
                await EnterringLetterIntoDb(letter);
                return (true, null);
            }
            catch (ArgumentException notValid)
            {
                logger.LogError(notValid);
                return (false, $"Письмо не соответствует необходимым требованиям. А именно {notValid.Message}");
            }
            catch (Exception ex)
            {
                logger.LogError(ex);
                return (false, $"Непредвиденная ошибка. {ex.Message}");
            }
        }

        private async Task EnterringLetterIntoDb(Letter letter)
        {
            await letterRepository.AddAsync(letter);
            await letterRepository.SaveChangesAsync();
        }
        private void CheckIfLetterIsValid(Letter letter)
        {
            var result = _validator.Validate(letter);
            if (!result.isValid)
            {
                string errorMessages = result.ErrorsString!;
                throw new ArgumentException(errorMessages);
            }
        }
    }
}