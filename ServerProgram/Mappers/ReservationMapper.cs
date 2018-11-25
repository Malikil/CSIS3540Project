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
    }
}
