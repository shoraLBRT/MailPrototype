using MailService.Models;
using Microsoft.EntityFrameworkCore;

namespace MailWebApi.DAL
{
    public class MailDbContext : DbContext
    {
        public MailDbContext(DbContextOptions<MailDbContext> options) : base(options) { }

        public DbSet<Letter> Letters { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.SentLetters)
                .WithOne(l => l.Sender)
                .HasForeignKey(l => l.SenderId);
            modelBuilder.Entity<User>().HasMany(u => u.RecievedLetters)
                .WithOne(l => l.Recipient)
                .HasForeignKey(l => l.RecipientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Letter>()
                .Property(l => l.SentAt)
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
