using SecurityGame.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SecurityGame.Repositories
{
    public class GameContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public GameContext() : base("SecurityGameDB")
        {
            Database.SetInitializer<GameContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
