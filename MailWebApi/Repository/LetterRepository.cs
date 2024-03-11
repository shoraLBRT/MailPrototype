using MailService.Models;
using MailWebApi.DAL;

namespace MailWebApi.Repository
{
    internal class LetterRepository : EfRepository<Letter>, IRepository<Letter>
    {
        public LetterRepository(MailDbContext dbContext) : base(dbContext)
        {
        }
    }
}
