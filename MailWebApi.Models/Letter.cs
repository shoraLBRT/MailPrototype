using System.Text.Json.Serialization;

namespace MailService.Models
{
    public class Letter
    {
        public int Id { get; set; }
        public required string SubjectOfLetter { get; set; }

        [JsonIgnore]
        public DateTime SentAt { get; }
        public required string Content { get; set; }
        public int SenderId { get; set; }

        [JsonIgnore]
        public User Sender { get; set; } = null!;

        public int RecipientId { get; set; }

        [JsonIgnore]
        public User Recipient { get; set; } = null!;

    }
}
