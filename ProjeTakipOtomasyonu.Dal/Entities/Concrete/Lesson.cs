using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Entities.Concrete
{
    public class Lesson:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<WeeklyControl> WeeklyControls { get; set; }
        public List<Student> Students { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
