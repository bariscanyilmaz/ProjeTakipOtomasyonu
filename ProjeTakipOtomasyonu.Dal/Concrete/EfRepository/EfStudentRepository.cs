using ProjeTakipOtomasyonu.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakipOtomasyonu.Dal.Concrete.EfRepository
{
    public class EfStudentRepository : IStudentRepository
    {
        private ProjectOtomationContext context = ProjectOtomationContext.CreateAsSingleton();

        public void AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }


        }

        public IQueryable<Student> GetAll()
        {
            return context.Students;
        }

        public Student GetById(int id)
        {
            return context.Students.FirstOrDefault(s => s.Id==id );
        }

        public void UpdateStudent(Student student)
        {
            var setStudent = GetById(student.Id);
            if (setStudent!=null)
            {
                setStudent.Period = student.Period;
                setStudent.Name=student.Name;
                setStudent.Project = student.Project;
                setStudent.ProgrammingLanguage = student.ProgrammingLanguage;
                setStudent.SchoolNumber = student.SchoolNumber;
                setStudent.Email = student.Email;
                context.SaveChanges();
            }
        }
    }
}
