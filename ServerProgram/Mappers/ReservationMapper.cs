using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram.Mappers
{
    class ReservationMapper
    {
        public void CreateReservation(Reservation reservation)
        {
            var context = new CampusContext();
            context.Reservation.Add(reservation);
            context.SaveChanges();
        }
    }
}
