using ProjeTakipOtomasyonu.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Entities.Concrete
{
    public class ProjectAssignment:IEntity
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
    }
}
