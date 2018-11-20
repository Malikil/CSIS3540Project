using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Entities;

namespace ServerProgram.Mappers
{
    class StudentMapper
    {
        // Student CRUD operations
        private static readonly CampusContext context = new CampusContext();

        public void CreateStudent(Student stu)
        {
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

        public Student ReadStudentByID(int ID)
        {
            Student student = context.Student.Where(s => s.StudentID == ID).FirstOrDefault();
            return student;
        }
    }
}
