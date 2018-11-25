using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Mappers;
using System.Threading;
using ServerProgram.Seed;

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

            SeedDatabase seeder = new SeedDatabase();
            //seeder.SeedStudents();
            //seeder.SeedAccounts(); Ok
            //seeder.SeedBuildingAndFloor(); 
            //seeder.SeedDormRooms();
            seeder.SeedReservations();
            
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
            Console.WriteLine("Quitting server...");
            tokenSource.Cancel();
        }
    }
}
