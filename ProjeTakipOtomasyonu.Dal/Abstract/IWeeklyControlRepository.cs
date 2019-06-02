using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Abstract
{
    public interface IWeeklyControlRepository
    {
        WeeklyControl GetById(int id);
        IQueryable<WeeklyControl> GetAll();
        void AddWeeklyControl(WeeklyControl weeklyControl);
        void UpdateWeeklyControl(WeeklyControl weeklyControl);
        void DeleteWeeklyControl(int id);

    }
}
