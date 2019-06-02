using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Abstract
{
    public interface ILessonRepository
    {
        Lesson GetById(int id);
        IQueryable<Lesson> GetAll();
        void AddLesson(Lesson lesson);
        void UpdateLesson(Lesson note);
        void DeleteLesson(int id);
    }
}
