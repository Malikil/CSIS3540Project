﻿using System;
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
        private readonly int AccountID;
        public AdminForm(int accid)
        {
            AccountID = accid;
            InitializeComponent();
        }

        private void LoadRoomsAndStudents(object sender, EventArgs e)
        {
            UpdateRoomList(DormRoomMapper.GetAllRooms());
            UpdateStudentsFromRoomList(StudentMapper.ReadAllStudents());
            UpdateStudentsList(StudentMapper.ReadAllStudents());
        }

        private void RoomSelectedFromList(object sender, DataGridViewCellEventArgs e)
        {
            int roomx;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = roomsGridView.Rows[index];
            roomx = int.Parse(selectedRow.Cells[0].Value.ToString());
            label1.Text = roomx.ToString();
            
        }

        private void UpdateRoomList(List<DormRoom> list)
        {
            roomsGridView.DataSource = (from room in list
                                        select new
                                        {
                                            room.RoomID,
                                            room.Size,
                                            room.Capacity,
                                            room.Floor.FloorNum,
                                            room.RoomNumber
                                        }).ToList();
        }

        private void UpdateStudentsFromRoomList(List<Student> list)
        {
            studentsGridView.DataSource = (from student in list
                                           let account = student.Accounts.FirstOrDefault()
                                           select new
                                           {
                                               student.StudentID,
                                               student.Name,
                                               account?.Reservations.FirstOrDefault()?.StartDate,
                                               account?.Reservations.FirstOrDefault()?.EndDate
                                           }).ToList();
        }

        private void UpdateStudentsList(List<Student> list)
        {
            StudentsSecondGridView.DataSource = (from student in list
                                           let account = student.Accounts.FirstOrDefault()
                                           select new
                                           {
                                               student.StudentID,
                                               student.Name,
                                               account?.Reservations.FirstOrDefault()?.StartDate,
                                               account?.Reservations.FirstOrDefault()?.EndDate
                                           }).ToList();
        }

        private void CloseFormButtonsClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertRoomButtonClicked(object sender, EventArgs e)
        {
            DormRoom newRoom = new DormRoom
            {
                Size = int.Parse(RoomSizeTextBox.Text),
                Capacity = int.Parse(roomCapacityTextBox.Text),
                FloorID = int.Parse(FloorIDTextBox.Text),
                RoomNumber = int.Parse(roomNumbertextBox.Text)
            };

            DormRoomMapper.CreateDormRoom(newRoom);

            UpdateRoomList(DormRoomMapper.GetAllRooms());
        }

        private void DeleteRoomButtonClicked(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDelete.Text, out int roomid))
                DormRoomMapper.DeleteDormRoomByID(roomid);
            UpdateRoomList(DormRoomMapper.GetAllRooms());
        }

        private void SearchStudentButtonClicked(object sender, EventArgs e)
        {
            if (int.TryParse(roomIdTextBoxSearch.Text, out int roomid))
            {
                UpdateStudentsFromRoomList(ReservationMapper.ReadStudentsByRoom(roomid));
            }
        }

        private void studentTab_Click(object sender, EventArgs e)
        {

        }

        private void CloseSecondFormButtonsClicked_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertStudentButtonClicked_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student()
            {
                Name = textBoxStudentName.Text,
                StudentID = int.Parse(textBoxStudentID.Text)               
            };

            StudentMapper.CreateStudent(newStudent);
            UpdateStudentsList(StudentMapper.ReadAllStudents());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(DeleteStudentTextBox.Text, out int studentid))
                StudentMapper.DeleteStudentByID(studentid);
            UpdateStudentsList(StudentMapper.ReadAllStudents());
        }
    }
}
