using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete
{
    public class Student:IEntity
    {
        [Key]
        public int Id { get; set; }
        //221703001
        public string SchoolNumber  { get; set; }
        public Period Period { get; set; }
        public string Name { get; set; }
        public string Project { get; set; }
        public string ProgrammingLanguage { get; set; }
        public string Email { get; set; }
        public string Year { get; set; }

        public int VizeScore { get; set; }
        public int FinalScore { get; set; }

        public int FinalRate { get; set; }
        public int VizeRate { get; set; }
        public int TotalScore { get; set; }

        public List<Lesson> Lessons { get; set; }

        public override string ToString()
        {
            return this.SchoolNumber + "-" + this.Name;
        }
    }

   public  enum Period
    {
        FirstPeriod=1,SecondPeriod   
    }
    public enum ReportType
    {
        VizeNot,
        FinalNot,
        GenelNot
    }
}
