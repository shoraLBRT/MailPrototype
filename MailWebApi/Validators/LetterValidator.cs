using FluentValidation;
using MailService.Models;
using MailWebApi.DAL;
using Microsoft.EntityFrameworkCore;

namespace MailWebApi.Validators
{
    internal class LetterValidator : AbstractValidator<Letter>, ILetterValidator
    {
        private MailDbContext _dbContext;
        public LetterValidator(MailDbContext dbContext)
        {
            _dbContext = dbContext;

            RuleFor(letter => letter.SenderId).NotNull().MustAsync(async (id, _) =>
            {
                var existingAuthor = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
                return existingAuthor is not null;
            }).WithMessage("Отсутствует отправитель");

            RuleFor(letter => letter.RecipientId).NotNull().MustAsync(async (id, _) =>
            {
                var existingAuthor = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
                return existingAuthor is not null;
            }).WithMessage("Отсутствует получатель");

            RuleFor(letter => letter.Content).NotNull().NotEmpty().WithMessage("Пустой текст письма");
            RuleFor(letter => letter.SubjectOfLetter).NotNull().NotEmpty().WithMessage("Отсутствует тема письма");
        }

        (bool, string?) ILetterValidator.Validate(Letter letter)
        {
            (bool, string?) result = (ValidateAsync(letter).Result.IsValid, ValidateAsync(letter).Result.ToString());
            return result;
        }
    }
}
