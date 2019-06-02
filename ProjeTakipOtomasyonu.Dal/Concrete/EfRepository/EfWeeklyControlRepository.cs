using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete.EfRepository
{
    public class EfWeeklyControlRepository : IWeeklyControlRepository
    {
        private ProjectOtomationContext context = ProjectOtomationContext.CreateAsSingleton();

        public void AddWeeklyControl(WeeklyControl weeklyControl)
        {
            context.WeeklyControls.Add(weeklyControl);
            context.Entry(weeklyControl.Lessson).State = EntityState.Unchanged;
            context.SaveChanges();
        }

        public void DeleteWeeklyControl(int id)
        {

            var weeklyControl = context.WeeklyControls.FirstOrDefault(s => s.Id == id);
            if (weeklyControl != null)
            {
                context.WeeklyControls.Remove(weeklyControl);
                context.SaveChanges();
            }
        }

        public IQueryable<WeeklyControl> GetAll()
        {

            return context.WeeklyControls;
        }

        public WeeklyControl GetById(int id)
        {
            return context.WeeklyControls.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateWeeklyControl(WeeklyControl weeklyControl)
        {
            var setWeek= GetById(weeklyControl.Id);
            if (setWeek != null)
            {
                setWeek.WeekName = weeklyControl.WeekName;
                context.SaveChanges();
            }
        }
    }
}
