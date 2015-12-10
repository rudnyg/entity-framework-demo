using System.Data.Entity;

namespace EfDemo.Data
{
    public class TutorialContext : BaseContext<TutorialContext>
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tutorial> Tutorials { get; set; }
    }
}
