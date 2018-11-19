using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram.Mappers
{
    class StudentMapper
    {
        // Student CRUD operations

        public void CreateStudent(Student stu)
        {
            var context = new CampusContext();
            context.Student.Add(stu);
            context.SaveChanges();
        }

        public List<Student> ReadAllStudents()
        {
            List<Student> students = new List<Student>();
            var context = new CampusContext();
            students = context.Student.ToList();
            return students;
        }

        public List<Student> ReadStudentByID(int ID)
        {
            List<Student> students = new List<Student>();
            var context = new CampusContext();
            students = context.Student.Where(s => s.StudentID == ID).ToList();
            return students;
        }
    }
}
