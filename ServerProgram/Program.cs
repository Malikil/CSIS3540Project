using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerProgram.Mappers;

namespace ServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test calls
            //Test t = new Test();
            //t.AddStudentTest();
            //t.AddAccountTest();

            //StudentMapper studentMapper = new StudentMapper();
            //studentMapper.ReadAllStudents();
            //studentMapper.ReadStudentByID(12345);
            //AccountMapper accountMapper = new AccountMapper();
            //accountMapper.ReadAllAccounts();


            IClientListener server = new ClientListener();
            server.BeginWaitForConnections();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
            server.EndWaitForConnections();
            server.Disconnect();
            
        }
    }
}
