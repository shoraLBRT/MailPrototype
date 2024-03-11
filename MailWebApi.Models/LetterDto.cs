namespace MailService.Models
{
    public class LetterDto
    {
        public int Id { get; set; }
        public required string SubjectOfLetter { get; set; }
        public required string Content { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
    }
}
