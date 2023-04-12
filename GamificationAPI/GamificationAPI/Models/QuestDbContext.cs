using Microsoft.EntityFrameworkCore;

namespace GamificationAPI.Models
{
    public class QuestDbContext:DbContext
    {
        public QuestDbContext(DbContextOptions<QuestDbContext> options) : base(options)
        { }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Participant> Participants { get; set; }
            
    }
}
