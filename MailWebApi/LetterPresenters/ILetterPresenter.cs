namespace MailWebApi.LetterPresenters
{
    public interface ILetterPresenter
    {
        Task<IEnumerable<LetterOutDto>> DisplayAllLetters();
    }
}
