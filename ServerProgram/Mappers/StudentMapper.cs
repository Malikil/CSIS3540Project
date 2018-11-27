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
            // Cascade doesn't seem to be working, so need to do it manually
            // First delete all reservations
            var student = (from s in context.Student
                           where s.StudentID == studentid
                           select s).FirstOrDefault();
            if (student != null)
            {
                Account[] accounts = new Account[student.Accounts.Count];
                student.Accounts.CopyTo(accounts, 0);
                foreach (Account a in accounts)
                {
                    Reservation[] reservations = new Reservation[a.Reservations.Count];
                    a.Reservations.CopyTo(reservations, 0);
                    foreach (Reservation r in reservations)
                        context.Reservation.Remove(r);
                    context.Account.Remove(a);
                }
                context.Student.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
