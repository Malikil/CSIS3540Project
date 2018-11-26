using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DBEntities;
using ServerProgram.Mappers;
using ServerProgram.Entities;
//using System.IO.Pipes;
//using System.IO;
//using System.Xml.Serialization;

namespace ServerProgram.Forms
{
    public partial class AdminForm : Form
    {
        List<Student> studentsList = null;
        private List<DormRoom> roomList = null;
        DataTable studentsTable = new DataTable();
        DataTable roomsTable = new DataTable();
        DataView studentsView, roomsView;
        public int roomx;

        public AdminForm()
        {
            InitializeComponent();

            studentsList = new List<Student>
            {
                new Student{StudentID = 1, Name="Jhon"},
                new Student{StudentID = 2, Name="Diana"},
                new Student{StudentID = 3, Name="Jorge"},
                new Student{StudentID = 4, Name="Sammy"},
                new Student{StudentID = 5, Name="Rachel"},
                new Student{StudentID = 6, Name="Sharyn"},
                new Student{StudentID = 7, Name="Roger"}
            };

            //roomList = new List<DormRoom>
            //{
            //    new DormRoom{RoomID = 101, Size=1},
            //    new DormRoom{RoomID = 102, Size=2},
            //    new DormRoom{RoomID = 201, Size=1},
            //    new DormRoom{RoomID = 202, Size=2},
            //    new DormRoom{RoomID = 301, Size=1},
            //    new DormRoom{RoomID = 302, Size=2}

            //};

            //CreateDataTable();
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
            //var studentIdColumn = new DataColumn("StudentID", typeof(int))
            //{
            //    Caption = "Student Id",
            //    ReadOnly = true,
            //    AllowDBNull = false,
            //    Unique = true,
            //    AutoIncrement = true,
            //    AutoIncrementSeed = 1,
            //    AutoIncrementStep = 1,
            //};

            //var studentNameColumn = new DataColumn("Name", typeof(string));

            //studentsTable.Columns.AddRange
            //    (new[] { studentIdColumn, studentNameColumn });

            //foreach (var l in studentsList)
            //{
            //    var newRow = studentsTable.NewRow();
            //    newRow[0] = l.StudentID;
            //    newRow[1] = l.Name;
            //    studentsTable.Rows.Add(newRow);

            //}
            //studentsGridView.DataSource = studentsTable;


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
            var roomCapacityColumn = new DataColumn("Capacity", typeof(int));
            var roomFloorIdColumn = new DataColumn("FloorID", typeof(int));
            var roomNumberColumn = new DataColumn("RoomNumber", typeof(int));

            roomsTable.Columns.AddRange
                (new[] { roomIdColumn, roomSizeColumn, roomCapacityColumn, roomFloorIdColumn, roomNumberColumn });

            foreach (var l in roomList)
            {
                var newRow = roomsTable.NewRow();
                newRow[0] = l.RoomID;
                newRow[1] = l.Size;
                newRow[2] = l.Capacity;
                newRow[3] = l.FloorID;
                newRow[4] = l.RoomNumber;
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

        private void RoomsDataView(int room)
        {
            //set the table that is used to construct this view
            roomsView = new DataView(roomsTable);

            //now configure the views using a filter
            roomsView.RowFilter = $"RoomID = {room} ";

            //bind the new grid
            roomsGridView.DataSource = roomsView;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            foreach (var l in studentsList)
            {
                studentsGridView.DataSource = studentsTable;
            }
            //foreach (var l in roomList)
            //{
            //    roomsGridView.DataSource = roomsTable;
            //}
        }




        #region send to server example
        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            roomList = new List<DormRoom>(DormRoomMapper.ReadAllRooms());
            CreateDataTable();

        }

        
        #endregion

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //find the correct row to delete
                DataRow[] rowToDelete = roomsTable.Select($"RoomID={int.Parse(textBoxDelete.Text)}");

                //delete the row
                rowToDelete[0].Delete();
                roomsTable.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            int filter = int.Parse(roomIdTextBoxSearch.Text);
            RoomsDataView(filter);
        }
    }
}
