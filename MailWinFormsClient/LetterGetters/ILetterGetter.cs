namespace MailWinFormsClient.LetterGetters
{
    internal interface ILetterGetter
    {
        Task<object?> GetLettersFromWebApi();
    }
}
