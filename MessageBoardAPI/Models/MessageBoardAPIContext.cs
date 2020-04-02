using Microsoft.EntityFrameworkCore;

namespace MessageBoardAPI.Models
{
  public class MessageBoardAPIContext : DbContext
  {
    public MessageBoardAPIContext(DbContextOptions<MessageBoardAPIContext> options) : base(options) { 
    }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Group>()
        .HasData(
            new Group { GroupId = 7, Topic = "Surviving COVID" },
            new Group { GroupId = 8, Topic = "Cooking during COVID" },
            new Group { GroupId = 9, Topic = "Gaming during COVID" }
        );

        builder.Entity<Message>()
        .HasData(
            new Message { MessageId = 1, Description = "How to stash water and fuel", GroupId = 7 },
            new Message { MessageId = 2, Description = "How to cook the squirrel that died in your backyard", GroupId = 8 },
            new Message { MessageId = 3, Description = "How to cheat at a puzzle", GroupId = 9 }
        );
    }
  }
} 

