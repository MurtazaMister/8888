using Microsoft.EntityFrameworkCore;

namespace _8888.Models
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options) { 
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
