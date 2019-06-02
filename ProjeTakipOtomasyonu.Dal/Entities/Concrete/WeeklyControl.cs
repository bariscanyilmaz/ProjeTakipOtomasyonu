using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Entities.Concrete
{
    public class WeeklyControl:IEntity
    {
        public int Id { get; set; }
        public string WeekName { get; set; }
        public virtual Lesson Lessson { get; set; }
        public virtual List<WeeklyControlSubItem> WeeklyControlSubItem { get; set; }

        public override string ToString()
        {
            return WeekName;
        }

    }
}
