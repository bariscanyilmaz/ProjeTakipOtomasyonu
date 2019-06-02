using ProjeTakipOtomasyonu.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Entities.Concrete
{
    public class Score
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Lesson Lesson { get; set; }

        public int VizeScore { get; set; }
        public int FinalScore { get; set; }
        public int TotalScore { get; set; }

        public int FinalRate { get; set; }
        public int VizeRate { get; set; }
        
    }
}
