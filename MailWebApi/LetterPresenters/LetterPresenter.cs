using MailWebApi.DAL;
using Microsoft.EntityFrameworkCore;

namespace MailWebApi.LetterPresenters
{
    internal class LetterPresenter : ILetterPresenter
    {
        private MailDbContext _context;
        public LetterPresenter(MailDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<IEnumerable<LetterOutDto>> DisplayAllLetters()
        {
            return await DisplayLettersLinq();
        }

        private async Task<IEnumerable<LetterOutDto>> DisplayLettersLinq()
        {
            var letters = await _context.Letters
                .Include(l => l.Sender)
                .Include(l => l.Recipient)
                .Select(l => new LetterOutDto
                {
                    Id = l.Id,
                    SubjectOfLetter = l.SubjectOfLetter,
                    Content = l.Content,
                    SentAt = l.SentAt,
                    Sender = l.Sender.FullName,
                    Recipient = l.Recipient.FullName
                })
                .ToListAsync();
            return letters;
        }
    }
}
