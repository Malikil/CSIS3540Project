using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerProgram.Entities;
using ServerProgram.Mappers;
using System.Xml.Serialization;

namespace ServerProgram.Forms
{
    public partial class StudentsReservations : Form
    {
        
        public StudentsReservations()
        {
            InitializeComponent();
        }

        private void GetAvailabilityFromServer_EventHandler(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            label2.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            List<DormRoom> rooms = DormRoomMapper.GetAvailableRoomsByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = rooms;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservation newReservation = new Reservation()
            {
                RoomID = int.Parse(textBoxRoomID.Text),
                AccountID = int.Parse(textBoxAccountID.Text),
                StartDate = dateTimePicker1.Value,
                EndDate = dateTimePicker2.Value

            };

            bool validation = ReservationMapper.ValidateRoomReservation(newReservation);
            if (validation)
            {
                ReservationMapper.CreateReservation(newReservation);
            }
            else
            {
                ReservationMapper.CreateReservation(newReservation);
                MessageBox.Show("Try again");
            }
        }
    }
}
