using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Mappers;
using System.Threading;
using ServerProgram.Seed;
using ServerProgram.Entities;

namespace ServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CommandListener server = new CommandListener();
#pragma warning disable CS4014
            server.WaitForConnections(tokenSource.Token);
#pragma warning restore CS4014

            // Reservation Validation Test
            /*DateTime datetime = new DateTime(2018, 01, 29);
            Reservation res = new Reservation()
            {
                AccountID = 250,
                RoomID = 4,
                StartDate = datetime,
                EndDate = datetime.AddDays(9)
            };

            //ReservationMapper.ValidateReservation(res);
            //ReservationMapper.CheckPeopleDates(res);
            bool b = ReservationMapper.ValidateRoomReservation(res);
            Console.WriteLine(b.ToString());
            */

            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
            Console.WriteLine("Quitting server...");
            tokenSource.Cancel();
        }
    }
}
