namespace ProjeTakipOtomasyonu.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjeTakipOtomasyonu.Dal.ProjectOtomationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ProjeTakipOtomasyonu.Dal.ProjectOtomationContext";
        }

        protected override void Seed(ProjeTakipOtomasyonu.Dal.ProjectOtomationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
