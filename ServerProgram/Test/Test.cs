using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    class Test
    {
        public Test()
        {

        }

        public void AddStudentTest()
        {
            var context = new CampusContext();
            var stu = new Student() { StudentID = 12345, Name = "Heitor"};
            context.Student.Add(stu);
            context.SaveChanges();
        }
    }
}
