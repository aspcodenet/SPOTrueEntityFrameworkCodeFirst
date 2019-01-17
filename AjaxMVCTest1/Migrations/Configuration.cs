namespace AjaxMVCTest1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AjaxMVCTest1.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AjaxMVCTest1.Models.Model1 context)
        {
            context.Categories.AddOrUpdate(r => r.Id,
                new Models.Category { Id = 1, Name = "123123" },
                new Models.Category { Id = 2, Name = "3234" },
                new Models.Category { Id = 3, Name = "cbcb" }
                );

            context.SaveChanges();
            context.Products.AddOrUpdate(r => r.Id,
                new Models.Product
                {
                    Id = 1,
                    Name = "p1",
                    Price = 12,
                    Category = context.Categories.First(c => c.Id == 2)
                },
                new Models.Product
                {
                    Id = 2,
                    Name = "p2",
                    Price = 11,
                    Category = context.Categories.First(c => c.Id == 1)
                }
                );

            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
