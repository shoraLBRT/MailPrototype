namespace MailWebApi.LetterPresenters
{
    public class LetterOutDto
    {
        public int Id { get; set; }
        public required string SubjectOfLetter { get; set; }
        public DateTime SentAt { get; set; }
        public required string Content { get; set; }
        public required string Sender { get; set; }
        public required string Recipient { get; set; }
    }
}
