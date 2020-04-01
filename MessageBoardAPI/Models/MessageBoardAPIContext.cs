using Microsoft.EntityFrameworkCore;

namespace MessageBoardAPI.Models
{
    public class MessageBoardAPIContext : DbContext
    {
        public MessageBoardAPIContext(DbContextOptions<MessageBoardAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
    }
}