namespace EfDemo.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EfDemo.Data.TutorialContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EfDemo.Data.TutorialContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Authors.AddOrUpdate(
                    a => a.Id,
                    new Author { Id = 1, Name = "Rudny Gacin" },
                    new Author { Id = 2, Name = "Masashi Kishimoto" },
                    new Author { Id = 3, Name = "Edgar Allan Poe" },
                    new Author { Id = 4, Name = "John C. Maxwell" }
                );

            context.Tutorials.AddOrUpdate(
                  t => t.Id,
                  new Tutorial { Id = 1, Title = "Writing Clean Code", AuthorId = 1, Published = DateTime.Now.AddDays(-10) },
                  new Tutorial { Id = 1, Title = "Getting Started with EF 6", AuthorId = 1, Published = DateTime.Now.AddDays(-5) },
                  new Tutorial { Id = 1, Title = "How to Turn Water Into Gold", AuthorId = 1, Published = DateTime.Now },
                  new Tutorial { Id = 1, Title = "How to Control Chakra", AuthorId = 2, Published = DateTime.Now.AddDays(-8) },
                  new Tutorial { Id = 1, Title = "Effective Leadership Skills", AuthorId = 3, Published = DateTime.Now.AddDays(-1) },
                  new Tutorial { Id = 1, Title = "How to Lead", AuthorId = 3, Published = DateTime.Now }
                );
        }
    }
}
