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
        /// <param name="res"></param>
        public static bool CheckAccountResDates(Reservation res)
        {
            //count people var
            int numRes = 0;

            //linq to check accout date res
            var people = from dbReservation in context.Reservation
                         where res.StartDate >= dbReservation.StartDate 
                         && res.EndDate <= dbReservation.EndDate 
                         && res.AccountID == dbReservation.AccountID
                         select dbReservation;

            //increment per res
            foreach (Reservation p in people)
                numRes++;

            //if one conflicting res exists
            if (numRes == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Check the capacity of the room by each day of the reservation period
        /// </summary>
        /// <param name="res"></param>
        public static bool CheckRoomAvailability(Reservation res)
        {
            List<Reservation> list =  ReadResearvationsByRoom(res.RoomID);

            // loop each date starting for res.startdate
            DateTime date = res.StartDate;
            while(date <= res.EndDate)
            {
                // check how many reservations exist in the date
                int numRes = CheckReservationsByDateAndRoom(res.RoomID ,date);

                // If capacity is bigger than the number of reservations 
                //for the specific date
                int cap = DormRoomMapper.GetRoomCapacityByID(res.RoomID);
                if (cap > numRes)
                {
                    date = date.AddDays(1);
                    continue;
                }
                else
                    return false;
            }

            if (date == res.EndDate.AddDays(1))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Calls the two validation methods and returns a boolean
        /// </summary>
        /// <param name="res"></param>
        public static bool ValidateRoomReservation(Reservation res)
        {
            bool acc = CheckAccountResDates(res);
            bool cap = CheckRoomAvailability(res);

            if (acc == true && cap == true)
                return true;
            else
                return false;
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
