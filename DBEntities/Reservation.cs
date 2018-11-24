using System;

namespace DBEntities
{
    public class Reservation
    {
        public int ResID { get; set; }
        public int AccountID { get; set; }
        public int RoomID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
