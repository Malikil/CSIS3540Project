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
        private readonly int AccountID;

        private DateTime startDate = DateTime.MinValue;
        private DateTime endDate = DateTime.MinValue;

        public StudentsReservations(int accid)
        {
            AccountID = accid;
            InitializeComponent();
        }

        private void GetAvailabilityFromServer_EventHandler(object sender, EventArgs e)
        {
            label1.Text = startPicker.Value.ToString("yyyy-MM-dd");
            label2.Text = endPicker.Value.ToString("yyyy-MM-dd");

            startDate = startPicker.Value.Date;
            endDate = endPicker.Value.Date.AddHours(1);

            List<DormRoom> rooms = DormRoomMapper.GetAvailableRoomsByDate(startDate, endDate);
            dataGridView1.DataSource = rooms;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservation newReservation = null;
            if (int.TryParse(textBoxRoomID.Text, out int rid)
                && startDate != DateTime.MinValue
                && endDate != DateTime.MinValue)
                newReservation = new Reservation()
                {
                    RoomID = rid,
                    AccountID = AccountID,
                    StartDate = startDate,
                    EndDate = endDate
                };

            if (newReservation == null)
                MessageBox.Show("Invalid room id or dates not set", "Invalid");
            else if (ReservationMapper.ValidateRoomReservation(newReservation))
            {
                ReservationMapper.CreateReservation(newReservation);
                MessageBox.Show($"Reservation Created with ID {newReservation.ResID}", "Success");
            }
            else
                MessageBox.Show("Reservation conflicts with existing reservation(s)", "Schedule Conflict");
        }
    }
}
