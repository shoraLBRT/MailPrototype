using MailService.Models;

namespace MailWebApi
{
    public interface ILetterRegistrar
    {
        Task<(bool isValid, string? errorString)> TryRegisterAsync(Letter letter);
    }
}
