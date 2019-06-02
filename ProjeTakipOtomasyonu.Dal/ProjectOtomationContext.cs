using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ProjeTakipOtomasyonu.Dal.Concrete;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;

namespace ProjeTakipOtomasyonu.Dal
{
    public class ProjectOtomationContext:DbContext
    {
        public ProjectOtomationContext():base("ProjectOtomationContext")
        {
           //
        }

        public static ProjectOtomationContext CreateAsSingleton()
        {
            lock (lockObject)
            {
                if (context==null)
                {
                    context = new ProjectOtomationContext();
                }

            }

            return context;
        }

        private static ProjectOtomationContext context;
        static object lockObject = new object();

        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeeklyControl> WeeklyControls { get; set; }
        public DbSet<WeeklyControlSubItem> WeeklyControlSubItems { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}
