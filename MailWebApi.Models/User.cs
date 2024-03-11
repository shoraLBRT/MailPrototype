namespace MailService.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public virtual ICollection<Letter>? SentLetters { get; set; }
        public virtual ICollection<Letter>? RecievedLetters { get; set; }
    }
}
