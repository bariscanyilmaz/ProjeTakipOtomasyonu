using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete.EfRepository
{
    public class EfLessonRepository : ILessonRepository
    {
        private ProjectOtomationContext context = ProjectOtomationContext.CreateAsSingleton();

        public void AddLesson(Lesson lesson)
        {
            context.Lessons.Add(lesson);
            context.SaveChanges();
        }

        public void DeleteLesson(int id)
        {
            var lesson = context.Lessons.FirstOrDefault(s => s.Id == id);
            if (lesson != null)
            {
                context.Lessons.Remove(lesson);
                context.SaveChanges();
            }
            
        }

        public IQueryable<Lesson> GetAll()
        {
            return context.Lessons;
        }

        public Lesson GetById(int id)
        {
            return context.Lessons.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateLesson(Lesson lesson)
        {
            var setLesson = GetById(lesson.Id);
            if (setLesson != null)
            {
                setLesson.Name = lesson.Name;
                context.SaveChanges();
            }
        }
    }
}
