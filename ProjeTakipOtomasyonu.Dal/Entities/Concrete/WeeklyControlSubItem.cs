using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Entities.Concrete
{
    public class WeeklyControlSubItem:IEntity
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public bool IsControl { get; set; }
        public string Note { get; set; }
        public virtual WeeklyControl WeeklyControl { get; set; }

        public override string ToString()
        {
            return this.Student.SchoolNumber + "-" + this.Student.Name;
        }
    }
}
