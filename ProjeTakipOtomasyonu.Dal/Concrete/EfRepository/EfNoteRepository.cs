using ProjeTakipOtomasyonu.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete.EfRepository
{
    public class EfNoteRepository : INoteRepository
    {
        private ProjectOtomationContext context = ProjectOtomationContext.CreateAsSingleton();

        public void AddNote(Note note)
        {
            context.Notes.Add(note);
            context.SaveChanges();
        }

        public void DeleteNote(int id)
        {
            var note = context.Notes.FirstOrDefault(s => s.Id == id);
            if (note != null)
            {
                context.Notes.Remove(note);
                context.SaveChanges();
            }
        }

        public IQueryable<Note> GetAll()
        {
            return context.Notes;
        }

        public Note GetById(int id)
        {
            return context.Notes.FirstOrDefault(s => s.Id == id);
        }

        public void UpdateNote(Note note)
        {
            var setNote= GetById(note.Id);
            if (setNote != null)
            {
                setNote.Content = note.Content;
                context.SaveChanges();
            }
        }
    }
}
