using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Student> studentsList = null;
        List<Room> roomList = null;
        DataTable studentsTable = new DataTable();
        DataTable roomsTable = new DataTable();
        DataView studentsView;
        public int roomx;

        public Form1()
        {
            InitializeComponent();

            studentsList = new List<Student>
            {
                new Student{StudentID = 1, Name="Jhon", LastName="Parker", Age=19, CellNumber=7781235252, Email="j.parker@mail.com", Room=101},
                new Student{StudentID = 2, Name="Diana", LastName="Jhones", Age=17, CellNumber=7784562585, Email="d.jhones@mail.com", Room=102},
                new Student{StudentID = 3, Name="Jorge", LastName="Mesa", Age=18, CellNumber=7784561212, Email="j.mesa@mail.com", Room=201},
                new Student{StudentID = 4, Name="Sammy", LastName="Liuten", Age=22, CellNumber=7787898585, Email="s.liuyen@mail.com", Room=202},
                new Student{StudentID = 5, Name="Rachel", LastName="Tracy", Age=19, CellNumber=7781234552, Email="r.tracy@mail.com", Room=301},
                new Student{StudentID = 6, Name="Sharyn", LastName="Tarazona", Age=18, CellNumber=7789635241, Email="s.tarazona@mail.com", Room=302},
                new Student{StudentID = 7, Name="Roger", LastName="Torres", Age=18, CellNumber=7789635241, Email="s.tarazona@mail.com", Room=302}

            };

            roomList = new List<Room>
            {
                new Room{RoomID = 101, Size=1, StudentID=1},
                new Room{RoomID = 102, Size=2, StudentID=2},
                new Room{RoomID = 201, Size=1, StudentID=3},
                new Room{RoomID = 202, Size=2, StudentID=4},
                new Room{RoomID = 301, Size=1, StudentID=5},
                new Room{RoomID = 302, Size=2, StudentID=6}

            };

            CreateDataTable();


        }

        private void roomsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int roomx;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = roomsGridView.Rows[index];
            roomx = int.Parse(selectedRow.Cells[0].Value.ToString());
            label1.Text = roomx.ToString();
            StudentsDataView(roomx);


        }
        public void CreateDataTable()
        {
            var studentIdColumn = new DataColumn("StudentID", typeof(int))
            {
                Caption = "Student Id",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
            };

            var studentNameColumn = new DataColumn("Name", typeof(string));
            var studentLastNameColumn = new DataColumn("Last Name", typeof(string));
            var studentAgeColumn = new DataColumn("Age", typeof(int));
            var studentPhoneColumn = new DataColumn("Phone Number", typeof(double));
            var studentEmailColumn = new DataColumn("Email", typeof(string));
            var studentRoomColumn = new DataColumn("Room", typeof(int));

            studentsTable.Columns.AddRange
                (new[] { studentIdColumn, studentNameColumn, studentLastNameColumn, studentAgeColumn, studentPhoneColumn, studentEmailColumn, studentRoomColumn });

            foreach (var l in studentsList)
            {
                var newRow = studentsTable.NewRow();
                newRow[0] = l.StudentID;
                newRow[1] = l.Name;
                newRow[2] = l.LastName;
                newRow[3] = l.Age;
                newRow[4] = l.CellNumber;
                newRow[5] = l.Email;
                newRow[6] = l.Room;
                studentsTable.Rows.Add(newRow);

            }
            studentsGridView.DataSource = studentsTable;


            var roomIdColumn = new DataColumn("RoomID", typeof(int))
            {
                Caption = "Romm Id",
                ReadOnly = true,
                AllowDBNull = false,
                Unique = true,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
            };

            var roomSizeColumn = new DataColumn("Size", typeof(int));
            var stuIdColumn = new DataColumn("Student Id", typeof(int));

            roomsTable.Columns.AddRange
                (new[] { roomIdColumn, roomSizeColumn, stuIdColumn });

            foreach (var l in roomList)
            {
                var newRow = roomsTable.NewRow();
                newRow[0] = l.RoomID;
                newRow[1] = l.Size;
                newRow[2] = l.StudentID;
                roomsTable.Rows.Add(newRow);

            }
            roomsGridView.DataSource = roomsTable;
        }


        private void StudentsDataView(int room)
        {
            //set the table that is used to construct this view
            studentsView = new DataView(studentsTable);

            //now configure the views using a filter
            studentsView.RowFilter = $"Room = {room} ";

            //bind the new grid
            studentsGridView.DataSource = studentsView;
        }
    }
}
