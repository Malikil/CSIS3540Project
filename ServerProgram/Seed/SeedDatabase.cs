using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Mappers;
using CsvHelper;
using ServerProgram.Entities;

namespace ServerProgram.Seed
{
    class SeedDatabase
    {
        public void SeedStudents()
        {
            TextReader textReader = new StreamReader(@"Seed/Student_And_Account_Seed.csv");
            var csv = new CsvReader( textReader );
            int counter = 0;
            while (csv.Read())
            {
                var studentID = csv.GetField<string>(0);
                var studentName = csv.GetField<string>(1);
                if (counter > 0)
                {
                    Student student = new Student()
                    {StudentID = int.Parse(studentID),
                    Name = studentName
                    };
                    Console.WriteLine(student.StudentID);
                    StudentMapper.CreateStudent(student);
                }
                counter++;
            }
        }

        public void SeedAccounts()
        {
            TextReader textReader = new StreamReader(@"Seed/Student_And_Account_Seed.csv");
            var csv = new CsvReader(textReader);
            int counter = 0;
            while (csv.Read())
            {
                var studentID = csv.GetField<string>(2);
                var password = csv.GetField<string>(3);
                var username = csv.GetField<string>(4);
                if (counter > 0)
                {
                    Account account = new Account()
                    {
                        StudentID = int.Parse(studentID),
                        Password = password,
                        Username = username
                    };
                    Console.WriteLine($"{account.StudentID} {account.Username}");
                    AccountMapper.CreateAccount(account);
                }
                counter++;
            }
        }

        public void TestAddAccount()
        {
            Account acc = new Account() { StudentID = 167678, Username = "shaner", Password = "password"};
            AccountMapper.CreateAccount(acc);
        }

        public void SeedDormRooms()
        {
            TextReader textReader = new StreamReader(@"Seed/DormRoom_Seed.csv");
            var csv = new CsvReader(textReader);
            int counter = 0;
            while (csv.Read())
            {
                var size = csv.GetField<string>(0);
                var cap = csv.GetField<string>(1);
                var floor = csv.GetField<string>(2);
                var roomnum = csv.GetField<string>(3);
                if (counter > 0)
                {
                    DormRoom dorm = new DormRoom()
                    {
                        Size = int.Parse(size),
                        Capacity = int.Parse(cap),
                        FloorID = int.Parse(floor),
                        RoomNumber = int.Parse(roomnum)
                    };
                    DormRoomMapper.CreateDormRoom(dorm);
                }
                counter++;
            }
        }

        public void SeedReservations()
        {

        }

        public void SeedBuildingAndFloor()
        {
            Building building = new Building()
            {
                BuildingID = 1,
                Name = "Marmot"
            };
            //BuildingMapper.CreateBuilding(building);

            Floor floor = new Floor()
            {
                FloorNum = 1,
                BuildingID = 1
            };
            FloorMapper.CreateFloor(floor);
        }
    }
}
