using MailService.Models;

namespace MailWinFormsClient.LetterSavers
{
    internal interface ILetterSaver
    {
        Task SaveLetter(LetterDto letter);
    }
}
