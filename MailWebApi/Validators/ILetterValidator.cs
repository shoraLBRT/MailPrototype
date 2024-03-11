using MailService.Models;

namespace MailWebApi.Validators
{
    internal interface ILetterValidator
    {
        (bool isValid, string? ErrorsString) Validate(Letter letter);
    }
}
