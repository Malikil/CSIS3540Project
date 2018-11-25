using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Mappers;
using ServerProgram.Seed;

namespace ServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedDatabase seeder = new SeedDatabase();
            //seeder.SeedStudents();
            //seeder.SeedAccounts(); Ok
            //seeder.SeedBuildingAndFloor(); 

            ClientListener server = new ClientListener();
            server.BeginWaitForConnections();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
            server.EndWaitForConnections();
            server.Disconnect();
        }
    }
}
