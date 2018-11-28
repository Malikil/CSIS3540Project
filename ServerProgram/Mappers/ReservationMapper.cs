using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Entities;

namespace ServerProgram.Mappers
{
    class ReservationMapper
    {
        private static readonly CampusContext context = new CampusContext();

        public static void CreateReservation(Reservation reservation)
        {
            context.Reservation.Add(reservation);
            context.SaveChanges();
        }

        // TODO 
        // Get available rooms by date

        public static List<Reservation> ReadResearvationsByRoom(int roomid)
        {
            var list = from res in context.Reservation
                      where res.RoomID == roomid
                      select res;
            return list.ToList();
        }
      
        public static List<Reservation> ReadResearvationsByAccount(int accountid)
        {
            var list = from res in context.Reservation
                       where res.AccountID == accountid
                       select res;
            return list.ToList();
        }

        /// <summary>
        /// check number of reservations by account by date
        /// </summary>
        /// <param name="requested"></param>
        public static bool CheckAccountResDates(Reservation requested)
        {
            Account account = AccountMapper.GetAccountByID(requested.AccountID);

            var reservations = from existing in account.Reservations
                               where existing.EndDate >= requested.StartDate
                                    || existing.StartDate <= requested.EndDate
                               select existing;

            //if one conflicting res exists
            return reservations.Count() == 0;
        }

        /// <summary>
        /// Check the capacity of the room by each day of the reservation period
        /// </summary>
        /// <param name="res"></param>
        public static bool CheckRoomAvailability(Reservation res)
        {
            DormRoom room = DormRoomMapper.GetRoomByID(res.RoomID);
            // loop each date starting for res.startdate
            for (DateTime date = res.StartDate; date <= res.EndDate; date = date.AddDays(1))
            {
                var existing = from reservation in room.Reservations
                               where reservation.StartDate <= date
                                    && reservation.EndDate >= date
                               select reservation;

                //foreach (Reservation reservation in existing)
                //    Console.WriteLine($"Starts: {reservation.StartDate} " +
                //        $"Ends: {reservation.EndDate} " +
                //        $"Checking: {date} " +
                //        $"StartDate < date && EndDate > date returns: {reservation.StartDate < date && reservation.EndDate > date}")

                // check how many reservations exist in the date
                if (existing.Count() >= room.Capacity)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Calls the two validation methods and returns a boolean
        /// </summary>
        /// <param name="res"></param>
        public static bool ValidateRoomReservation(Reservation res)
        {
            return CheckAccountResDates(res)
                && CheckRoomAvailability(res);
        }

        /// <summary>
        /// Returns a list of Students that have made reservations for a DormRoom
        /// </summary>
        /// <param name="roomid"></param>
        public static List<Student> ReadStudentsByRoom(int roomid)
        {
            var st = (from res in context.Reservation
                      join a in context.Account on res.AccountID equals a.AccountID
                      join s in context.Student on a.StudentID equals s.StudentID
                      where a.StudentID == s.StudentID
                      select new 
                      {
                          s.StudentID,
                          s.Name,
                      }).Distinct();
            List<Student> students = new List<Student>();
            foreach(var s in st)
            {
                Student stu = new Student() {StudentID = s.StudentID, Name = s.Name };
                students.Add(stu);
                //Console.WriteLine($"{s.StudentID} {s.Name}");
            }

            return students;
        }

        /// <summary>
        /// Returns a list of Students that have made reservations for a DormRoom
        /// </summary>
        /// <param name="roomid"></param>
        public static List<string> WrongReadStudentsByRoom(int roomid)
        {
            var st = (from res in context.Reservation
                              join a in context.Account on res.AccountID equals a.AccountID
                              join s in context.Student on a.StudentID equals s.StudentID
                              where a.StudentID == s.StudentID
                              select new
                              {
                                  Id = a.StudentID.ToString(),
                                  Name = s.Name.ToString(),
                                  Start = res.StartDate.ToString(),
                                  End = res.EndDate.ToString()
                              });
            List<string> students = new List<string>();
            foreach (var s in st)
            {
                students.Add(s.ToString());
            }

            return students.ToList();
        }


        /// <summary>
        /// Check the number of reservations per room by a specific day 
        /// </summary>
        /// <param name="roomid"></param>
        /// /// <param name="date"></param>
        public static int CheckReservationsByDateAndRoom(int roomid, DateTime date)
        {
            int res = 0;

            var reservations = from dbReservation in context.Reservation
                         where date >= dbReservation.StartDate
                         && date <= dbReservation.EndDate
                         && roomid == dbReservation.RoomID
                         select dbReservation;

            foreach (Reservation p in reservations)
                res++;

            return res;
        }
    }
}
