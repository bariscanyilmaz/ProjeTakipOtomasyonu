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
    public class EfWeeklyControlSubItemRepository : IWeeklySubItemRepository
    {
        private ProjectOtomationContext context = ProjectOtomationContext.CreateAsSingleton();

        public void AddWeeklyControlSubItem(WeeklyControlSubItem weeklyControlSubItem)
        {
            context.WeeklyControlSubItems.Add(weeklyControlSubItem);
            context.Entry(weeklyControlSubItem.Student).State = EntityState.Unchanged;
            context.SaveChanges();
        }

        public void DeleteWeeklyControlSubItem(int id)
        {

            var subItem = context.WeeklyControlSubItems.FirstOrDefault(s => s.Id == id);
            if (subItem != null)
            {
                context.WeeklyControlSubItems.Remove(subItem);
                context.SaveChanges();
            }
        }

        public IQueryable<WeeklyControlSubItem> GetAll()
        {
            return context.WeeklyControlSubItems;
        }

        public WeeklyControlSubItem GetById(int id)
        {
            return context.WeeklyControlSubItems.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateWeeklyControlSubItem(WeeklyControlSubItem weeklyControlSubItem)
        {
            var setWeek = GetById(weeklyControlSubItem.Id);
            if (setWeek != null)
            {
                setWeek.IsControl = weeklyControlSubItem.IsControl;
                context.SaveChanges();
            }
        }
    }
}
