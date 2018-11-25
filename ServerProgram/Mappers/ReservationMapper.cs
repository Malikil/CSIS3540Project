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
        public static void CreateReservation(Reservation reservation)
        {
            var context = new CampusContext();
            context.Reservation.Add(reservation);
            context.SaveChanges();
        }
    }
}
