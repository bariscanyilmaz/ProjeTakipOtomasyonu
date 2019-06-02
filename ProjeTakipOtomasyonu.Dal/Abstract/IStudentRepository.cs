using ProjeTakipOtomasyonu.Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Abstract
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        IQueryable<Student> GetAll();
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);

    }
}
