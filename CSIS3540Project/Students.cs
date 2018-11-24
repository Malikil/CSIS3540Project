using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS3540Project
{
    public partial class Students : Form
    {
        List<Student> studentsList = null;
        List<Room> roomList = null;
        DataTable studentsTable = new DataTable();
        DataTable roomsTable = new DataTable();
        DataView studentsView, roomsView;
        public int roomx;
        public Students()
        {
            InitializeComponent();

            studentsList = new List<Student>
            {
                new Student{StudentID = 1, Name="Jhon", LastName="Parker", Age=19, CellNumber=7781235252, Email="j.parker@mail.com", Room= "101-102-303"},
                new Student{StudentID = 2, Name="Diana", LastName="Jhones", Age=17, CellNumber=7784562585, Email="d.jhones@mail.com", Room="102"},
                new Student{StudentID = 3, Name="Jorge", LastName="Mesa", Age=18, CellNumber=7784561212, Email="j.mesa@mail.com", Room="201"},
                new Student{StudentID = 4, Name="Sammy", LastName="Liuten", Age=22, CellNumber=7787898585, Email="s.liuyen@mail.com", Room="202"},
                new Student{StudentID = 5, Name="Rachel", LastName="Tracy", Age=19, CellNumber=7781234552, Email="r.tracy@mail.com", Room="301"},
                new Student{StudentID = 6, Name="Sharyn", LastName="Tarazona", Age=18, CellNumber=7789635241, Email="s.tarazona@mail.com", Room="302"},
                new Student{StudentID = 7, Name="Roger", LastName="Torres", Age=18, CellNumber=7789635241, Email="s.tarazona@mail.com", Room="302"}

            };

            roomList = new List<Room>
            {
                new Room{RoomID = 101, Size=1, StudentID=1},
                new Room{RoomID = 102, Size=2, StudentID=2},
                new Room{RoomID = 201, Size=1, StudentID=3},
                new Room{RoomID = 202, Size=2, StudentID=4},
                new Room{RoomID = 301, Size=1, StudentID=5},
                new Room{RoomID = 302, Size=2, StudentID=6},
                new Room{RoomID = 303, Size=2, StudentID=0}

            };

            CreateDataTable();
        }

        private void studentsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stuId;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = studentsGridView.Rows[index];
            stuId = int.Parse(selectedRow.Cells[0].Value.ToString());
           // labelStudendSelected.Text = stuId.ToString();
            RoomsDataView(stuId);

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
            var studentRoomColumn = new DataColumn("Room", typeof(string));

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
            var stuIdColumn = new DataColumn("StudentId", typeof(int));

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentsDataView(int StudentID)
        {
            //set the table that is used to construct this view
            studentsView = new DataView(studentsTable);

            //now configure the views using a filter
            studentsView.RowFilter = $"StudentID = {StudentID} ";

            //bind the new grid
            studentsGridView.DataSource = studentsView;
        }

        private void RoomsDataView(int Student)
        {
            //set the table that is used to construct this view
            roomsView = new DataView(roomsTable);

            //now configure the views using a filter
            roomsView.RowFilter = $"StudentID = {Student} ";

            //bind the new grid
            roomsGridView.DataSource = roomsView;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(studentsIdTextBoxSearch.Text);
            StudentsDataView(filter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var l in studentsList)
            {
                studentsGridView.DataSource = studentsTable;
            }
            foreach (var l in roomList)
            {
                roomsGridView.DataSource = roomsTable;
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text, lastname = textBoxLastname.Text, email = textBoxEmail.Text, room = textBoxRoom.Text;
            int age = int.Parse(textBoxAge.Text), lenght = studentsList.Count(), last = lenght - 1, id = (studentsList[lenght - 1].StudentID) + 1;
            double phone = double.Parse(textBoxPhone.Text);

            studentsList.Add(new Student { StudentID = id, Name = name, LastName = lastname, Age = age, CellNumber = phone, Email = email, Room = room });

            var newRow = studentsTable.NewRow();
            //newRow[0] = studentsList[last].StudentID;
            newRow[1] = studentsList[lenght].Name;
            newRow[2] = studentsList[lenght].LastName;
            newRow[3] = studentsList[lenght].Age;
            newRow[4] = studentsList[lenght].CellNumber;
            newRow[5] = studentsList[lenght].Email;
            newRow[6] = studentsList[lenght].Room;
            studentsTable.Rows.Add(newRow);

            studentsGridView.DataSource = studentsTable;
            studentsTable.AcceptChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //find the correct row to delete
                DataRow[] rowToDelete = studentsTable.Select($"StudentID={int.Parse(textBoxDelete.Text)}");

                //delete the row
                rowToDelete[0].Delete();
                studentsTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
