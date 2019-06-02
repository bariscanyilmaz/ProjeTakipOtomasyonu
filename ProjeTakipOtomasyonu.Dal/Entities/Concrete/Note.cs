using ProjeTakipOtomasyonu.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete
{
    public class Note : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        
            
    }
}
