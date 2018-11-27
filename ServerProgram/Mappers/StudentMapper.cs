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

        public static void CreateStudent(Student stu)
        {
            context.Student.Add(stu);
            context.SaveChanges();
        }

        public static List<Student> ReadAllStudents()
        {
            List<Student> students = new List<Student>();
            var context = new CampusContext();
            students = context.Student.ToList();
            return students;
        }

        public static Student ReadStudentByID(int ID)
        {
            Student student = context.Student.Where(s => s.StudentID == ID).FirstOrDefault();
            return student;
        }

        public static void DeleteStudentByID(int studentid)
        {
            var students = from s in context.Student
                        where s.StudentID == studentid
                        select s;
            Student student = students.FirstOrDefault();
            if (student != null)
            {
                context.Student.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
