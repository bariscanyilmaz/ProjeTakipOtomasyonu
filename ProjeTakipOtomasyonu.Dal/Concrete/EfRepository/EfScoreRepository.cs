using ProjeTakipOtomasyonu.Dal.Abstract;
using ProjeTakipOtomasyonu.Dal.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete.EfRepository
{
    public class EfScoreRepository : IScoreRepository
    {
        private ProjectOtomationContext context = ProjectOtomationContext.CreateAsSingleton();

        public void AddScore(Score score)
        {
            context.Scores.Add(score);
            context.Entry(score.Student).State = System.Data.Entity.EntityState.Unchanged;
            context.Entry(score.Lesson).State = System.Data.Entity.EntityState.Unchanged;
            context.SaveChanges();
        }

        public void DeleteScore(int id)
        {
            var score = context.Scores.FirstOrDefault(s => s.Id == id);
            if (score != null)
            {
                context.Scores.Remove(score);
                context.SaveChanges();
            }
        }

        public IQueryable<Score> GetAll()
        {
            return context.Scores;
        }

        public Score GetById(int id)
        {
            return context.Scores.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateScore(Score score)
        {
            var setscore = GetById(score.Id);
            if (setscore != null)
            {
                setscore.VizeRate= score.VizeRate;
                setscore.VizeScore= score.VizeScore;
                setscore.FinalRate= score.FinalRate;
                setscore.FinalScore= score.FinalScore;
                setscore.TotalScore= score.TotalScore;
                context.SaveChanges();
            }
        }
    }
}
