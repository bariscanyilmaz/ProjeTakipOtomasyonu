using ProjeTakipOtomasyonu.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Abstract
{ 
    public interface INoteRepository
    {
        Note GetById(int id);
        IQueryable<Note> GetAll();
        void AddNote(Note note);
        void UpdateNote(Note note);
        void DeleteNote(int id);

    }
}
