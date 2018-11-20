﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Entities;

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
            var stu = new Student() { Name = "Heitor"};
            context.Student.Add(stu);
            context.SaveChanges();
        }

        public void AddAccountTest()
        {
            var context = new CampusContext();
            var acc = new Account() { Username = "HeitorUser", Password = "pass", StudentID = 12345 };
            context.Account.Add(acc);
            context.SaveChanges();
        }
    }
}
