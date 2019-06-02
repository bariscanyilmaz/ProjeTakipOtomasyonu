using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Abstract
{
    public interface IWeeklySubItemRepository
    {
        WeeklyControlSubItem GetById(int id);
        IQueryable<WeeklyControlSubItem> GetAll();
        void AddWeeklyControlSubItem(WeeklyControlSubItem weeklyControlSubItem);
        void UpdateWeeklyControlSubItem(WeeklyControlSubItem weeklyControlSubItem);
        void DeleteWeeklyControlSubItem(int id);
    }
}
