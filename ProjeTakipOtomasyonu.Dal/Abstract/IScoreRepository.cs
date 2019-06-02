using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Abstract
{
   public  interface IScoreRepository
    {
        Score GetById(int id);
        IQueryable<Score> GetAll();
        void AddScore(Score score);
        void UpdateScore(Score score);
        void DeleteScore(int id);
    }
}
